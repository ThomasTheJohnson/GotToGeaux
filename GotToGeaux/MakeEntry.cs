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
    public class OnMakeEntryEventArgs : EventArgs
    {
        private string mWhereInput;
        private string mHowInput;
        private string mAgainInput;

        public string WhereInput
        {
            get { return mWhereInput; }
            set { mWhereInput = value; }
        }

        public string HowInput
        {
            get { return mHowInput; }
            set { mHowInput = value; }
        }

        public string AgainInput
        {
            get { return mAgainInput; }
            set { mAgainInput = value; }
        }

        public OnMakeEntryEventArgs(string whereInput, string howInput, string againInput) : base()
        {
            WhereInput = whereInput;
            HowInput = howInput;
            AgainInput = againInput;
        }
    }

    class MakeEntry : DialogFragment
    {
        private EditText WhereInput;
        private EditText HowInput;
        private EditText AgainInput;
        private Button MakeEntryDialogButton;

        public event EventHandler<OnMakeEntryEventArgs> mOnMakeEntryComplete;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.MakeEntry, container, false);

            WhereInput = view.FindViewById<EditText>(Resource.Id.whereText);
            HowInput = view.FindViewById<EditText>(Resource.Id.howText);
            AgainInput = view.FindViewById<EditText>(Resource.Id.againText);
            MakeEntryDialogButton = view.FindViewById<Button>(Resource.Id.makeEntryButton);

            MakeEntryDialogButton.Click += MakeEntryDialogButton_Click;

            return view;
        }

        private void MakeEntryDialogButton_Click(object sender, EventArgs e)
        {
            if (WhereInput.Text.ToString().CompareTo("") == 0 || HowInput.Text.ToString().CompareTo("") == 0 || AgainInput.Text.ToString().CompareTo("") == 0)
            {
                //Error Handling
            }
            else
            {
                mOnMakeEntryComplete.Invoke(this, new OnMakeEntryEventArgs(WhereInput.Text, HowInput.Text, AgainInput.Text));
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