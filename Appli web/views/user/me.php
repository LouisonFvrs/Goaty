<div class="container mx-auto py-8 min-h-[calc(100vh-136px)]">
    <div class="flex flex-wrap">
        <!-- Colonne de gauche -->
        <div class="w-full md:w-1/3 px-4">
            <div class="max-w-md mx-auto bg-white shadow-lg rounded-lg px-6 py-4">
                <div class="flex items-center justify-center mb-4">
                    <img src="<?= \utils\Gravatar::get_gravatar($user->emailemprunteur) ?>" alt="Photo de profil"
                         class="rounded-full h-32 w-32">
                </div>
                <h1 class="text-3xl font-bold text-gray-900 mb-4">👋 <?= $user->prenomemprunteur ?></h1>
                <div class="mb-4">
                    <h2 class="text-xl font-semibold text-gray-800 mb-2">Informations personnelles</h2>
                    <p class="text-gray-600 mb-2"><span
                                class="font-semibold">Email:</span> <?= $user->emailemprunteur ?></p>
                    <p class="text-gray-600 mb-2"><span class="font-semibold">Nom:</span> <?= $user->nomemprunteur ?>
                    </p>
                    <p class="text-gray-600 mb-2">
                        <span class="font-semibold">Prénom:</span> <?= $user->prenomemprunteur ?>
                    </p>
                    <p class="text-gray-600 mb-2">
                        <span class="font-semibold">Ville:</span> <?= $ville->villeLocalisation ?>
                    </p>
                    <p class="text-gray-600 mb-2">
                        <span class="font-semibold">Téléphone:</span>
                        <span class="flou" id="tel" onclick="changeClass()"> <?= $user->telportable ?></span>
                    </p>
                </div>

                <div class="p-5 text-center">
                    <?php if (\utils\SessionHelpers::isLogin()) { ?>
                        <button type="button" id="modify"
                                class="btn bg-green-600 text-white hover:bg-green-900 py-1 px-3 m-2"><i
                                    class='fas fa-user-alt mr-1'></i>Édition
                        </button>
                    <?php } ?>

                    <a href="/download" class="btn btn-custom">
                        <button class="btn bg-blue-600 text-white hover:bg-blue-900 py-1 px-3 m-2"><i
                                    class="fa fa-download"></i> Télécharger
                        </button>
                    </a>
                    <a href="/logout" class="btn btn-custom">
                        <button class="btn bg-red-600 text-white hover:bg-red-900 py-1 px-3 m-2"><i
                                    class="fa fa-sign-out" aria-hidden="true"></i> Déconnexion
                        </button>
                    </a>
                    <a id="delete" class="btn btn-custom">
                        <button class="btn bg-gray-600 text-white hover:bg-gray-900 py-1 px-3 m-2">
                            <i class="fa-regular fa-trash-can" style="color: #ffffff;"></i> Supprimer
                        </button>
                    </a>
                </div>

            </div>
        </div>

        <!-- Colonne de droite -->
        <div class="w-full md:w-2/3 px-4 mt-6 md:mt-0">
            <?php if(isset($error)) { ?>
                <div class="alert alert-warning" role="alert">
                    <?=$error?>
                </div>
            <?php } ?>
            <?php if (!$empruntsDelay && !$emprunts) { ?>
                <!-- Message si aucun emprunt -->
                <div class="bg-white shadow-lg rounded-lg px-6 py-4 mt-5">
                    <p class="text-gray-600 mb-2">Vous n'avez aucun emprunt en cours.</p>
                </div>
            <?php } else {?>

            <h1 class="text-3xl font-bold text-gray-900 mb-2">🚨 Mes retards 🚨</h1>
            <?php if ( !$empruntsDelay ) { ?>
            <div class="bg-white shadow-lg rounded-lg px-6 py-4 mt-5">
                <p class="text-gray-600 mb-2">Vous n'avez aucun emprunt en retard.</p>
            </div>
            <?php } ?>
        <!-- Tableau des emprunts -->
            <div class="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 gap-4 mt-5">

                <!-- Liste des emprunts -->
                <?php foreach ($empruntsDelay as $emprunt) { ?>
                    <div class="bg-white shadow-lg rounded-lg px-6 py-4">
                        <h2 class="text-xl font-semibold text-gray-800 mb-2"><?= $emprunt->titre ?></h2>
                        <p class="text-gray-600 mb-2">Type: <span
                                    class="font-semibold"><?= $emprunt->libellecategorie ?></span></p>
                        <p class="text-gray-600 mb-2">
                            Date d'emprunt:
                            <span class="font-semibold"><?= date_format(date_create($emprunt->datedebutemprunt), "d/m/Y") ?></span>
                        </p>
                        <p class="text-gray-600 mb-2">
                            Date de retour prévue:
                            <span class="font-semibold"><?= date_format(date_create($emprunt->dateretour), "d/m/Y") ?></span>
                        </p>
                        <p class="text-gray-600 mb-2">
                            ⚠️ Frais:
                            <span class="font-semibold"><?= date_diff(date_create($emprunt->dateretour), new DateTime())->days ?>€</span>
                        </p>
                        <?php if ($emprunt->id == 1) { ?>
                            <button class="rendre-ressource-button" data-emprunt='<?= json_encode($emprunt) ?>'>
                                <div class="w-fit flex justify-center items-center font-medium py-1 px-2 bg-white rounded-full text-blue-700 bg-blue-100 border border-blue-300 ">
                                    <div class="text-xs font-normal leading-none max-w-full flex-initial">
                                        <?= $emprunt->libEtat ?>
                                    </div>
                                </div>
                            </button>
                        <?php } else if ($emprunt->id == 2) { ?>
                            <div class="w-fit flex justify-center items-center font-medium py-1 px-2 bg-white rounded-full text-green-700 bg-blue-100 border border-green-300 ">
                                <div class="text-xs font-normal leading-none max-w-full flex-initial">
                                    <?= $emprunt->libEtat ?>
                                </div>
                            </div>
                        <?php } ?>
                    </div>
                <?php } ?>
            </div>

            <h1 class="text-3xl font-bold text-gray-900 mb-2 mt-4">Mes emprunts</h1>

            <?php if (!$emprunts) { ?>
                <div class="bg-white shadow-lg rounded-lg px-6 py-4 mt-5">
                    <p class="text-gray-600 mb-2">Vous n'avez aucun emprunt en retard.</p>
                </div>
            <?php } ?>

            <!-- liste emprunts -->
            <?php if ($emprunts) { ?>
                <!-- Tableau des emprunts -->
                <div class="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 gap-4 mt-5">

                    <!-- Liste des emprunts -->
                    <?php foreach ($emprunts as $emprunt) { ?>
                        <div class="bg-white shadow-lg rounded-lg px-6 py-4">
                            <h2 class="text-xl font-semibold text-gray-800 mb-2"><?= $emprunt->titre ?></h2>
                            <p class="text-gray-600 mb-2">Type: <span
                                        class="font-semibold"><?= $emprunt->libellecategorie ?></span></p>
                            <p class="text-gray-600 mb-2">
                                Date d'emprunt:
                                <span class="font-semibold"><?= date_format(date_create($emprunt->datedebutemprunt), "d/m/Y") ?></span>
                            </p>
                            <p class="text-gray-600 mb-2">
                                Date de retour prévue:
                                <span class="font-semibold"><?= date_format(date_create($emprunt->dateretour), "d/m/Y") ?></span>
                            </p>
                            <?php if ($emprunt->id == 1) { ?>
                                <button class="rendre-ressource-button" data-emprunt='<?= json_encode($emprunt) ?>'>
                                    <div class="w-fit flex justify-center items-center font-medium py-1 px-2 bg-white rounded-full text-blue-700 bg-blue-100 border border-blue-300 ">
                                        <div class="text-xs font-normal leading-none max-w-full flex-initial">
                                            <?= $emprunt->libEtat ?>
                                        </div>
                                    </div>
                                </button>
                            <?php } else if ($emprunt->id == 2) { ?>
                                <div class="w-fit flex justify-center items-center font-medium py-1 px-2 bg-white rounded-full text-green-700 bg-blue-100 border border-green-300 ">
                                    <div class="text-xs font-normal leading-none max-w-full flex-initial">
                                        <?= $emprunt->libEtat ?>
                                    </div>
                                </div>
                            <?php } ?>
                        </div>
                    <?php } ?>
                </div>
            <?php } }?>
        </div>

    </div>
