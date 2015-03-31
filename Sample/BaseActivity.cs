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
using Com.Umeng.Analytics;

namespace Sample
{
    [Activity(Label = "BaseActivity")]
    public class BaseActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            
        }

        protected override void OnResume()
        {
            base.OnResume();
            MobclickAgent.OnResume(this);
        }

        protected override void OnPause()
        {
            base.OnPause();
            MobclickAgent.OnPause(this);
        }
    }
}