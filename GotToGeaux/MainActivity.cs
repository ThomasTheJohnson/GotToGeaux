using Android.App;
using Android.Widget;
using Android.OS;
using System.Threading;

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

            signUpDialog.mOnSignUpComplete += SignUpDialog_mOnSignUpComplete;
        }

        private void SignUpDialog_mOnSignUpComplete(object sender, OnSignUpEventArgs e)
        {
            Thread.Sleep(5000);
            Thread signUpService = new Thread(SignUpUser);
            signUpService.Start();
        }

        private void SignUpUser()
        {
            Thread.Sleep(2000);
        }
    }
}

