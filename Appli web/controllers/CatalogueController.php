<?php

namespace controllers;

use controllers\base\WebController;
use models\CategorieModel;
use models\ExemplaireModel;
use models\RessourceModel;
use utils\Template;

class CatalogueController extends WebController
{

    private RessourceModel $ressourceModel;
    private CategorieModel $categorieModel;
    private ExemplaireModel $exemplaireModel;

    function __construct()
    {
        $this->ressourceModel = new RessourceModel();
        $this->exemplaireModel = new ExemplaireModel();
        $this->categorieModel = new CategorieModel();
    }

    /**
     * Affiche la liste des ressources.
     * @param string $type
     * @return string
     */
    function liste(string $categorie): string
    {
        // Récupération de toutes les categories
        $categories = $this->categorieModel->getAll();

        // L'utilisateur souhaite visualiser toutes les ressources
        if ($categorie == "all") {

            $catalogue = $this->ressourceModel->getAll();

            return Template::render("views/catalogue/liste.php", array("titre" => "Ensemble du catalogue", "catalogue" => $catalogue, "categories" => $categories));
        }
        // L'utilisateur souhaite visualiser certaines type de ressource ex : BD, Livre
        else if ($categorie == "tri")
        {

            $catalogue = $this->ressourceModel->getRessourceFilter($_GET['categories']);

            return Template::render("views/catalogue/liste.php", array("titre" => "Ensemble du catalogue", "catalogue" => $catalogue, "categories" => $categories));
        }
    }

    /**
     * Affiche le détail d'une ressource.
     * @param int $id
     * @return string
     */
    function detail(int $id): string
    {
        // Récupération de la ressource
        $ressource = $this->ressourceModel->getOne($id);

        if ($ressource == null) {
            $this->redirect("/");
        }

        // Récupération des exemplaires de la ressource
        $exemplaires = $this->exemplaireModel->getByRessource($id);
        $exemplaire = null;

        // Pour l'instant, on ne gère qu'un exemplaire par ressource.
        // Si on en trouve plusieurs, on prend le premier.
        if ($exemplaires && sizeof($exemplaires) > 0) {
            $exemplaire = $exemplaires[0];
        }


        return Template::render("views/catalogue/detail.php", array("ressource" => $ressource, "exemplaire" => $exemplaire));
    }
}