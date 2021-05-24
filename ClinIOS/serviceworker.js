var cacheNameVersion = "mySiteFiles-v6";
const precacheList = [
    "/",
    //"Home/Index",
    //"Home/AgGrid",
    //"Home/About",
    //"Content/Site.css",
    //"Scripts/jquery-3.5.1.min.js",
    //"Scripts/angular.min.js",
    //"Scripts/dexie.js",
    //"Scripts/ag-grid-community.js",
    //"Content/styles/ag-grid.css",
    //"Content/styles/ag-theme-alpine.css",
    
    "Account/Login",
    "Account/LogOff",
    "Account/ForgotPaswd",
    "Account/ForgotPaswdResult",
    "ChestPain/ChestPain",
    "Home/Index",
    "Tirage/TirageCalc",
    "Users/Users",
    "Users/UsersAddEdit",
    "Content/Site.css",
    "Scripts/jquery-3.5.1.js",
    "Scripts/jquery-ui.js",
    "Scripts/angular.js",
    "Scripts/angular-aria.min.js",
    "Scripts/angular-animate.min.js",
    "Scripts/angular-cookies.min.js",
    "Scripts/angular-loader.min.js",
    "Scripts/angular-material.min.js",
    "Scripts/angular-message-format.min.js",
    "Scripts/angular-messages.min.js",
    "Scripts/angular-parse-ext.min.js",
    "Scripts/angular-resource.min.js",
    "Scripts/angular-route.min.js",
    "Scripts/angular-sanitize.min.js",
    "Scripts/angular-touch.min.js",
    "Scripts/moment.js",
    "Scripts/moment-with-locales.js",
    "Scripts/angular-moment.js",
    "Scripts/js/Main.js",
    "Scripts/IndexedDB.js",
    "Scripts/CacheFiles.js"
];

self.addEventListener("install", event => {
    event.waitUntil(
        caches.open(cacheNameVersion)
            .then(cache => {
                cache.addAll(precacheList);
            })
    );
});

self.addEventListener("activate", event => {
    const cacheWhilelist = [cacheNameVersion];
    event.waitUntil(
        caches.keys()
            .then(names => {
                Promise.all(
                    names.map(cacheName => {
                        if (cacheWhilelist.indexOf(cacheName) === -1) {
                            // we don't need this cacheName old versions
                            return caches.delete(cacheName);
                        }
                    })
                )
            })
    )
});

self.addEventListener("fetch", event => {
    event.respondWith(
        caches.match(event.request)
            .then(response => {
                if (response) {
                    return response; // The URL is cached
                } else {

                    //const fetchRequest =
                    //    fetch(event.request).then(
                    //        networkResponse => {
                    //            return caches.open(cacheNameVersion)
                    //                .then(cache => {
                    //                    cache.put(event.request, networkResponse.clone());
                    //                    return networkResponse;
                    //                })
                    //        }
                    //    )
                    //return fetchRequest;

                    return fetch(event.request); // Go to the network //simple
                }
            })
    );
})