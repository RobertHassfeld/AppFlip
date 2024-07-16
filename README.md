# AppFlip

This app is supposed to show that the app flip function does not work on MAUI for Android.

Perform the following steps for testing:

1. Starts the https://github.com/googlesamples/identity-appflip-tester-android tool
2. Add the following parameter to the string.xml file
   * Package Name: com.companyname.appflip
   * Intent Filter Action Name: com.app.appflip
   * Client ID: 123
   * Fingerprint of Signing Certificate: Your own device signature
3. Start the AppFlip application
4. Open the Android Tester Tool
5. Click on "Try to flip"
6. The flip will open the AppFlip application and crash
7. Open the Android Tester Tool again
8. Click again on "Try to flip"
9. This time the AppFlip application should open in the Android Tester Tool

## Exception that occurs

```
[ERROR] FATAL UNHANDLED EXCEPTION: System.InvalidOperationException: This window is already associated with an active Activity (AppFlip.MainActivity). Please override CreateWindow on AppFlip.App to add support for multiple activities https://aka.ms/maui-docs-create-windowor set the LaunchMode to SingleTop on AppFlip.AppFlipActivity.
at Microsoft.Maui.Platform.ApplicationExtensions.CreatePlatformWindow(Activity activity, IApplication application, Bundle savedInstanceState) in D:\a\_work\1\s\src\Core\src\Platform\Android\ApplicationExtensions.cs:line 52
at Microsoft.Maui.MauiAppCompatActivity.OnCreate(Bundle savedInstanceState) in D:\a\_work\1\s\src\Core\src\Platform\Android\MauiAppCompatActivity.cs:line 35
at AppFlip.AppFlipActivity.OnCreate(Bundle savedInstanceState) in /Users/rhassfeld/Projekte/TestApps/AppFlip/AppFlip/Platforms/Android/AppFlipActivity.cs:line 35
at Android.App.Activity.n_OnCreate_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_savedInstanceState) in /Users/runner/work/1/s/xamarin-android/src/Mono.Android/obj/Release/net8.0/android-34/mcw/Android.App.Activity.cs:line 3082
at Android.Runtime.JNINativeWrapper.Wrap_JniMarshal_PPL_V(_JniMarshal_PPL_V callback, IntPtr jnienv, IntPtr klazz, IntPtr p0) in /Users/runner/work/1/s/xamarin-android/src/Mono.Android/Android.Runtime/JNINativeWrapper.g.cs:line 125
```