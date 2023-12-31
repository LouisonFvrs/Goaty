<?php

namespace models;

use models\base\SQL;

class EmprunterModel extends SQL
{
    public function __construct()
    {
        parent::__construct('emprunter', 'idemprunter');
    }

    /**
     * Déclare un emprunt dans la base de données.
     * @param $idRessource identifiant de la ressource empruntée (idressource)
     * @param $idExemplaire identifiant de l'exemplaire emprunté (idexemplaire)
     * @param $idemprunteur identifiant de l'emprunteur (lecteur)
     * @return bool true si l'emprunt a été déclaré, false sinon.
     */
    public function declarerEmprunt($idRessource, $idExemplaire, $idemprunteur): bool
    {
        try {
            $sql = 'INSERT INTO emprunter (idressource, idexemplaire, idemprunteur, datedebutemprunt, dureeemprunt, dateretour, idEtatEmprunt) VALUES (?, ?, ?, NOW(), 30, DATE_ADD(NOW(), INTERVAL 1 MONTH), 1)';
            $stmt = parent::getPdo()->prepare($sql);

            return $stmt->execute([$idRessource, $idExemplaire, $idemprunteur]);
        } catch (\PDOException $e) {
            return false;
        }
    }

    public function rendreEmprunt($idRessource, $idExemplaire, $idEmprunteur, $date)
    {

        try {
            $sql = 'UPDATE emprunter SET emprunter.idEtatEmprunt = 2 WHERE emprunter.idemprunteur = ? AND emprunter.idressource = ? AND emprunter.idexemplaire = ? AND emprunter.datedebutemprunt = "?";';
            $stmt = parent::getPdo()->prepare($sql);

            return $stmt->execute([$idEmprunteur, $idRessource, $idExemplaire, $date]);
        } catch (\PDOException $e) {
            return false;
        }
    }

    /**
     * Récupère les emprunts en retard d'un emprunteur
     * @param $idemprunteur
     * @return bool
     */
    public function getEmpruntsDelay($idemprunteur): bool|array
    {
        try {
            $sql = 'SELECT * FROM emprunter LEFT JOIN ressource ON emprunter.idressource = ressource.idressource LEFT JOIN categorie ON categorie.idcategorie = ressource.idcategorie LEFT JOIN etatEmprunt on emprunter.idEtatEmprunt = etatEmprunt.id WHERE idemprunteur = ? AND dateretour < CURDATE() and emprunter.idEtatEmprunt != 3';
            $stmt = parent::getPdo()->prepare($sql);
            $stmt->execute([$idemprunteur]);
            return $stmt->fetchAll(\PDO::FETCH_OBJ);
        } catch (\PDOException $e) {
            return false;
        }
    }

    // Récupère les emprunts qui ne sont pas en retard
    public function getEmprunts($idemprunteur): bool|array
    {
        try {
            $sql = 'SELECT * FROM emprunter LEFT JOIN ressource ON emprunter.idressource = ressource.idressource LEFT JOIN categorie ON categorie.idcategorie = ressource.idcategorie LEFT JOIN etatEmprunt on emprunter.idEtatEmprunt = etatEmprunt.id WHERE idemprunteur = ? AND dateretour >= CURDATE() and emprunter.idEtatEmprunt != 3';
            $stmt = parent::getPdo()->prepare($sql);
            $stmt->execute([$idemprunteur]);
            return $stmt->fetchAll(\PDO::FETCH_OBJ);
        } catch (\PDOException $e) {
            return false;
        }
    }

    public function getAllEmprunts($idemprunteur): bool|array
    {
        try {
            $sql = 'SELECT * FROM emprunter LEFT JOIN etatEmprunt on emprunter.idEtatEmprunt = etatEmprunt.id WHERE idemprunteur = ? and emprunter.idEtatEmprunt != 3';
            $stmt = parent::getPdo()->prepare($sql);
            $stmt->execute([$idemprunteur]);
            return $stmt->fetchAll(\PDO::FETCH_OBJ);
        } catch (\PDOException $e) {
            return false;
        }
    }
    public function getRessource($idRessource)
    {
        try {
            $sql = 'SELECT * FROM ressource WHERE idressource = ?';
            $stmt = parent::getPdo()->prepare($sql);
            $stmt->execute([$idRessource]);
            return $stmt->fetch(\PDO::FETCH_OBJ);
        } catch (\PDOException $e) {
            return false;
        }
    }

    /**
     * Retourne les 5 ressources les plus empruntées.
     * @return array|false
     */
    public function getTopEmprunts(): array
    {
        try {
            $sql = 'SELECT COUNT(emprunter.idressource) AS nbEmprunt, titre, emprunter.idressource FROM emprunter LEFT JOIN ressource ON emprunter.idressource = ressource.idressource GROUP BY emprunter.idressource ORDER BY nbEmprunt DESC LIMIT 5';
            $stmt = parent::getPdo()->prepare($sql);
            $stmt->execute();
            return $stmt->fetchAll(\PDO::FETCH_OBJ);
        } catch (\PDOException $e) {
            echo $e->getMessage();
            return [];
        }
    }
}