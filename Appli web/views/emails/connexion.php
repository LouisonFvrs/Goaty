<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Notification de Connexion</title>
    <style>
        body {
            font-family: 'Arial', sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }

        .container {
            max-width: 600px;
            margin: 20px auto;
            background-color: #ffffff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 20px rgba(0, 0, 0, 0.1);
            overflow: hidden;
        }

        h1 {
            color: #3498db;
            margin-bottom: 20px;
        }

        p {
            color: #555555;
            line-height: 1.6;
            margin-bottom: 15px;
        }

        .button {
            display: inline-block;
            padding: 12px 24px;
            background-color: #3498db;
            color: #ffffff;
            text-decoration: none;
            border-radius: 5px;
            transition: background-color 0.3s;
        }

        .button:hover {
            background-color: #2980b9;
        }

        .footer {
            margin-top: 20px;
            color: #999999;
            font-size: 12px;
        }

        .footer a {
            color: #3498db;
            text-decoration: none;
        }

        .footer a:hover {
            text-decoration: underline;
        }
    </style>
</head>
<body>
<div class="container">
    <h1>Notification de Connexion</h1>
    <p>Bonjour <?php echo $prenom.' '.$name; ?>,</p>
    <p>Nous voulions vous informer que votre compte a été récemment consulté.</p>
    <p>Si cette connexion n'était pas autorisée, veuillez prendre des mesures immédiates en modifiant votre mot de passe.</p>
    <p>Si c'était vous, ignorez simplement cet e-mail.</p>
    <p>Merci de faire partie de notre communauté.</p>
    <div class="footer">
        <p>Cet e-mail a été envoyé automatiquement. Veuillez ne pas répondre à cet e-mail.</p>
    </div>
</div>
</body>
</html>