<?php

namespace controllers;

use controllers\base\WebController;
use models\CommentaireModel;
use models\EmprunterModel;
use models\EmprunteurModel;
use models\ExemplaireModel;
use models\LocalisationModel;
use utils\EmailUtils;
use utils\SessionHelpers;
use utils\Template;

class UserController extends WebController
{
    // On déclare les modèles utilisés par le contrôleur.
    private EmprunteurModel $emprunteur; // Modèle permettant d'interagir avec la table emprunteur
    private EmprunterModel $emprunter; // Modèle permettant l'emprunt
    private LocalisationModel $localisation;
    private ExemplaireModel $exemplaireModel;
    private CommentaireModel $commentaireModel;

    function __construct()
    {
        $this->emprunteur = new EmprunteurModel();
        $this->emprunter = new EmprunterModel();
        $this->localisation = new LocalisationModel();
        $this->commentaireModel = new CommentaireModel();
        $this->exemplaireModel = new ExemplaireModel();
    }

    /**
     * Déconnecte l'utilisateur.
     * @return string
     */
    function logout(): string
    {
        if (!SessionHelpers::isConnected()) $this->redirect('/');

        SessionHelpers::logout();
        return $this->redirect("/");
    }

    /**
     * Affiche la page de connexion.
     * Si l'utilisateur est déjà connecté, il est redirigé vers sa page de profil.
     * Si la connexion échoue, un message d'erreur est affiché.
     * @return string
     */
    function  login(): string
    {
        $data = array();

        // Si l'utilisateur est déjà connecté, on le redirige vers sa page de profil
        if (SessionHelpers::isConnected()) {
            return $this->redirect("/me");
        }


        // Gestion de la connexion
        if (isset($_POST["email"]) && isset($_POST["password"])) {
            $result = $this->emprunteur->connexion(htmlspecialchars($_POST["email"]), htmlspecialchars($_POST["password"]));

            // Si la connexion est réussie, on redirige l'utilisateur vers sa page de profil
            if ($result == "true") {
                // Envoi email de connexion
                $user = SessionHelpers::getConnected();
                EmailUtils::sendEmail($user->emailemprunteur, "Connexion", "connexion", array("name" => $user->nomemprunteur, "prenom" => $user->prenomemprunteur, "title" => "Connexion à votre comptre"));
                $this->redirect("/me");
            } else {
                // Sinon, on affiche un message d'erreur
                $data["error"] = $result;
            }
        }

        // Affichage de la page de connexion
        return Template::render("views/user/login.php", $data);
    }

    /**
     * Affiche la page d'inscription.
     * Si l'utilisateur est déjà connecté, il est redirigé vers sa page de profil.
     * Si l'inscription échoue, un message d'erreur est affiché.
     * @return string
     */
    function signup(): string
    {
        $data = array();
        $error = "";

        // Si l'utilisateur est déjà connecté, on le redirige vers sa page de profil
        if (SessionHelpers::isConnected()) {
            return $this->redirect("/me");
        }

        $localisation = $this->localisation->getAll();

        // Gestion de l'inscription
        if (isset($_POST["email"]) && isset($_POST["password"]) && isset($_POST["nom"]) && isset($_POST["prenom"]) && isset($_POST["phoneNumber"]) && $_POST["ville"] != "") {
            if (!$this->verifMotDePasse(htmlspecialchars($_POST["password"])))
            {
                $error .= "Mot de passe incorrect ! 8 caractères minimum, majuscule, chiffre, caractère spécial. ";
            }
            if (!$this->verifEmail(htmlspecialchars($_POST["email"])))
            {
                $error .= "Email incorrect. ";
            }
            if (!$this->verifNumeroTelephone(htmlspecialchars($_POST["phoneNumber"])))
            {
                $error .= "Numéro de téléphone incorrect. ";
            }
            if ($error == "")
            {
                $result = $this->emprunteur->creerEmprenteur(htmlspecialchars($_POST["email"]), htmlspecialchars($_POST["password"]), htmlspecialchars($_POST["nom"]), htmlspecialchars($_POST["prenom"]), htmlspecialchars($_POST["phoneNumber"]), htmlspecialchars($_POST["ville"]));
            } else
            {
                return Template::render("views/user/signup.php", ["error" => $error, "localisation" => $localisation]);
            }

            // Si l'inscription est réussie, on affiche un message de succès
            if ($result) {
                return Template::render("views/user/signup-success.php");
            } else {
                $data["error"] = "La création du compte a échoué";
            }
        }

        // Affichage de la page d'inscription
        return Template::render("views/user/signup.php", ["data" => $data, "localisation" => $localisation]);
    }

