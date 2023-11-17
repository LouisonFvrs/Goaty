<?php

namespace models;

use models\base\SQL;

class ExemplaireModel extends SQL
{
    public function __construct()
    {
        parent::__construct('exemplaire', 'idexemplaire');
    }

    public function getByRessource(int $id): bool|array
    {
        try {
            $sql = 'SELECT * FROM exemplaire WHERE idressource = ?';
            $stmt = parent::getPdo()->prepare($sql);
            $stmt->execute([$id]);
            return $stmt->fetchAll(\PDO::FETCH_OBJ);
        } catch (\PDOException $e) {
            return false;
        }
    }

    // Vérifier si un exemplaire est en libre service dans la ville
    public function isPresent($id, $idexemplaire) : bool
    {
        try {
            // Vérification que l'exemplaire n'as jamais été emprunter
            $sql = 'SELECT * FROM emprunter WHERE emprunter.idexemplaire = ?;';
            $stmt = parent::getPdo()->prepare($sql);
            $stmt->execute([$idexemplaire]);

            if ($stmt->rowCount() == 0) {
                // La ressource n'as jamais été emprunter
                return true;
            } else {
                // Si elle retourne quelques choses alors la ressource est rendu
                $sql = 'SELECT * FROM emprunter INNER JOIN exemplaire ON emprunter.idexemplaire = exemplaire.idexemplaire WHERE emprunter.idexemplaire = ? and emprunter.idEtatEmprunt = 3 AND exemplaire.idLocalisation = ?;';
                $stmt = parent::getPdo()->prepare($sql);
                $stmt->execute([$idexemplaire, $id]);

                if ($stmt->rowCount() > 0) {
                    return true;
                } else {
                    return false;
                }
            }

        } catch (\PDOException $e) {
            return false;
        }
    }

    // Récupérer un exemplaire à l'aide d'une ressource et d'une ville
    public function getExemplaire($townOfUser, $ressource) {
        try {
            $sql = 'SELECT * FROM exemplaire WHERE idressource = ? and idLocalisation = ?';
            $stmt = parent::getPdo()->prepare($sql);
            $stmt->execute([$ressource->idressource, $townOfUser]);
            return $stmt->fetch(\PDO::FETCH_OBJ);
        } catch (\PDOException $e) {
            return false;
        }
    }
}