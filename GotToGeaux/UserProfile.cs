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
    public class OnSaveChangesEventArgs : EventArgs
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

        public OnSaveChangesEventArgs(string firstName, string email, string password) : base()
        {
            FirstName = firstName;
            Email = email;
            Password = password;
        }

    }

    class UserProfile : DialogFragment
    {
        //global variables of the activities
        private EditText InputFirstName;
        private EditText InputEmail;
        private EditText InputPassword;
        private Button SaveChangesDialogButton;

        public event EventHandler<OnSaveChangesEventArgs> mOnSaveChangesComplete;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.UserProfile, container, false);

            InputFirstName = view.FindViewById<EditText>(Resource.Id.changeFirstNameText);
            InputEmail = view.FindViewById<EditText>(Resource.Id.changeEmailText);
            InputPassword = view.FindViewById<EditText>(Resource.Id.changePasswordText);
            SaveChangesDialogButton = view.FindViewById<Button>(Resource.Id.saveChangesDialogButton);

            SaveChangesDialogButton.Click += SaveChangesDialogButton_Click;
            return view;
        }

        private void SaveChangesDialogButton_Click(object sender, EventArgs e)
        {
                mOnSaveChangesComplete.Invoke(this, new OnSaveChangesEventArgs(InputFirstName.Text, InputEmail.Text, InputPassword.Text));
                this.Dismiss();
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            Dialog.Window.RequestFeature(WindowFeatures.NoTitle);
            base.OnActivityCreated(savedInstanceState);

            Dialog.Window.Attributes.WindowAnimations = Resource.Style.signup_animation;
        }
    }
}