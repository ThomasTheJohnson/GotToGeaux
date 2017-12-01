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

    public class OnSettingsChangeEventArgs : EventArgs
    {
        //ToDo?
    }

    class Settings : DialogFragment
    {
        private Button darkButton;
        private Button lightButton;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {

            base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.Settings, container, false);

            darkButton = view.FindViewById<Button>(Resource.Id.darkTheme);
            darkButton.Click += DarkButton_Click;

            lightButton = view.FindViewById<Button>(Resource.Id.lightTheme);
            lightButton.Click += LightButton_Click;

            return view;
        }

        private void LightButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DarkButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            Dialog.Window.RequestFeature(WindowFeatures.NoTitle);
            base.OnActivityCreated(savedInstanceState);

            Dialog.Window.Attributes.WindowAnimations = Resource.Style.signup_animation;
        }
    }
}