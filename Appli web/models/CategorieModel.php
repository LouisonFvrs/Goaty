<?php
namespace models;

use models\base\SQL;

class CategorieModel extends SQL
{
    public function __construct()
    {
        parent::__construct('categorie', 'idcategorie');
    }

    public function getAll(): array
    {

        $sql = 'SELECT * FROM categorie';
        $stmt = parent::getPdo()->prepare($sql);
        $stmt->execute();


        return $stmt->fetchAll(\PDO::FETCH_OBJ);
    }

}