<?php
namespace models;

use models\base\SQL;

class RessourceModel extends SQL
{
    public function __construct()
    {
        parent::__construct('ressource', 'idressource');
    }

    public function getAll(): array
    {
        $sql = 'SELECT * FROM ressource LEFT JOIN categorie ON categorie.idcategorie = ressource.idcategorie';
        $stmt = parent::getPdo()->prepare($sql);
        $stmt->execute();
        return $stmt->fetchAll(\PDO::FETCH_OBJ);
    }

    public function getAllForLocation($idLocation): array
    {
        $sql = 'SELECT * FROM ressource LEFT JOIN categorie ON categorie.idcategorie = ressource.idcategorie INNER JOIN exemplaire ON exemplaire.idressource = ressource.idressource WHERE idLocalisation = ?';
        $stmt = parent::getPdo()->prepare($sql);
        $stmt->execute([$idLocation]);
        return $stmt->fetchAll(\PDO::FETCH_OBJ);
    }

    public function getRandomRessource($limit = 3)
    {
        $sql = 'SELECT * FROM ressource LEFT JOIN categorie ON categorie.idcategorie = ressource.idcategorie  ORDER BY RAND() LIMIT ?';
        $stmt = parent::getPdo()->prepare($sql);
        $stmt->execute([$limit]);
        return $stmt->fetchAll(\PDO::FETCH_OBJ);
    }

    // Récupère les ressources selon les catégories spécifiés
    public function getRessourceFilter($tabOfCategorie) {

        $endOfSentence = "";

        foreach ($tabOfCategorie as $categorie) {
            $endOfSentence .= " categorie.idcategorie = " . $categorie . " OR";
        }

        $sql = 'SELECT * FROM ressource LEFT JOIN categorie ON categorie.idcategorie = ressource.idcategorie WHERE '. $endOfSentence;
        $sql = substr($sql, 0, strlen($sql)-2);

        $stmt = parent::getPdo()->prepare($sql);
        $stmt->execute();
        return $stmt->fetchAll(\PDO::FETCH_OBJ);
    }

    public function getRessourceFilterForLocation($tabOfCategorie, $idLocation) {

        $endOfSentence = "";

        foreach ($tabOfCategorie as $categorie) {
            $endOfSentence .= " categorie.idcategorie = " . $categorie . " OR";
        }

        $sql = 'SELECT * FROM ressource LEFT JOIN categorie ON categorie.idcategorie = ressource.idcategorie INNER JOIN exemplaire ON exemplaire.idressource = ressource.idressource WHERE '. $endOfSentence;
        $sql = substr($sql, 0, strlen($sql)-2);
        $sql = $sql . ' AND idLocalisation = ?';

        $stmt = parent::getPdo()->prepare($sql);
        $stmt->execute([$idLocation]);
        return $stmt->fetchAll(\PDO::FETCH_OBJ);
    }
}