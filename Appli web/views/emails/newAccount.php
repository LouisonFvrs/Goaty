<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Votre nouveau compte</title>
    <style>
        body {
            font-family: 'Arial', sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
            text-align: center;
        }

        .container {
            max-width: 600px;
            margin: 20px auto;
            background-color: #fff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        h1 {
            color: #333;
        }

        p {
            color: #555;
            margin-bottom: 15px;
        }

        a {
            display: inline-block;
            margin: 15px 0;
            padding: 10px 20px;
            background-color: #3498db;
            color: #fff;
            text-decoration: none;
            border-radius: 5px;
        }
    </style>
</head>
<body>
<div class="container">
    <h1>Bienvenue sur le site de la médiathèque</h1>
    <p>
        Votre compte a bien été créé.
    </p>
    <p>
        <a href="<?= $url ?>">Pour finaliser votre inscription, merci de cliquer sur le lien.</a>
    </p>
    <p>
        A bientôt sur notre site !
    </p>
</div>
</body>
</html>