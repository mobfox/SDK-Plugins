##########################
### invokes test cases ###
##########################


#all test cases in workspace
#xcodebuild test -workspace MobFoxSDK.xcworkspace -scheme MobFoxSDKCoreTests -destination 'platform=iOS Simulator,name=iPhone 6,OS=8.1'


xcodebuild test -scheme MobFoxSDKCoreTests -destination 'platform=iOS Simulator,name=iPhone 6,OS=8.1'

###########################
### builds core targets ###
###########################


#MobFoxSDKCoreUniversal target
#xcodebuild -workspace MobFoxSDK.xcworkspace -scheme MobFoxSDKCoreUniversal -destination 'platform=iOS,name=Itamar'

#MobFoxSDKCoreDynamicUniversal target
#xcodebuild -workspace MobFoxSDK.xcworkspace -scheme MobFoxSDKCoreDynamicUniversal -destination 'platform=iOS,name=Itamar'

#MobFoxSDKCoreBitCodeUniversal target
#xcodebuild -workspace MobFoxSDK.xcworkspace -scheme MobFoxSDKCoreBitCodeUniversal -destination 'platform=iOS,name=Itamar'

#MobFoxSDKCoreDynamicBitCodeUniversal target
#xcodebuild -workspace MobFoxSDK.xcworkspace -scheme MobFoxSDKCoreDynamicBitCodeUniversal -destination 'platform=iOS,name=Itamar'
