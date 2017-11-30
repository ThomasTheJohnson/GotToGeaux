using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System.Threading;

namespace GotToGeaux
{
    [Activity(Label = "Feed", MainLauncher = false)]
    public class FeedActivity : Activity
    {
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Feed);


            button1 = FindViewById<Button>(Resource.Id.entry1);
            button1.Text = "Hello Fuckhead";
            button2 = FindViewById<Button>(Resource.Id.entry2);
            button2.Text = "Hello Fuckhead";
            button3 = FindViewById<Button>(Resource.Id.entry3);
            button3.Text = "Hello Fuckhead";
            button4 = FindViewById<Button>(Resource.Id.entry4);
            button4.Text = "Hello Fuckhead";
            button5 = FindViewById<Button>(Resource.Id.entry5);
            button5.Text = "Hello Fuckhead";
            button6 = FindViewById<Button>(Resource.Id.entry6);
            button6.Text = "Hello Fuckhead";
            button7 = FindViewById<Button>(Resource.Id.entry7);
            button7.Text = "Hello Fuckhead";
            button8 = FindViewById<Button>(Resource.Id.entry8);
            button8.Text = "Hello Fuckhead";
            button9 = FindViewById<Button>(Resource.Id.entry9);
            button9.Text = "Hello Fuckhead";
            button10 = FindViewById<Button>(Resource.Id.entry10);
            button10.Text = "Hello Fuckhead";
            button11 = FindViewById<Button>(Resource.Id.entry11);
            button11.Text = "Hello Fuckhead";
            button12 = FindViewById<Button>(Resource.Id.entry12);
            button12.Text = "Hello Fuckhead";
            button13 = FindViewById<Button>(Resource.Id.entry13);
            button13.Text = "Hello Fuckhead";
            button14 = FindViewById<Button>(Resource.Id.entry14);
            button14.Text = "Hello Fuckhead";
            button15 = FindViewById<Button>(Resource.Id.entry15);
            button15.Text = "Hello Fuckhead";

            var builder = new AlertDialog.Builder(this);
            builder.SetMessage("Welcome " + Intent.GetStringExtra("Username"));
            builder.SetTitle("User authenticated");
            builder.Show();
            // Set our view from the "main" layout resource

            
            //button1 = FindViewById<Button>(Resource.Id.entry1);
            //button1 = FindViewById<Button>(Resource.Id.entry1);
        }
    }
}