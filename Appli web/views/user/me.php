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
                    <a href="/edit" class="btn btn-custom">
                    </a>

                    <!-- Bouton pour emprunter un exemplaire -->
                    <form id="modify" method="post" class="text-center pt-5 pb-3">
                        <?php if (\utils\SessionHelpers::isLogin()) { ?>
                            <button type="submit" class="btn bg-green-600 text-white hover:bg-green-900 py-1 px-3 m-2"><i class="bi bi-pen"></i>Édition</button>
                        <?php } ?>
                    </form>

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

    document.querySelector("#modify").addEventListener("submit", async (e) => {
        e.preventDefault();

        // Création d'un formulaire à l'intérieur du dialogue de confirmation
        const { value: formValues } = await Swal.fire({
            title: 'Édition de votre compte',
            html:
                '<form id="loginForm" action="/edit" method="post">' +
                '<input type="text" id="nom" class="swal2-input" placeholder="Nom" value="<?php echo $user->nomemprunteur;  ?>"" required>' +
                '<input type="text" id="prenom" class="swal2-input" placeholder="Prénom" value="<?php echo $user->prenomemprunteur; ?>" required>' +
                '<input type="email" id="email" class="swal2-input" placeholder="Adresse e-mail" value="<?php echo $user->emailemprunteur; ?>" required>' +
                '<input type="date" id="dateNaissance" class="swal2-input" placeholder="Date de naissance" value="<?php echo $user->datenaissance; ?>" required>' +
                '<input type="text" id="telephone" class="swal2-input" placeholder="Téléphone" value="<?php echo $user->telportable; ?>" required>' +
                '<input type="password" id="password" class="swal2-input" placeholder="Mot de passe" value="" required>' +
                '<input type="password" id="confirmPassword" class="swal2-input" placeholder="Mot de passe" value="" required>' +
                '</form>',
            focusConfirm: false,
            showCancelButton: true,
            confirmButtonText: 'Éditer',
            preConfirm: () => {
                return {
                    email: document.getElementById('email').value,
                    password: document.getElementById('password').value,
                    nom : document.getElementById('nom').value,
                    prenom : document.getElementById('prenom').value,
                    dateNaissance : document.getElementById('dateNaissance').value,
                    telephone : document.getElementById('telephone').value,
                    password : document.getElementById('password').value,
                    confirmPassword : document.getElementById('confirmPassword').value
                };
            }
        });

        if (formValues) {
            const nom = formValues.nom;
            const prenom = formValues.prenom;
            const email = formValues.email;
            const telephone = formValues.telephone;
            const password = formValues.password;
            const confirmPassword = formValues.confirmPassword;
            const dateNaissance = formValues.dateNaissance;
            e.target.submit();
        }
    });

</script>
