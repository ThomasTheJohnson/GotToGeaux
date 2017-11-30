using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System.Threading;

namespace GotToGeaux
{
    [Activity(Label = "GotToGeaux", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Button SignUpButton;
        private Button SignInButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //Login Screen Sign Up Button
            SignUpButton = FindViewById<Button>(Resource.Id.signUpButton);
            SignUpButton.Click += SignUpButton_Click;

            //Login Screen Sign In Button
            SignInButton = FindViewById<Button>(Resource.Id.signInButton);
            SignInButton.Click += SignInButton_Click;
        }

        //SIGN IN BUTTON STUFF
        private void SignInButton_Click(object sender, System.EventArgs e)
        {
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            SignInDialog signInDialog = new SignInDialog();
            signInDialog.Show(transaction, "dialog frragment");

            signInDialog.mOnSignInComplete += SignInDialog_mOnSignInComplete;
        }

        private void SignInDialog_mOnSignInComplete(object sender, OnSignInEventArgs e)
        {
            Thread.Sleep(3000);
            var folder = FilesDir + Java.IO.File.Separator + "Users";
            var extFileName = folder + Java.IO.File.Separator + e.Email.ToString() + ".txt";
            string[] lines = new string[3];

            try
            {
                if (!System.IO.Directory.Exists(folder))
                    throw new System.Exception();
                lines = System.IO.File.ReadAllLines(extFileName);
            }
            catch
            {
                RunOnUiThread(() =>
                {
                    var builder = new AlertDialog.Builder(this);
                    builder.SetMessage("User does not exist!");
                    builder.SetTitle("Unable to authenticate user.");
                    builder.Show();
                });
                return;
            }

            if (e.Password.CompareTo(lines[2]) == 0)
            {
                var feed = new Intent(this, typeof(FeedActivity));
                feed.PutExtra("Username", lines[0]);
                StartActivity(feed);
            }
            else
            {
                RunOnUiThread(() =>
                {
                    var builder = new AlertDialog.Builder(this);
                    builder.SetMessage("User email or password are incorrect.");
                    builder.SetTitle("User failed to authenticate");
                    builder.Show();
                });
                return;
            }
        }

        //SIGN UP BUTTON STUFF
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
            var folder = FilesDir + Java.IO.File.Separator + "Users";
            var extFileName = folder + Java.IO.File.Separator + e.Email.ToString() + ".txt";

            string input = e.FirstName + "\n" + e.Email + "\n" + e.Password + "\n";
            byte[] toBytes = System.Text.Encoding.ASCII.GetBytes(input);

            try
            {
                if (!System.IO.Directory.Exists(folder))
                    System.IO.Directory.CreateDirectory(folder);
                using (var fs = new System.IO.FileStream(extFileName, System.IO.FileMode.OpenOrCreate))
                {
                    fs.Write(toBytes, 0, toBytes.Length);
                    fs.Close();
                }
            }
            catch
            {
                RunOnUiThread(() =>
                {
                    var builder = new AlertDialog.Builder(this);
                    builder.SetMessage("Not gonna lie, some stuff went wrong.");
                    builder.SetTitle("Unable to sign up user.");
                    builder.Show();
                });
                return;
            }
        }
    }
}

