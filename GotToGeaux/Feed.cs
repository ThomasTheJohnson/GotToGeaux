using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System;
using System.Threading;
using System.IO;
using Android.Icu.Text;

namespace GotToGeaux
{

    [Activity(Label = "Feed", MainLauncher = false)]
    public class FeedActivity : Activity
    {
        private Button profileButton;
        private Button settingsButton;
        private Button makeEntry;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Feed);

            //var folder = FilesDir + Java.IO.File.Separator + "Entries";
            //var extFileName = folder + Java.IO.File.Separator + "feedcontent.txt";

            //string input = "Entry1" + "\n" + "Entry2";
            //byte[] toBytes = System.Text.Encoding.ASCII.GetBytes(input);

            //try
            //{
            //    if (!System.IO.Directory.Exists(folder))
            //        System.IO.Directory.CreateDirectory(folder);
            //    using (var fs = new System.IO.FileStream(extFileName, FileMode.OpenOrCreate))
            //    {
            //        fs.Write(toBytes, 0, toBytes.Length);
            //        fs.Close();
            //    }
            //}
            //catch
            //{
            //    RunOnUiThread(() =>
            //    {
            //        var builder1 = new AlertDialog.Builder(this);
            //        builder1.SetMessage("Not gonna lie, some stuff went wrong.");
            //        builder1.SetTitle("Unable to sign up user.");
            //        builder1.Show();
            //    });
            //    return;
            //}

            //string[] entries = new string[2];
            //try
            //{
            //    if (!System.IO.Directory.Exists(folder))
            //        throw new System.Exception();
            //    entries = System.IO.File.ReadAllLines(extFileName);
            //}
            //catch
            //{
            //    RunOnUiThread(() =>
            //    {
            //        var builder2 = new AlertDialog.Builder(this);
            //        builder2.SetMessage("User does not exist!");
            //        builder2.SetTitle("Unable to authenticate user.");
            //        builder2.Show();
            //    });
            //    return;
            //}


                    button1 = FindViewById<Button>(Resource.Id.entry1);
                    button1.Click += Button1_Click;
                    //String text1 = entries[0];
                    //button1.Text = text1;
                    button2 = FindViewById<Button>(Resource.Id.entry2);
                    //String text2 = entries[1];
                    //button1.Text = text2;
                    button3 = FindViewById<Button>(Resource.Id.entry3);
                    //String text3 = entries[2];
                    //button1.Text = text3;
                    button4 = FindViewById<Button>(Resource.Id.entry4);
                    //String text4 = sr.ReadLine();
                    //button1.Text = text4;
                    button5 = FindViewById<Button>(Resource.Id.entry5);
                    //String text5 = sr.ReadLine();
                    //button1.Text = text5;
                    button6 = FindViewById<Button>(Resource.Id.entry6);
                    //String text6 = sr.ReadLine();
                    //button1.Text = text6;
                    button7 = FindViewById<Button>(Resource.Id.entry7);
                    //String text7 = sr.ReadLine();
                    //button1.Text = text7;
                    button8 = FindViewById<Button>(Resource.Id.entry8);
                    //String text8 = sr.ReadLine();
                    //button1.Text = text8;
                    button9 = FindViewById<Button>(Resource.Id.entry9);
                    //String text9 = sr.ReadLine();
                    //button1.Text = text9;
                    button10 = FindViewById<Button>(Resource.Id.entry10);
                    //String text10 = sr.ReadLine();
                    //button1.Text = text10;
                    button11 = FindViewById<Button>(Resource.Id.entry11);
                    //String text11 = sr.ReadLine();
                    //button1.Text = text11;
                    button12 = FindViewById<Button>(Resource.Id.entry12);
                    //String text12 = sr.ReadLine();
                    //button1.Text = text12;
                    button13 = FindViewById<Button>(Resource.Id.entry13);
                    //String text13 = sr.ReadLine();
                    //button1.Text = text13;
                    button14 = FindViewById<Button>(Resource.Id.entry14);
                    //String text14 = sr.ReadLine();
                    //button1.Text = text14;
                    button15 = FindViewById<Button>(Resource.Id.entry15);
                    //String text15 = sr.ReadLine();
                    //button1.Text = text15;
                    button1.Text = "Ed Orgeron - Tiger Stadium";
                    button2.Text = "Thomas Johnson - Tiger Band Hall";
                    button3.Text = "Timothy Ratliff - Patrick F. Taylor Hall";
                    button4.Text = "JJ Juarez - Raising Canes";
                    button5.Text = "John Snow - The Wall";
                    button6.Text = "Tim Cook - San Francisco, California";
                    button7.Text = "Vincent Yasmine - Middleton Library";
                    button8.Text = "Alexandra Viola - Middleton Library";
                    button9.Text = "Markus Persson - California";
                    button10.Text = "Jeff Kaplan - Austin, Texas";
                    button11.Text = "Rachael Shel - Seattle, Washington";
                    button12.Text = "Michael Santana - Paris, France";
                    button13.Text = "Luke Smith - Bellevue, Washington";
                    button14.Text = "Marie Tiffiny - Angelfire, New Mexico";
                    button15.Text = "Tim Cook - San Francisco, California";

            //Profile Button
            profileButton = FindViewById<Button>(Resource.Id.profileButton);
            profileButton.Click += ProfileButton_Click;

