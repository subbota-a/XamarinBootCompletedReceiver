using Android.App;
using Android.Widget;
using Android.OS;

namespace XamarinBootCompletedTest
{
    [Activity(Label = "XamarinBootCompletedTest", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        public const string Key = "Startup";
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            var pref = GetSharedPreferences(Key, Android.Content.FileCreationMode.Private);

            FindViewById<TextView>(Resource.Id.textView1).Text = pref.GetString(Key, "Nothing");
        }
    }
}

