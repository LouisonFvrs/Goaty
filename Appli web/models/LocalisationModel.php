<?php
namespace models;

use models\base\SQL;

class LocalisationModel extends SQL
{
    public function __construct()
    {
        parent::__construct('localisation', 'idLocalisation');
    }

    public function getAll(): array|null
    {

        $sql = 'SELECT * FROM localisation';
        $stmt = parent::getPdo()->prepare($sql);
        $stmt->execute();


        return $stmt->fetchAll(\PDO::FETCH_OBJ);
    }

    public function getVilleOfuser($idLocalisation) {
        $sql = 'SELECT * FROM localisation WHERE idLocalisation = ?';
        $stmt = parent::getPdo()->prepare($sql);
        $stmt->execute([$idLocalisation]);


        return $stmt->fetch(\PDO::FETCH_OBJ);
    }
}