            //Settings Button
            settingsButton = FindViewById<Button>(Resource.Id.settingsButton);
            settingsButton.Click += SettingsButton_Click;

            //Entry Button
            makeEntry = FindViewById<Button>(Resource.Id.plusButton);
            makeEntry.Click += MakeEntry_Click;

            var builder3 = new AlertDialog.Builder(this);
                    builder3.SetMessage("Welcome " + Intent.GetStringArrayExtra("UserInfo")[0]);
                    builder3.SetTitle("User authenticated");
                    builder3.Show();
                    // Set our view from the "main" layout resource


                    //button1 = FindViewById<Button>(Resource.Id.entry1);
                    //button1 = FindViewById<Button>(Resource.Id.entry1);
        }

        private void MakeEntry_Click(object sender, EventArgs e)
        {
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            MakeEntry makeEntry = new MakeEntry();
            makeEntry.Show(transaction, "dialog fragment");

            makeEntry.mOnMakeEntryComplete += MakeEntry_mOnMakeEntryComplete;
        }

        private void MakeEntry_mOnMakeEntryComplete(object sender, OnMakeEntryEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            ReviewDialog reviewDialog = new ReviewDialog();
            reviewDialog.Show(transaction, "dialog fragment");
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            Settings settings = new Settings();
            settings.Show(transaction, "dialog fragment");
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            UserProfile userProfile = new UserProfile();
            userProfile.Show(transaction, "dialog fragment");

            userProfile.mOnSaveChangesComplete += UserProfile_mOnSaveChangesComplete;
        }

        private void UserProfile_mOnSaveChangesComplete(object sender, OnSaveChangesEventArgs e)
        {
            if(e.FirstName.CompareTo("") == 0)
            {
                if(e.Email.CompareTo("") == 0)
                {
                    //Does Nothing. No Changes.
                    if(e.Password.CompareTo("") == 0)
                    {

                    }
                    //Just the Password Changes
                    else
                    {
                        Thread.Sleep(3000);
                        var folder = FilesDir + Java.IO.File.Separator + "Users";
                        var extFileName = folder + Java.IO.File.Separator + Intent.GetStringArrayExtra("UserInfo")[1] + ".txt";
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

                        lines[2] = e.Password;

                        string input = lines[0] + "\n" + lines[1] + "\n" + lines[2] + "\n";
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
                else
                {
                    //Change just the email
                    if(e.Password.CompareTo("") == 0)
                    {
                        Thread.Sleep(3000);
                        var folder = FilesDir + Java.IO.File.Separator + "Users";
                        var extFileName = folder + Java.IO.File.Separator + Intent.GetStringArrayExtra("UserInfo")[1] + ".txt";
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

                        lines[1] = e.Email;

                        string input = lines[0] + "\n" + lines[1] + "\n" + lines[2] + "\n";
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
                    //Change both the email and password
                    else
                    {
                        Thread.Sleep(3000);
                        var folder = FilesDir + Java.IO.File.Separator + "Users";
                        var extFileName = folder + Java.IO.File.Separator + Intent.GetStringArrayExtra("UserInfo")[1] + ".txt";
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

                        lines[1] = e.Email;
                        lines[2] = e.Password;

                        string input = lines[0] + "\n" + lines[1] + "\n" + lines[2] + "\n";
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
            else
            {

                if(e.Email.CompareTo("") == 0)
                {
                    //Just the Username
                    if(e.Password.CompareTo("") == 0)
                    {
                        Thread.Sleep(3000);
                        var folder = FilesDir + Java.IO.File.Separator + "Users";
                        var extFileName = folder + Java.IO.File.Separator + Intent.GetStringArrayExtra("UserInfo")[1] + ".txt";
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

                        lines[0] = e.FirstName;

                        string input = lines[0] + "\n" + lines[1] + "\n" + lines[2] + "\n";
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
                    //Just the Username and Password
                    else
                    {
                        Thread.Sleep(3000);
                        var folder = FilesDir + Java.IO.File.Separator + "Users";
                        var extFileName = folder + Java.IO.File.Separator + Intent.GetStringArrayExtra("UserInfo")[1] + ".txt";
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

                        lines[0] = e.FirstName;
                        lines[3] = e.Password;

                        string input = lines[0] + "\n" + lines[1] + "\n" + lines[2] + "\n";
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
                else
                {
                    //Username and Email
                    if (e.Password.CompareTo("") == 0)
                    {
                        Thread.Sleep(3000);
                        var folder = FilesDir + Java.IO.File.Separator + "Users";
                        var extFileName = folder + Java.IO.File.Separator + Intent.GetStringArrayExtra("UserInfo")[1] + ".txt";
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

                        lines[0] = e.FirstName;
                        lines[1] = e.Email;

                        string input = lines[0] + "\n" + lines[1] + "\n" + lines[2] + "\n";
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
                    //Everything
                    else
                    {
                        Thread.Sleep(3000);
                        var folder = FilesDir + Java.IO.File.Separator + "Users";
                        var extFileName = folder + Java.IO.File.Separator + Intent.GetStringArrayExtra("UserInfo")[1] + ".txt";
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

                        lines[0] = e.FirstName;
                        lines[1] = e.Email;
                        lines[2] = e.Password;

                        string input = lines[0] + "\n" + lines[1] + "\n" + lines[2] + "\n";
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
        }
    }
}