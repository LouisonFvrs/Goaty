<div class="container mx-auto py-8 min-h-[calc(100vh-136px)]">
    <div class="flex flex-wrap mx-auto bg-white shadow-lg rounded-lg">
        <!-- Colonne de gauche -->
        <div class="w-full md:w-1/2 px-4 mt-4">
            <img src="/public/assets/<?= $ressource->image ?>"
                 alt="Image du livre"
                 class="mb-4 rounded-lg object-cover m-auto h-[70vh]">

        </div>

        <!-- Colonne de droite -->
        <div class="w-full md:w-1/2 px-4 mt-6 md:mt-20">
            <div class="bg-light.bg-gradient rounded-lg px-6 py-4">
                <h1 class="text-3xl font-bold text-gray-900 mb-4"><?= $ressource->titre ?></h1>
                <p class="text-gray-600 mb-2">Année de publication: <span
                            class="font-semibold"><?= $ressource->anneesortie ?></span></p>
                <p class="text-gray-600 mb-2">Langue : <span class="font-semibold"><?= $ressource->langue ?></span></p>
                <p class="text-gray-600 mb-2">ISBN : <span class="font-semibold"><?= $ressource->isbn ?></span></p>
                <p class="text-gray-600 mb-2">Description: <span class="font-semibold">
                        <?= $ressource->description ?>
                </p>

                <?php if (isset($error)) { ?>
                    <div class="alert alert-warning" role="alert">
                        <?= $error ?>
                    </div>
                <?php } ?>

                <!-- Bouton pour modifier un exemplaire -->
                <?php if ($exemplaire and $checkAvailable) { ?>
                    <form id="exemplaire" method="post" class="text-center pt-5 pb-3" action="/catalogue/emprunter">
                        <input type="hidden" name="idRessource" value="<?= $ressource->idressource ?>">
                        <input type="hidden" name="idExemplaire" value="<?= $exemplaire->idexemplaire ?>">
                        <?php if (\utils\SessionHelpers::isLogin() && $exemplaire->idLocalisation == \utils\SessionHelpers::getConnected()->idLocalisation) { ?>
                            <button type="submit"
                                    class="bg-indigo-600 text-white hover:bg-indigo-900 font-bold py-3 px-6 rounded-full">
                                Emprunter
                            </button>
                        <?php } ?>
                    </form>

                    <?php if (isset($ressource->numerique)) { ?>
                        <div class="text-center mt-3 mb-5">
                            <a href="<?php echo $ressource->numerique ?>" class="btn btn-success mx-auto">
                                Version numérique
                            </a>
                        </div>
                    <?php } ?>

                <?php } ?>
                <?php if (\utils\SessionHelpers::isLogin()) { ?>
                    <div class="d-flex justify-content-center flex-nowrap mb-5">
                        <div class="w-100" style="background: #F8F9FB">
                            <form action="/catalogue/detail/<?= $ressource->idressource ?>" method="post"
                                  class="d-flex justify-content-center align-items-center flex-column">
                                <textarea class="form-control w-75 m-5" name="com" id="com" cols="30" rows="10"
                                          placeholder="Rédiger un commentaire..."></textarea>
                                <select class="form-select w-75 " aria-label="Default select example" id="note"
                                        name="note">
                                    <option value="">--Choisir une note--</option>
                                    <option value="1">1 étoile</option>
                                    <option value="2">2 étoiles</option>
                                    <option value="3">3 étoiles</option>
                                    <option value="4">4 étoiles</option>
                                    <option value="5">5 étoiles</option>
                                </select>
                                <button type="submit" id="modify"
                                        class="btn bg-blue-600 text-white hover:bg-blue-900 py-1 px-3 m-4">Commenter
                                </button>
                                <?php if (isset($errorCom)) { ?>
                                    <div class="bg-red-100 border border-red-400 text-red-700 px-4 py-3 rounded relative mb-4 w-100 text-center" role="alert">
                                        <strong class="font-bold">🤬 </strong>
                                        <span class="block sm:inline"><?= $errorCom ?></span>
                                        <strong class="font-bold"> 🤬</strong>
                                    </div>
                                <?php } ?>
                            </form>

                        </div>
                    </div>
                <?php } ?>
            </div>
        </div>

        <div class="w-full  px-4 mt-6 md:mt-10 ml-10">
            <h1 class="text-3xl font-bold text-gray-900 mb-4">Commentaires</h1>

            <div class="ml-20">
                <?php
                if ($commentaires) {
                    foreach ($commentaires as $commentaire) { ?>
                        <div class="profil ml-10 ">
                            <img src="<?= \utils\Gravatar::get_gravatar($commentaire->emailemprunteur) ?>"
                                 alt="Photo de profil" class="rounded-full h-10 w-10">
                            <p class="text-gray-600 ml-4 font-italic"> <?= $commentaire->nomemprunteur ?> <?= $commentaire->prenomemprunteur ?></p>
                            <p class="ml-5"></p>
                            <?php for ($i = 0; $i < $commentaire->noteCom; $i++) { ?>
                                <svg class="yellowStar" xmlns="http://www.w3.org/2000/svg" height="1em"
                                     viewBox="0 0 576 512">
                                    <style>.yellowStar {
                                            fill: #ffea00
                                        }</style>
                                    <path d="M259.3 17.8L194 150.2 47.9 171.5c-26.2 3.8-36.7 36.1-17.7 54.6l105.7 103-25 145.5c-4.5 26.3 23.2 46 46.4 33.7L288 439.6l130.7 68.7c23.2 12.2 50.9-7.4 46.4-33.7l-25-145.5 105.7-103c19-18.5 8.5-50.8-17.7-54.6L382 150.2 316.7 17.8c-11.7-23.6-45.6-23.9-57.4 0z"/>
                                </svg>
                            <?php }
                            for ($j = 0; $j < 5 - $commentaire->noteCom; $j++) { ?>
                                <svg xmlns="http://www.w3.org/2000/svg" height="1em" viewBox="0 0 576 512">
                                    <style>svg {
                                            fill: darkgrey
                                        }</style>
                                    <path d="M259.3 17.8L194 150.2 47.9 171.5c-26.2 3.8-36.7 36.1-17.7 54.6l105.7 103-25 145.5c-4.5 26.3 23.2 46 46.4 33.7L288 439.6l130.7 68.7c23.2 12.2 50.9-7.4 46.4-33.7l-25-145.5 105.7-103c19-18.5 8.5-50.8-17.7-54.6L382 150.2 316.7 17.8c-11.7-23.6-45.6-23.9-57.4 0z"/>
                                </svg>
                            <?php } ?>
                        </div>
                        <p class="text-gray-500 mb-3 ml-20 font-italic"><?= $commentaire->dateCom ?></p>
                        <p class="text-gray-600 mb-5 ml-20 mr-40 text-justify"><span
                                    class="italy">"<?= $commentaire->textCom ?>"</span></p>
                    <?php }
                } else { ?>
                    <div class="container mt-5">
                        <div class="alert alert-info">
                            Aucun commentaire pour le moment
                        </div>
                    </div>
                <?php } ?>
            </div>
        </div>
    </div>
</div>

<script>

    document.querySelector("#exemplaire").addEventListener("submit", async (e) => {
        e.preventDefault()
        const result = await Swal.fire({
            title: 'Confirmer l\'emprunt ?',
            text: "Souhaitez-vous emprunter cette ressource ?",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Oui',
            cancelButtonText: 'Non'
        })
        if (result.isConfirmed) {
            e.target.submit()
        }
    });

</script>