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
    public class OnSignUpEventArgs : EventArgs
    {
        private string mFirstName;
        private string mEmail;
        private string mPassword;

        public string FirstName
        {
            get { return mFirstName; }
            set { mFirstName = value; }
        }

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

        public OnSignUpEventArgs( string firstName, string email, string password) : base()
        {
            FirstName = firstName;
            Email = email;
            Password = password;
        }

    }
    class SignUpDialog : DialogFragment
    {
        //global variables of the activities
        private EditText InputFirstName;
        private EditText InputEmail;
        private EditText InputPassword;
        private Button SignUpDialogButton;

        public event EventHandler<OnSignUpEventArgs> mOnSignUpComplete;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.SignUpDialog, container, false);

            //These variables allow us to grab events and data from the buttons themselves.
            InputFirstName = view.FindViewById<EditText>(Resource.Id.signUpFirstNameText);
            InputEmail = view.FindViewById<EditText>(Resource.Id.signUpEmailText);
            InputPassword = view.FindViewById<EditText>(Resource.Id.signUpPasswordText);
            SignUpDialogButton = view.FindViewById<Button>(Resource.Id.signUpDialogButton);

            SignUpDialogButton.Click += SignUpDialogButton_Click;
            return view;
        }

        private void SignUpDialogButton_Click(object sender, EventArgs e)
        {
            //This is the handler for the user clicking the sign up button
            if(InputFirstName.Text.ToString().CompareTo("") == 0 || InputEmail.Text.ToString().CompareTo("") == 0 || InputPassword.Text.ToString().CompareTo("") == 0)
            {

            }
            else
            {
                mOnSignUpComplete.Invoke(this, new OnSignUpEventArgs(InputFirstName.Text, InputEmail.Text, InputPassword.Text));
                this.Dismiss();
            }

        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            //Gets rid of the title bar
            Dialog.Window.RequestFeature(WindowFeatures.NoTitle);
            base.OnActivityCreated(savedInstanceState);
            //sets the animation of the window
            Dialog.Window.Attributes.WindowAnimations = Resource.Style.signup_animation;
        }

    }
}