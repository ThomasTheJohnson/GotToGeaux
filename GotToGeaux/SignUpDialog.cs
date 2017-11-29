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
        private string FirstName;
        private string Email;
        private string Password;

        public string getFirstName;
  


    }
    class SignUpDialog : DialogFragment
    {
        //global variables of the activities
        private EditText InputFirstName;
        private EditText InputEmail;
        private EditText InputPassword;
        private Button SignUpButton;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.SignUpDialog, container, false);

            //These variables allow us to grab events and data from the buttons themselves.
            InputFirstName = view.FindViewById<EditText>(Resource.Id.signUpFirstNameText);
            InputEmail = view.FindViewById<EditText>(Resource.Id.signUpEmailText);
            InputPassword = view.FindViewById<EditText>(Resource.Id.signUpPasswordText);
            SignUpButton = view.FindViewById<Button>(Resource.Id.signUpButton);

            //SignUpButton.Click += MSignUpButton_Click;
            return view;
        }

        private void MSignUpButton_Click(object sender, EventArgs e)
        {
            //This is the handler for the user clicking the sign up button
            
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