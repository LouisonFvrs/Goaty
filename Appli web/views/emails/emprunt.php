<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Emprunt de Ressource Confirmé</title>
    <!-- Ajoutez les liens vers les fichiers CSS Bootstrap -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
</head>
<body>
<div class="container">
    <div class="row">
        <div class="col-md-8 offset-md-2 mt-5">
            <div class="alert alert-success" role="alert">
                <h4 class="alert-heading">Confirmation d'Emprunt de Ressource</h4>
                <p>Votre demande d'emprunt de la ressource "<strong><?php echo $title; ?></strong>" a été traitée avec succès. La ressource est maintenant à votre disposition.</p>
                <hr>
                <p class="mb-0">Si vous avez d'autres besoins ou des questions supplémentaires, n'hésitez pas à nous contacter.</p>
            </div>
        </div>
    </div>
</div>

<!-- Ajoutez les liens vers les fichiers JavaScript Bootstrap (jQuery et Popper.js) -->
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>
</html>