cordova.define('cordova/plugin_list', function(require, exports, module) {
module.exports = [
    {
        "id": "cordova-plugin-admobpro.AdMob",
        "file": "plugins/cordova-plugin-admobpro/www/AdMob.js",
        "pluginId": "cordova-plugin-admobpro",
        "clobbers": [
            "window.AdMob"
        ]
    },
    {
        "id": "com.mobfox.cordova.MobFoxPlugin",
        "file": "plugins/com.mobfox.cordova/www/MobFoxPlugin.js",
        "pluginId": "com.mobfox.cordova",
        "clobbers": [
            "MobFoxPlugin"
        ]
    }
];
module.exports.metadata = 
// TOP OF METADATA
{
    "cordova-plugin-whitelist": "1.2.2",
    "cordova-plugin-extension": "1.5.1",
    "cordova-plugin-admobpro": "2.28.3",
    "com.mobfox.cordova": "1.0.2"
};
// BOTTOM OF METADATA
});