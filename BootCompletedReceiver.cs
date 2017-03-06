using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Util;

namespace XamarinBootCompletedTest
{
    [BroadcastReceiver(Enabled = true, Exported = true)]
    [IntentFilter(
        new[] { Android.Content.Intent.ActionBootCompleted, "android.intent.action.QUICKBOOT_POWERON" }
        )]
    public class BootCompletedReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            Log.Debug("BootCompletedReceiver", "OnReceive");
            var pref = context.GetSharedPreferences(MainActivity.Key, Android.Content.FileCreationMode.Private);
            pref.Edit().PutString(DateTime.Now.ToString(), MainActivity.Key).Commit();
        }
    }
}