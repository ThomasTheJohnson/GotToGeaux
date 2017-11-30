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
    public class OnSignInEventArgs : EventArgs
    {
        private string mEmail;
        private string mPassword;

        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }
        }
        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }

        public OnSignInEventArgs(string email, string password) : base()
        {
            Email = email;
            Password = password;
        }
    }

    class SignInDialog : DialogFragment
    {

        //global variables of the activities
        private EditText InputEmail;
        private EditText InputPassword;
        private Button SignInDialogButton;

        public event EventHandler<OnSignInEventArgs> mOnSignInComplete;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.SignInDialog, container, false);

            //These variables allow us to grab events and data from the activities.

            InputEmail = view.FindViewById<EditText>(Resource.Id.signInEmailText);
            InputPassword = view.FindViewById<EditText>(Resource.Id.signInPasswordText);
            SignInDialogButton = view.FindViewById<Button>(Resource.Id.signInDialogButton);

            SignInDialogButton.Click += SignInDialogButton_Click;
            return view;
        }

        private void SignInDialogButton_Click(object sender, EventArgs e)
        {
            if (InputEmail.Text.ToString().CompareTo("") == 0 || InputPassword.Text.ToString().CompareTo("") == 0)
            {
                //Error Handling
            }
            else
            {
                mOnSignInComplete.Invoke(this, new OnSignInEventArgs(InputEmail.Text, InputPassword.Text));
                this.Dismiss();
            }
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            Dialog.Window.RequestFeature(WindowFeatures.NoTitle);
            base.OnActivityCreated(savedInstanceState);
            //sets the animation
            Dialog.Window.Attributes.WindowAnimations = Resource.Style.signup_animation;
        }
    }
}