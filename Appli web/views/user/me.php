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
                    <p class="text-gray-600 mb-2"><span
                                class="font-semibold">Prénom:</span> <?= $user->prenomemprunteur ?></p>
                    <p class="text-gray-600 mb-2"><span class="font-semibold">Téléphone:</span> <span class="flou" id="tel" onclick="changeClass()"> <?= $user->telportable ?></span>
                    </p>
                </div>

                <div class="p-5 text-center">
                        <?php if (\utils\SessionHelpers::isLogin()) { ?>
                            <button type="button" id="modify" class="btn bg-green-600 text-white hover:bg-green-900 py-1 px-3 m-2"><i class='fas fa-user-alt mr-1'></i>Édition</button>
                        <?php } ?>

                    <a href="/download" class="btn btn-custom">
                        <button class="btn bg-blue-600 text-white hover:bg-blue-900 py-1 px-3 m-2"><i class="fa fa-download"></i> Télécharger</button>
                    </a>
                    <a href="/logout" class="btn btn-custom">
                        <button class="btn bg-red-600 text-white hover:bg-red-900 py-1 px-3 m-2"><i class="fa fa-sign-out" aria-hidden="true"></i> Déconnexion</button>
                    </a>
                </div>

            </div>
        </div>

        <!-- Colonne de droite -->
        <div class="w-full md:w-2/3 px-4 mt-6 md:mt-0">
            <h1 class="text-3xl font-bold text-gray-900 mb-2">Mes emprunts</h1>

            <?php if (!$emprunts) { ?>
                <!-- Message si aucun emprunt -->
                <div class="bg-white shadow-lg rounded-lg px-6 py-4 mt-5">
                    <p class="text-gray-600 mb-2">Vous n'avez aucun emprunt en cours.</p>
                </div>
            <?php } else { ?>
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
                        </div>
                    <?php } ?>
                </div>
            <?php } ?>
        </div>

    </div>
</div>

<script>
    function changeClass() {
        if(document.getElementById('tel').className == "noFlou") {
            document.getElementById('tel').className = "flou";

        } else {
            document.getElementById('tel').className = "noFlou";
        }
    }

    document.querySelector("#modify").addEventListener("click", async (e) => {
        e.preventDefault();

        // Création d'un formulaire à l'intérieur du dialogue de confirmation
        const { value: formValues } = await Swal.fire({
            title: 'Édition de votre compte',
            html:
                '<form action="/edit/<?= $user->idemprunteur  ?>" method="post">' +
                '<input type="text" name="nom" id="swal-nom" class="swal2-input" placeholder="Nom" value="<?php echo $user->nomemprunteur;  ?>"" required>' +
                '<input type="text" name="prenom" id="swal-prenom" class="swal2-input" placeholder="Prénom" value="<?php echo $user->prenomemprunteur; ?>" required>' +
                '<input type="email" name="email" id="swal-email" class="swal2-input" placeholder="Adresse e-mail" value="<?php echo $user->emailemprunteur; ?>" required>' +
                '<input type="date" name="dateNaissance" id="swal-dateNaissance" class="swal2-input" placeholder="Date de naissance" value="<?php echo $user->datenaissance; ?>" required>' +
                '<input type="text" name="telephone" id="swal-telephone" class="swal2-input" placeholder="Téléphone" value="<?php echo $user->telportable; ?>" required>' +
                '<input type="password" name="password" id="swal-password" class="swal2-input" placeholder="Mot de passe" value="" required>' +
                '<input type="password" name="passwordCheck" id="swal-confirmPassword" class="swal2-input" placeholder="Confirmation mot de passe" value="" required>' +
                '<button type = "submit" class="btn bg-blue-600 text-white hover:bg-blue-900 py-1 px-3 m-4">Modifier</button>' +
                '</form>',
            focusConfirm: false,
            showConfirmButton: false,
            showCancelButton: false,
        });
    });

</script>
