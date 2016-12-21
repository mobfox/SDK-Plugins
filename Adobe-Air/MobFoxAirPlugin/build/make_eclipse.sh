#!/bin/bash
echo "Hello from a bash script file."



mkdir /Users/TAKEphONE/Adobe-Air/MobFoxAirPlugin/temp

cd /Users/TAKEphONE/Adobe-Air/MobFoxAirPlugin/temp

cp ../AndroidMobFoxPluginLib/bin/androidmobfoxpluginlib.jar androidmobfoxpluginlib.jar
cp ../AndroidMobFoxPluginLib/libs/MobFox-Android-SDK-Core-2.1.5.jar MobFox-Android-SDK-Core-2.1.5.jar

jar -xf MobFox-Android-SDK-Core-2.1.5.jar

jar -uf androidmobfoxpluginlib.jar com
jar -uf androidmobfoxpluginlib.jar values

cp androidmobfoxpluginlib.jar ../build/android/androidmobfoxpluginlib.jar

rm ad.js
rm button_close_55x55.png
rm button_mute_75x75.png
rm button_play_100x100.png
rm button_unmute_75x75.png
rm index.html
rm WebViewJavascriptBridge.js
rm androidmobfoxpluginlib.jar
rm MobFox-Android-SDK-Core-2.1.5.jar
rm -rf com
rm -rf values






cd /Users/TAKEphONE/Adobe-Air/MobFoxAirPlugin/build

/Users/TAKEphONE/Downloads/AIRSDK_Compiler/bin/adt -package -target ane MobFoxPlugin.ane extension.xml -swc MobFoxPluginLib.swc -platform iPhone-ARM -C ios . -platformoptions platformoptions_ios.xml -platform Android-ARM -C android . -platformoptions platformoptions_android.xml -platform default -C default .

