<div class="flex flex-col items-center justify-center px-6 py-8 mx-auto md:h-[calc(100vh-136px)] lg:py-0">
    <div class="bg-white shadow-lg rounded-lg px-6 py-4">
        <div class="p-6 space-y-4 md:space-y-6 sm:p-8">

            <?php if (isset($error)) { ?>
                <div class="bg-red-100 border border-red-400 text-red-700 px-4 py-3 rounded relative mb-4" role="alert">
                    <strong class="font-bold">Oups ! </strong>
                    <span class="block sm:inline"><?= $error ?></span>
                </div>
            <?php } ?>

            <h1 class="text-xl font-bold leading-tight tracking-tight text-gray-900 md:text-2xl">
                Mot de passe oublié ?
            </h1>
            <form class="space-y-4 md:space-y-6" action="/forget-password-send" method="post">
                <div>
                    <label for="email" class="block text-gray-800 font-semibold mb-2">Email</label>
                    <input type="email" name="email" id="email" placeholder="Entrer votre email"
                           class="bg-gray-50 border border-gray-300 text-gray-900 sm:text-sm rounded-lg focus:ring-primary-600 focus:border-primary-600 block w-full p-2.5"
                           required>
                </div>

                <div class="text-center">
                    <button type="submit"
                            class="bg-indigo-600 text-white hover:bg-indigo-900 font-bold py-3 px-6 rounded-full">
                        Envoyez
                    </button>
                </div>
            </form>
        </div>
    </div>
</div>
