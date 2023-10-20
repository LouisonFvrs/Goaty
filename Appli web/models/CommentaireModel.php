<?php
namespace models;

use models\base\SQL;

class CommentaireModel extends SQL
{
    public function __construct()
    {
        parent::__construct('commentaire', 'idCom');
    }

    public function getComByRessources($id): bool|array
    {
        try {

            $sql = 'SELECT * FROM commentaire INNER JOIN emprunter on emprunter.idCom = commentaire.idCom INNER JOIN emprunteur on emprunteur.idemprunteur = emprunter.idemprunteur WHERE emprunter.idRessource = ? ORDER BY commentaire.dateCom DESC';
            $stmt = parent::getPdo()->prepare($sql);
            $stmt->execute([$id]);
            return $stmt->fetchAll(\PDO::FETCH_OBJ);

        } catch (\PDOException $e) {
            return false;
        }
    }

    // Créer un commentaire
        public function createCommentaire($com, $note, $idEmprunteur, $idRessource) {

            $sql = 'INSERT INTO commentaire (textCom, noteCom, dateCom) VALUES (?,?, NOW());';
            $stmt = parent::getPdo()->prepare($sql);
            $stmt->execute([$com, $note]);

            $idCom = $this->getPdo()->lastInsertId();;

            $this->affecterCommentaire($idCom ,$idEmprunteur, $idRessource);
        }

    public function affecterCommentaire(int $idCom, int $idEmprunteur, int $idRessource){
        $query = 'UPDATE emprunter SET idCom = ? WHERE idemprunteur = ? AND idressource = ?;';
        $stmt = SQL::getPdo()->prepare($query);
        $stmt->execute([$idCom ,$idEmprunteur, $idRessource]);
    }
}