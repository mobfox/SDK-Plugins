./gradlew clean
./gradlew :app:exportJar
rm ~/projects/SDK-Plugins/Unity/MobFox-Unity-Demo/Assets/Plugins/Android/libs/mobfox-android-unity-plugin.jar
cp app/build/outputs/mobfox-android-unity-plugin.jar ~/projects/SDK-Plugins/Unity/MobFox-Unity-Demo/Assets/Plugins/Android/libs/mobfox-android-unity-plugin.jar