</div>

<script>
    function changeClass() {
        if (document.getElementById('tel').className == "noFlou") {
            document.getElementById('tel').className = "flou";

        } else {
            document.getElementById('tel').className = "noFlou";
        }
    }

    function toTimestamp(strDate){
        var datum = Date.parse(strDate);
        console.log(datum);
        return datum/1000;
    }

    function rendreRessource(emprunt) {
        Swal.fire({
            title: 'Restituer ' + emprunt.titre + ' ?',
            html: '<img loading="lazy" src="/public/assets/' + emprunt.image + '" alt="' + emprunt.titre + '" class="swal2-image" style="max-width: 100%; max-height: 50vh;">',
            showCancelButton: false,
            confirmButtonText: 'Rendre',
            preConfirm: () => {
                const form = new FormData();
                form.append('idEmprunteur', emprunt.idemprunteur);
                form.append('idRessource', emprunt.idressource);
                form.append('idExemplaire', emprunt.idexemplaire);
                form.append('idDateDebutEmprunt', emprunt.datedebutemprunt);

                const dateTimestamp = toTimestamp(emprunt.datedebutemprunt);

                return fetch('/api/rendre-ressource/' + emprunt.idemprunteur + '/' + emprunt.idressource + '/' + emprunt.idexemplaire + '/' + emprunt.datedebutemprunt, {
                    method: 'POST',
                    body: form
                })
                    .then(response => response.json())
                    .then((result) => {
                        if (result && result.isConfirmed) {
                            Swal.fire(
                                'Rendu!',
                                emprunt.titre + ' est en attente de validation',
                                'success'
                            );
                        } else {
                            Swal.fire(
                                'Erreur!',
                                emprunt.titre + ' a pas été rendu',
                                'error'
                            );
                        }
                    });
            }
        })
    }

    document.addEventListener('DOMContentLoaded', function () {
        const rendreRessourceButtons = document.querySelectorAll('.rendre-ressource-button');

        rendreRessourceButtons.forEach(function (button) {
            button.addEventListener('click', function () {
                const empruntData = JSON.parse(button.getAttribute('data-emprunt'));
                rendreRessource(empruntData);
            });
        });
    });

    document.querySelector("#modify").addEventListener("click", async (e) => {
        e.preventDefault();

        // Création d'un formulaire à l'intérieur du dialogue de confirmation
        const { value: formValues } = await Swal.fire({
            title: 'Édition de votre compte',
            html:
                '<form action="/edit/<?= $user->idemprunteur  ?>" method="post" class="w-full text-center" id="editForm">' +
                '<input type="text" name="nom" id="swal-nom" class="swal2-input" placeholder="Nom" value="<?php echo $user->nomemprunteur; ?>" required>' +
                '<input type="text" name="prenom" id="swal-prenom" class="swal2-input" placeholder="Prénom" value="<?php echo $user->prenomemprunteur; ?>" required>' +
                '<input type="email" name="email" id="swal-email" class="swal2-input" placeholder="Adresse e-mail" value="<?php echo $user->emailemprunteur; ?>" required>' +
                '<select class="form-select w-64 mx-auto mt-3" name="ville" aria-label="ville"> <option value="<?= $ville->idLocalisation ?>"><?= $ville->villeLocalisation ?></option> <?php foreach ($localisation as $l) { if($l->idLocalisation != $ville->idLocalisation) { ?> <option value="<?= $l->idLocalisation?>"><?= $l->villeLocalisation?></option> <?php }} ?> </select>' +
                '<input type="date" name="dateNaissance" id="swal-dateNaissance" class="swal2-input" placeholder="Date de naissance" value="<?php echo $user->datenaissance; ?>" required>' +
                '<input type="text" name="telephone" id="swal-telephone" class="swal2-input" placeholder="Téléphone" value="<?php echo $user->telportable; ?>" required>' +
                '<input type="password" name="password" id="swal-password" class="swal2-input" placeholder="Mot de passe" value="" required>' +
                '<input type="password" name="passwordCheck" id="swal-confirmPassword" class="swal2-input" placeholder="Confirmation mot de passe" value="" required>' +
                '<button type="button" class="btn bg-blue-600 text-white hover:bg-blue-900 py-1 px-3 m-4" onclick="validateForm()">Modifier</button>' +
                '</form>',
            focusConfirm: false,
            showConfirmButton: false,
            showCancelButton: false,
        });
    });

    document.getElementById('delete').addEventListener('click', function(e) {
        e.preventDefault();

        // Afficher la boîte de dialogue
        Swal.fire({
            title: 'Êtes-vous sûr de vouloir supprimer votre compte ?',
            icon: 'question',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Oui',
            cancelButtonText: 'Non'
        }).then((result) => {
            if (result.value) {
                window.location.href = '/deleteAccount';
            }
        });
    });

    function validateForm() {
        const nom = document.getElementById('swal-nom').value;
        const prenom = document.getElementById('swal-prenom').value;
        const email = document.getElementById('swal-email').value;
        const telephone = document.getElementById('swal-telephone').value;
        const password = document.getElementById('swal-password').value;
        const confirmPassword = document.getElementById('swal-confirmPassword').value;

        // Validation simple (vous pouvez ajouter des validations plus complexes selon vos besoins)
        if (!nom || !prenom || !email || !telephone || !password || !confirmPassword) {
            Swal.fire('Erreur', 'Veuillez remplir tous les champs', 'error');
        } else if (!isValidEmail(email)) {
            Swal.fire('Erreur', 'Adresse e-mail invalide', 'error');
        } else if (!isValidPhoneNumber(telephone)) {
            Swal.fire('Erreur', 'Numéro de téléphone invalide', 'error');
        } else if (password !== confirmPassword) {
            Swal.fire('Erreur', 'Les mots de passe ne correspondent pas', 'error');
        } else {
            // Si la validation réussit, vous pouvez soumettre le formulaire
            document.getElementById('editForm').submit();
        }
    }

    function isValidEmail(email) {
        const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        return emailRegex.test(email);
    }

    function isValidPhoneNumber(phoneNumber) {
        const phoneRegex = /^\d{10}$/;
        return phoneRegex.test(phoneNumber);
    }

</script>