    function signupValidate($uuid){
        $result = $this->emprunteur->validateAccount($uuid);

        if($result){
            // Affichage de la page de finalisation de l'inscription
            return Template::render("views/user/signup-validate-success.php");
        }else{
            // Gestion d'erreur à améliorer
            return parent::redirect("/");
        }
    }

    /**
     * Affiche la page de profil de l'utilisateur connecté.
     * Si l'utilisateur n'est pas connecté, il est redirigé vers la page de connexion.
     * @return string
     */
    function me(): string
    {

        if (!SessionHelpers::isConnected()) $this->redirect('/');

        // Récupération de l'utilisateur connecté en SESSION.
        // La variable contient les informations de l'utilisateur présent en base de données.
        $user = SessionHelpers::getConnected();

        // Récupération des   unts de l'utilisateur
        $emprunts = $this->emprunter->getEmprunts($user->idemprunteur);
        $empruntsDelay = $this->emprunter->getEmpruntsDelay($user->idemprunteur);
        $ville = $this->localisation->getVilleOfuser($user->idLocalisation);
        $localisation = $this->localisation->getAll();
        return Template::render("views/user/me.php", array("user" => $user, "emprunts" => $emprunts, "empruntsDelay" => $empruntsDelay, "ville" => $ville, "localisation" => $localisation));
    }

    /**
     * Affiche la page de profil d'un utilisateur.
     * Si l'utilisateur n'est pas connecté, il est redirigé vers la page de connexion.
     * Pour accéder à la page il faut également l'id de la ressource et l'id de l'exemplaire.
     * @return string
     */
    function emprunter(): string
    {

        if (!SessionHelpers::isConnected()) $this->redirect('/');

        // Id à emprunter
        $idRessource = $_POST["idRessource"];
        $idExemplaire = $_POST["idExemplaire"];
        $ressource = $this->emprunter->getRessource($idRessource);

        // Récupération de l'utilisateur connecté en SESSION.
        $user = SessionHelpers::getConnected();

        if (!$user || !$idRessource || !$idExemplaire) {
            // Gestion d'erreur à améliorer
            $this->redirect('/me');
        }

        $userEmprunt = $this->emprunter->getAllEmprunts($user->idemprunteur);

        // Gestion du nombre d'emprunt
        if(count($userEmprunt) >= 3) {

            $exemplaires = $this->exemplaireModel->getByRessource($idRessource);
            $exemplaire = null;

            if ($exemplaires && sizeof($exemplaires) > 0) {
                $exemplaire = $exemplaires[0];
            }

            $commentaires = $this->commentaireModel->getComByRessources($idRessource);

            return Template::render('views/catalogue/detail.php', array("ressource" => $ressource, "exemplaire" => $exemplaire, "commentaires" => $commentaires, "error" => "Vous avez dépassé le nombre d'emprunt autorisé"));
        } else {
            $result = $this->emprunter->declarerEmprunt($idRessource, $idExemplaire, $user->idemprunteur);
        }

        if ($result) {
            // Envoi de l'email confirmation d'emprunt
            EmailUtils::sendEmail($user->emailemprunteur, "Emprunt", "emprunt", array("name" => $user->nomemprunteur, "title" => $ressource->titre));

            $this->redirect("/me");
        } else {
            // Gestion d'erreur à améliorer
            die("Erreur lors de l'emprunt");

        }
    }

