using Android.App;
using Android.Widget;
using Android.OS;

namespace GotToGeaux
{
    [Activity(Label = "GotToGeaux", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Button SignUpButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            SignUpButton = FindViewById<Button>(Resource.Id.signUpButton);
            SignUpButton.Click += SignUpButton_Click;
        }

        private void SignUpButton_Click(object sender, System.EventArgs e)
        {
            //Pulls up the sign up screen
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            SignUpDialog signUpDialog = new SignUpDialog();
            signUpDialog.Show(transaction, "dialog fragment");
        }
    }
}

