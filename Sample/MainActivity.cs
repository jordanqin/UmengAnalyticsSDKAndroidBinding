using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Umeng.Analytics;

namespace Sample
{
    [Activity(Label = "Sample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : BaseActivity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            //初始化友盟
            //MobclickAgent.SetSessionContinueMillis(300 * 1000);
            MobclickAgent.UpdateOnlineConfig(this.ApplicationContext);
            MobclickAgent.SetDebugMode(true);

            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { this.StartActivity(typeof(Activity1)); };
        }
    }
}

