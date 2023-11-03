<?php

namespace models;

use models\base\SQL;
use utils\EmailUtils;
use utils\SessionHelpers;
use utils\TokenHelpers;

class EmprunteurModel extends SQL
{
    public function __construct()
    {
        parent::__construct('emprunteur', 'idemprunteur');
    }

    public function connexion(mixed $email, mixed $password)
    {
        /**
         * Rappel
         *
         * La validation du compte est un int qui prend plusieurs valeurs :
         * 0 : Compte non validé
         * 1 : email validé
         * 2 : Compte validé par un admin
         * 3 : Compte banni
         * 4 : Compte supprimé
         */

        // TODO Il ne faut pas autoriser la connexion si le compte n'est pas validé

        $sql = 'SELECT * FROM emprunteur WHERE emailemprunteur = ?';
        $stmt = parent::getPdo()->prepare($sql);
        $stmt->execute([$email]);
        $user = $stmt->fetch(\PDO::FETCH_OBJ);

        if ($user == null) {
            return "Compte Inexistant";
        }

        if (password_verify($password, $user->motpasseemprunteur)) {
            if ($user->validationcompte == 0) {
                return "Veuillez valider votre compte via le lien distribué par mail";
            } else if ($user->validationcompte == 3 || $user->validationcompte == 4) {
                return "Ce compte n'est malheureusement plus accessible";
            }
            if ($user->validationcompte == 1 || $user->validationcompte == 2) {
                SessionHelpers::login($user);
                return "true";
            }
        }
        return "Ce compte nous est inconnu";
    }

    public function creerEmprenteur(mixed $email, mixed $password, mixed $nom, mixed $prenom, mixed $phoneNumber, mixed $localisation): bool
    {
        // Création du hash du mot de passe (pour le stockage en base de données)
        $password_hash = password_hash($password, PASSWORD_DEFAULT);
        $config = include("configs.php");

        try {
            // Création de l'utilisateur en base de données.

            // La validation du compte est un int qui prend plusieurs valeurs :
            // 0 : Compte non validé
            // 1 : email validé
            // 2 : Compte validé par un admin
            // 3 : Compte banni
            // 4 : Compte supprimé

            $UUID = TokenHelpers::guidv4(); // Génération d'un UUID v4, qui sera utilisé pour la validation du compte
            $sql = 'INSERT INTO emprunteur (emailemprunteur, motpasseemprunteur, nomemprunteur, prenomemprunteur, idLocalisation, datenaissance, telportable, validationcompte, validationtoken) VALUES (?, ?, ?, ?, ?, NOW(), ?, 0, ?)';
            $stmt = parent::getPdo()->prepare($sql);
            $result = $stmt->execute([$email, $password_hash, $nom, $prenom, $localisation, $phoneNumber, $UUID]);

            if ($result) {
                // Envoi d'un email de validation du compte
                // On utilise la fonction sendEmail de la classe EmailUtils
                // L'email contient un lien vers la page de validation du compte, avec l'UUID généré précédemment
                EmailUtils::sendEmail($email, "Bienvenue $nom", "newAccount",
                    array(
                        "url" => $config["URL_VALIDATION"] . $UUID,
                        "email" => $email,
                        "password" => $password
                    )
                );
            }

            return true;
        } catch (\Exception $e) {
            die($e->getMessage());
            return false;
        }
    }

    /**
     * Récupère tous les utilisateurs sans leur mot de passe.
     * @return array
     */
    public function getAllWithoutPassword(): array
    {
        $all = parent::getAll();

        // Ici, on utilise la fonction array_map qui permet d'appliquer une fonction sur tous les éléments d'un tableau
        // L'autre solution est d'utiliser une boucle foreach ou via une requête SQL avec un SELECT qui ne récupère pas le mot de passe
        return array_map(function ($user) {
            // On supprime le mot de passe de l'utilisateur
            unset($user->motpasseemprunteur);

            // On retourne l'utilisateur
            return $user;
        }, $all);
    }

    // Gestion de la validation par mail du compte
    public function validateAccount($uuid)
    {
        $stmt = $this->getPdo()->prepare("SELECT * FROM emprunteur WHERE validationtoken = ?;");
        $stmt->execute([$uuid]);
        $result = $stmt->fetch(\PDO::FETCH_OBJ);

        if ($result->validationtoken == $uuid) {
            $stmt = $this->getPdo()->prepare("UPDATE emprunteur SET validationcompte = 1, validationtoken = uuid() WHERE idemprunteur = ?;");
            $stmt->execute([$result->idemprunteur]);

            return true;
        }

        return false;
    }

    // edition d'un emprunteur
    public function editEmpruteur($id, $nom, $email, $prenom, $ville, $dateNaissance, $telephone, $password) {

        $newPassword = password_hash($password, PASSWORD_DEFAULT);
        $stmt = $this->getPdo()->prepare("UPDATE emprunteur SET nomemprunteur = ?, prenomemprunteur = ?, idLocalisation = ?, emailemprunteur = ?, datenaissance = ?, telportable = ?, motpasseemprunteur = ? WHERE idemprunteur = ?");
        $stmt->execute([$nom, $prenom, $ville, $email, $dateNaissance, $telephone, $newPassword, $id]);
    }

}