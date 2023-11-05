<section class="min-h-[calc(100vh-136px)]">

    <!-- Bannière principale -->
    <section class="bg-gradient-to-r from-blue-500 to-indigo-600">
        <div class="container mx-auto px-4 py-16">
            <div class="max-w-xl mx-auto text-center">
                <h1 class="text-5xl font-bold text-white mb-6">Bienvenue à la médiathèque</h1>
                <p class="text-xl text-white mb-6">Découvrez notre vaste collection de livres, films et musique.</p>

                <div class="container">
                    <form action="/" method="post">
                        <div class="search">
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="search-1">
                                        <i></i>
                                        <input type="text" name="ressource" placeholder="Livre, Film, Album...">
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div>
                                        <div class="search-2">
                                            <svg xmlns="http://www.w3.org/2000/svg" height="1em" viewBox="0 0 384 512">
                                                <style>svg {
                                                        fill: #ff0000
                                                    }</style>
                                                <path d="M215.7 499.2C267 435 384 279.4 384 192C384 86 298 0 192 0S0 86 0 192c0 87.4 117 243 168.3 307.2c12.3 15.3 35.1 15.3 47.4 0zM192 128a64 64 0 1 1 0 128 64 64 0 1 1 0-128z"/>
                                            </svg>
                                            <input type="text" name="city" placeholder="Ville">
                                            <button>Search</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </form>
                </div>

                <div class="mt-8">
                    <a href="/catalogue/all"
                       class="bg-white text-indigo-600 hover:bg-indigo-600 hover:text-white font-bold py-3 px-6 rounded-full">
                        Parcourir les ressources
                    </a>
                </div>
            </div>
        </div>
    </section>

    <!-- Contenu principal -->
    <main class="container mx-auto px-4 py-8" id="app">

        <h2 class="text-3xl font-bold text-gray-800 mb-4">
            Nouveautés
        </h2>

        <div class="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-7 gap-8 container mx-auto">

            <!-- On boucle sur les ressources -->
            <!-- Le :href=… permet de définir le lien vers lequel on sera redirigé au clic -->
            <!-- Le : signifie que l'élément sera géré par VueJS -->
            <a v-for="r in ressources" :href="`/catalogue/detail/${r.idressource}`"
               class="bg-white rounded-lg shadow-lg">

                <!-- On affiche l'image de la ressource (:src=…).  -->
                <!--  le : signifie que l'élément sera géré par VueJS -->
                <img loading="lazy"
                     :src="`/public/assets/${r.image}`"
                     class="w-full h-64 object-cover object-center rounded-t-lg">

                <!-- On affiche le titre et la catégorie de la ressource -->
                <!-- via la syntaxe {{ … }} qui permet d'insérer le contenu d'une variable dans du HTML -->
                <!-- C'est une possibilité offerte par VueJS -->
                <div class="p-6">
                    <h3 class="d-flex d-inline text-xl font-semibold text-gray-800 mb-2 truncate" :title="r.titre">{{
                        r.titre }}</h3>
                    <div class="w-fit flex justify-center items-center font-medium py-1 px-2 bg-white rounded-full text-blue-700 bg-blue-100 border border-blue-300 ">
                        <div class="text-xs font-normal leading-none max-w-full flex-initial">
                            {{ r.libellecategorie }}
                        </div>
                    </div>
                    <div class="w-fit flex justify-center items-center font-medium py-1 px-2 bg-white rounded-full text-blue-700 bg-blue-100 border border-blue-300 ">
                        <div class="text-xs font-normal leading-none max-w-full flex-initial">
                            {{ r.anneesortie }}
                        </div>
                    </div>
                </div>
            </a>

            <div class="hidden lg:block self-center cursor-pointer w-fit" v-if="ressources.length > 0">
                <!-- On ajoute un événement au clic sur le SVG. -->
                <svg @click="getRessources()" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24"
                     stroke-width="1.5" stroke="currentColor" class="w-16 h-16">
                    <path stroke-linecap="round" stroke-linejoin="round"
                          d="M4.5 12h15m0 0l-6.75-6.75M19.5 12l-6.75 6.75"/>
                </svg>
            </div>
        </div>

        <?php if (!empty($catalogue)) { ?>
            <h2 class="text-3xl font-bold text-gray-800 mb-4 mt-4">
                Résultat de la recherche
            </h2>

            <div class="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-5 gap-8 container mx-auto mt-5">

                <?php foreach ($catalogue as $ressource) { ?>

                    <a href="/catalogue/detail/<?= $ressource->idressource ?>" class="bg-white rounded-lg shadow-lg">
                        <img loading="lazy" src="/public/assets/<?= $ressource->image ?>"
                             alt="<?= htmlspecialchars($ressource->titre) ?>"
                             class="w-full h-64 object-cover object-center rounded-t-lg">
                        <div class="p-6">
                            <h3 class="text-xl font-semibold text-gray-800 mb-2 truncate"><?= $ressource->titre ?></h3>
                            <div class="w-fit flex justify-center items-center font-medium py-1 px-2 bg-white rounded-full text-blue-700 bg-blue-100 border border-blue-300 ">
                                <div class="text-xs font-normal leading-none max-w-full flex-initial">
                                    <?= $ressource->villeLocalisation ?>
                                </div>
                            </div>
                        </div>
                    </a>

                <?php } ?>
            </div>
        <?php } ?>
    </main>
