<?php
namespace controllers;

use controllers\base\WebController;
use utils\Template;

/**
 * Controleur de la documentation de l'API
 */
class ApiDocController extends WebController
{
    function liste(): string
    {
        if (\utils\SessionHelpers::getConnected()->idRole == 1) {
            return Template::render("views/apidoc/liste.php", array());
        } else {
            $this->redirect('/');
        }
    }
}