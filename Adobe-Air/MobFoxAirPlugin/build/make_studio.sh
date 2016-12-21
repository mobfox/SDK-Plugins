#!/bin/bash
echo "Hello from a bash script file."



mkdir /Users/TAKEphONE/Adobe-Air/MobFoxAirPlugin/temp

cd /Users/TAKEphONE/Adobe-Air/MobFoxAirPlugin/temp

cp ../AndroidMobFoxPluginLib/MobFox-Android-Air-Adapter.jar MobFox-Android-Air-Adapter.jar
cp ../AndroidMobFoxPluginLib/MobFox-Android-SDK-Core-3.0.6ShSh.jar MobFox-Android-SDK-Core-3.0.6ShSh.jar

jar -xf MobFox-Android-SDK-Core-3.0.6ShSh.jar

jar -uf MobFox-Android-Air-Adapter.jar com
jar -uf MobFox-Android-Air-Adapter.jar values

cp MobFox-Android-Air-Adapter.jar ../build/android/androidmobfoxpluginlib.jar

rm ad.js
rm button_close_55x55.png
rm button_mute_75x75.png
rm button_play_100x100.png
rm button_unmute_75x75.png
rm mobfox.html
rm WebViewJavascriptBridge.js
rm MobFox-Android-Air-Adapter.jar
rm MobFox-Android-SDK-Core-3.0.6ShSh.jar
#!rm *.tmp
rm -rf com
rm -rf values






cd /Users/TAKEphONE/Adobe-Air/MobFoxAirPlugin/build

/Users/TAKEphONE/Downloads/AIRSDK_Compiler/bin/adt -package -target ane MobFoxPlugin.ane extension.xml -swc MobFoxPluginLib.swc -platform iPhone-ARM -C ios . -platformoptions platformoptions_ios.xml -platform Android-ARM -C android . -platformoptions platformoptions_android.xml -platform default -C default .

#!/Applications/Adobe\ Flash\ Builder\ 4.7/eclipse/plugins/com.adobe.flash.compiler_4.7.0.349722/AIRSDK/bin/adt -package -target ane MobFoxPlugin.ane extension.xml -swc MobFoxPluginLib.swc -platform iPhone-ARM -C ios . -platformoptions platformoptions_ios.xml -platform Android-ARM -C android . -platformoptions platformoptions_android.xml -platform default -C default .

#!/Applications/Adobe\ Flash\ Builder\ 4.7/sdks/4.6.0/bin/adt -package -target ane MobFoxPlugin.ane extension.xml -swc MobFoxPluginLib.swc -platform iPhone-ARM -C ios . -platformoptions platformoptions_ios.xml -platform Android-ARM -C android . -platformoptions platformoptions_android.xml -platform default -C default .

#!/Applications/Adobe\ Flash\ Builder\ 4.7/sdks/3.6.0/bin/adt -package -target ane MobFoxPlugin.ane extension.xml -swc MobFoxPluginLib.swc -platform iPhone-ARM -C ios . -platformoptions platformoptions_ios.xml -platform Android-ARM -C android . -platformoptions platformoptions_android.xml -platform default -C default .

