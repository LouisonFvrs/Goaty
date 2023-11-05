<?php

namespace controllers;

use controllers\base\WebController;
use models\RessourceModel;
use utils\EmailUtils;
use utils\Template;

/**
 * Controleur de la page d'accueil
 */
class MainController extends WebController
{

    private RessourceModel $ressourceModel;

    public function __construct()
    {
        $this->ressourceModel = new RessourceModel();
    }

    /**
     * Affiche la page d'accueil.
     * @return string
     */
    function home($ressource = "", $city = ""): string
    {

        $catalogue = array();

        if ($ressource != "" || $city != "") {
            $catalogue = $this->ressourceModel->recherche($ressource, $city);
        }

        // Affichage de la page à l'utilisateur
        return Template::render("views/global/home.php", ["catalogue" => $catalogue]);
    }
}