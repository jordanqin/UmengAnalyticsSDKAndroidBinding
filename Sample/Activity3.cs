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
using Android.Telephony;
using Android.Net.Wifi;
using Android.Text;
using Org.Json;

namespace Sample
{
    [Activity(Label = "Activity3")]
    public class Activity3 : BaseActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main3);

            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate
            {
                System.Diagnostics.Debug.WriteLine(Utility.GetDeviceInfo(this));
                button.Text = Utility.GetDeviceInfo(this);
            };

            FindViewById<Button>(Resource.Id.butError).Click += delegate
            {
                throw new Exception("π “‚±®¥Ì"); 
            };
        }
    }
}