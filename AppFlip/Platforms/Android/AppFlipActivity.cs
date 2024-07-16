using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace AppFlip;

/// <summary>
/// To test, you can use the Google App Flip Tester tool.
/// https://github.com/googlesamples/identity-appflip-tester-android
/// </summary>
[Activity(ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
    Label = "AppFlip",
    LaunchMode = LaunchMode.SingleTop,
    ScreenOrientation = ScreenOrientation.Portrait,
    Theme = "@style/MainTheme",
    Exported = true)]

[IntentFilter(["com.app.appflip"],
    AutoVerify = true,
    Categories = [Intent.CategoryDefault])]
public class AppFlipActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        // OnCreate is called before CreateWindow is triggered.
        // This leads to a throw after app flip:
        /* System.InvalidOperationException: This window is already associated with an active Activity (AppFlip.MainActivity). Please override CreateWindow on AppFlip.App to add support for multiple activities https://aka.ms/maui-docs-create-windowor set the LaunchMode to SingleTop on AppFlip.AppFlipActivity.
           at Microsoft.Maui.Platform.ApplicationExtensions.CreatePlatformWindow(Activity activity, IApplication application, Bundle savedInstanceState) in D:\a\_work\1\s\src\Core\src\Platform\Android\ApplicationExtensions.cs:line 52
           at Microsoft.Maui.MauiAppCompatActivity.OnCreate(Bundle savedInstanceState) in D:\a\_work\1\s\src\Core\src\Platform\Android\MauiAppCompatActivity.cs:line 35
           at AppFlip.AppFlipActivity.OnCreate(Bundle savedInstanceState) in /Users/rhassfeld/Projekte/TestApps/AppFlip/AppFlip/Platforms/Android/AppFlipActivity.cs:line 26
           at Android.App.Activity.n_OnCreate_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_savedInstanceState) in /Users/runner/work/1/s/xamarin-android/src/Mono.Android/obj/Release/net8.0/android-34/mcw/Android.App.Activity.cs:line 3082
           at Android.Runtime.JNINativeWrapper.Wrap_JniMarshal_PPL_V(_JniMarshal_PPL_V callback, IntPtr jnienv, IntPtr klazz, IntPtr p0) in /Users/runner/work/1/s/xamarin-android/src/Mono.Android/Android.Runtime/JNINativeWrapper.g.cs:line 125
         */
        base.OnCreate(savedInstanceState);
        
        // added core logic to handle app flip
    }

    protected override void OnActivityResult(int requestCode, Result resultCode, Intent? data)
    {
        SetResult(resultCode, data);
        Finish();
    }
}