    // Télécharger les données au format jsonS
    function download() {

        if (!SessionHelpers::isConnected()) $this->redirect('/');

        // Récupération de l'utilisateur connecté en SESSION.
        $user = SessionHelpers::getConnected();

        header('Content-Disposition: attachment; filename=user.json');
        header('Content-Type: application/json; charset=utf-8');

        // Données de l'utilisateur
        $data = array('nom' => $user->nomemprunteur, 'prenom' => $user->prenomemprunteur, 'date2naissance' => $user->datenaissance, 'email' => $user->emailemprunteur, 'telephone' => $user->telportable);
        echo json_encode($data, JSON_PRETTY_PRINT);

        // récupération des emprunts d'un utilisateur
        $emprunts = $this->emprunter->getEmprunts($user->idemprunteur);

        foreach ($emprunts as $e) {
             $data = array('titre' => $e->titre, 'date emprunt' => $e->datedebutemprunt, 'Durée emprunt' => $e->dureeemprunt, 'Date de retour' => $e->dateretour, 'description' => $e->description, 'année de sortie' => $e->anneesortie, 'langue' => $e->langue, 'type de la ressource' => $e->libellecategorie);
            echo json_encode($data, JSON_PRETTY_PRINT);
        }

    }

    // Édition du profil
    function edit($id, $nom, $email, $prenom, $dateNaissance, $telephone, $password, $ville) {

        if (!SessionHelpers::isConnected()) $this->redirect('/');

        // Ajout des données de l'utilsateur
        $this->emprunteur->editEmpruteur(htmlspecialchars($id), htmlspecialchars($nom), htmlspecialchars($email), htmlspecialchars($prenom), htmlspecialchars($ville), htmlspecialchars($dateNaissance), htmlspecialchars($telephone), htmlspecialchars($password));

        $user = $this->emprunteur->getOne($id);
        SessionHelpers::login($user);

        $this->redirect("/me");
    }

    // Rendre une ressource
    function rendre($idEmp, $idR, $idEx, $dateD) {
        header('Content-Type: application/json');
        header('Access-Control-Allow-Origin: *');


        if ($this->emprunter->rendreEmprunt($idEmp, $idR, $idEx, $dateD)) {
            return json_encode(array("isConfirmed" => true));
        } else {
            return json_encode(array("isConfirmed" => false));
        }
    }

    function forgetPassword() {
        return Template::render("views/user/forgetPassword.php");
    }

    function sendMailForForgetPassword($email) {

        $error = "";

        if(!isset($email)) {
            $error .= "Veuillez entrez un mot de passe ! ";
        }

        if (!$this->emprunteur->checkEmail(htmlspecialchars($email)))
        {
            $error .= "Email incorrect. ";
            return Template::render("views/user/forgetPassword.php", ["error" => $error]);
        } else {
            return Template::render('views/user/succesForgetPassword.php');
        }
    }

    function resetPassword($uuid) {
        if (isset($_POST['password'])) {
            if ($this->verifMotDePasse(htmlspecialchars($_POST["password"]))) {
                $this->emprunteur->resetPassword(htmlspecialchars($_POST['password']) ,htmlspecialchars($uuid));
                return Template::render('views/user/login.php');
            } else {
                $error = "Le mot de passe doit contenir minimum 8 caractères, majuscule, chiffre, caractère spécial !";
                return Template::render('views/user/resetPassword.php', ["uuid" => $uuid ,"error" => $error]);
            }
        }
        return Template::render('views/user/resetPassword.php', ["uuid" => $uuid]);
    }

    function deleteAccount() {

        if (!SessionHelpers::isConnected()) $this->redirect('/');

        $user = SessionHelpers::getConnected();

        $this->emprunteur->deleteAccount($user->idemprunteur);
        SessionHelpers::logout();
        $this->redirect('/');
    }

    // Vérifier la validiter d'un mdp
    function verifMotDePasse($motDePasse) {
        if (strlen($motDePasse) < 8) {
            return false;
        }
        if (!preg_match('/[A-Z]/', $motDePasse) || !preg_match('/[a-z]/', $motDePasse) || !preg_match('/[0-9]/', $motDePasse) || !preg_match('/[^A-Za-z0-9]/', $motDePasse)) {
            return false;
        }
        return true;
    }

    function verifEmail($email) {
        if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
            return false;
        }
        return true;
    }

    function verifNumeroTelephone($numero) {
        // Supprimez tout sauf les chiffres
        $numero = preg_replace("/[^0-9]/", "", $numero);

        // Vérifiez si le numéro a une longueur valide
        return (strlen($numero) === 10);
    }

}