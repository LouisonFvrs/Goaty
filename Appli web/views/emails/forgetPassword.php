<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Mot de passe oublié</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }

        .container {
            max-width: 600px;
            margin: 0 auto;
            padding: 20px;
            background-color: #fff;
        }

        h2 {
            color: #333;
        }

        p {
            color: #666;
        }

        .btn {
            display: inline-block;
            padding: 10px 20px;
            font-size: 16px;
            text-align: center;
            text-decoration: none;
            background-color: #3498db;
            color: #fff;
            border-radius: 5px;
        }
    </style>
</head>
<body>
<div class="container">
    <h2>Mot de passe oublié</h2>
    <p>Vous avez demandé une réinitialisation de mot de passe. Cliquez sur le lien ci-dessous pour réinitialiser votre mot de passe :</p>
    <p><a class="btn" href="<?= $url ?>">Réinitialiser le mot de passe</a></p>
    <p>Si vous n'avez pas demandé de réinitialisation de mot de passe, veuillez ignorer cet e-mail.</p>
</div>
</body>
</html>