</section>

<script>
    const {createApp, ref} = Vue

    /*
     * Pour rendre dynamique le contenu de la page, on va utiliser Vue.js.
     * Vue.js est un framework JavaScript qui permet de créer des applications web.
     * Il permet de créer des composants réutilisables.
     *
     * Nous pourrions utiliser jQuery pour rendre dynamique le contenu de la page, mais c'est ancien. Et, il faut
     * l'avouer, VueJS est tellement mieux.
     *
     * Pour vous aider à comprendre le fonctionnement, voici un exemple d'appel Ajax et de composant réactif
     * avec VueJS.
     *
     * Documentation : https://fr.vuejs.org/guide/introduction.html
     */

    // Création de l'application Vue, createApp est une fonction qui prend en paramètre un objet.
    createApp({
        setup() {
            // La méthode setup() est appelée avant le rendu du composant.
            // C'est-à-dire avant que la page ne soit interprété.
            // On peut donc y définir des variables qui seront utilisées dans le template.

            // On déclare une variable ressources qui sera utilisée dans le template.
            // C'est une variable réactive, c'est-à-dire que si on la modifie, le template sera mis à jour.
            const ressources = ref([]);
            let lastIndexDisplayed = 0;

            // Fonction qui permet de récupérer les ressources.
            // La fonction fera un appel Ajax à l'API pour récupérer les ressources.
            // Une fois les ressources récupérées, on met à jour la variable ressources.
            function getRessources() {
                fetch('/api/catalogue/') // Appel Ajax à l'API en utilisant la fonction fetch.
                    .then(res => res.json()) // Conversion la réponse en JSON (objet JavaScript).
                    .then(data => {
                        const ressourcesTriees = data.sort((a, b) => b.anneesortie - a.anneesortie);

                        const sixNextRessources = ressourcesTriees.slice(lastIndexDisplayed, lastIndexDisplayed + 6);
                        lastIndexDisplayed += 6;

                        if (lastIndexDisplayed >= ressourcesTriees.length) {
                            lastIndexDisplayed = 0;
                        }

                        // Mise à jour de la variable ressources (variable réactive) avec les ressources triées.
                        ressources.value = sixNextRessources;
                    });
            }

            // On appelle la fonction pour récupérer les ressources.
            getRessources();

            // La fonction setInterval permet d'appeler une fonction à intervalle régulier.
            // Ici, on appelle la fonction getRessources toutes les 1 minute.
            // Cela permet de mettre à jour les ressources toutes les 1 minute.
            setInterval(() => {
                getRessources();
            }, 60000); // On appelle la fonction toutes les 1 minute.

            // On retourne les variables et fonctions qui seront utilisables dans le template.
            // ressources : variable réactive qui contient les ressources (donc des livres, films ou musiques).
            //              - C'est un tableau d'objets. Chaque objet représente une ressource.
            //              - Chaque objet contient les propriétés suivantes : idressource, titre, image, libellecategorie.
            //              - Utilisable dans le template via {{ ressources[0].titre }} par exemple, ou via une boucle v-for.
            //              - Exemple de boucle v-for : <div v-for="r in ressources">{{ r.titre }}</div>
            //              - Documentation : https://fr.vuejs.org/v2/guide/list.html
            // getRessources : fonction qui permet de récupérer les ressources (utilisée dans le template via le @click).
            return {
                ressources,
                getRessources
            }
        }
    }).mount('#app') // On monte l'application Vue sur l'élément HTML qui a l'id "app", c'est-à-dire la div dans laquelle on a écrit le template.
</script>