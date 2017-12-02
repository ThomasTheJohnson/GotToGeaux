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
    class ReviewDialog : DialogFragment
    {
        private string where;
        private string how;
        private string again;

        private TextView WhereEntry;
        private TextView HowEntry;
        private TextView AgainEntry;

        public ReviewDialog(string where, string how, string again)
        {
            this.where = where;
            this.how = how;
            this.again = again;

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.ReviewDialog, container, false);

            WhereEntry = view.FindViewById<TextView>(Resource.Id.whereTextEntry);
            HowEntry = view.FindViewById<TextView>(Resource.Id.howTextEntry);
            AgainEntry = view.FindViewById<TextView>(Resource.Id.againTextEntry);

            WhereEntry.Text = where;
            HowEntry.Text = how;
            AgainEntry.Text = again;

            return view;
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