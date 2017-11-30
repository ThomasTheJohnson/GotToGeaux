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

namespace GotToGeaux
{
    [Activity(Label = "Feed", MainLauncher = false)]
    public class FeedActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var builder = new AlertDialog.Builder(this);
            builder.SetMessage("Welcome " + Intent.GetStringExtra("Username"));
            builder.SetTitle("User authenticated");
            builder.Show();

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Feed);


        }
    }
}