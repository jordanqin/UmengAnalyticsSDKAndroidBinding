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

namespace Sample
{
    [Activity(Label = "Activity2")]
    public class Activity2 : BaseActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main2);

            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { this.StartActivity(typeof(Activity3)); };
        }
    }
}