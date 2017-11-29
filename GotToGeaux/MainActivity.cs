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
            Thread.Sleep(3000);
            var folder = Android.OS.Environment.DataDirectory + Java.IO.File.Separator + "Users";
            var extFileName = folder + Java.IO.File.Separator + e.Email.ToString() + ".txt";

            string input = e.FirstName + "/\n" + e.Email + "/\n" + e.Password + "/\n";
            byte[] toBytes = System.Text.Encoding.ASCII.GetBytes(input);

            try
            {
                if (!System.IO.Directory.Exists(folder))
                    System.IO.Directory.CreateDirectory(folder);
                using (var fs = new System.IO.FileStream(extFileName, System.IO.FileMode.OpenOrCreate))
                {
                    fs.Write(toBytes, 0, 1000);

                }
            }
            catch
            {
                RunOnUiThread(() =>
                {
                    var builder = new AlertDialog.Builder(this);
                    builder.SetMessage("Not gonna lie, some shit went wrong.");
                    builder.SetTitle("Unable to sign up user.");
                    builder.Show();
                });
                return;
            }
            //Thread signUpService = new Thread(SignUpUser);
            //signUpService.Start();
        }

        private void SignUpUser()
        {
            Thread.Sleep(2000);
        }
    }
}

