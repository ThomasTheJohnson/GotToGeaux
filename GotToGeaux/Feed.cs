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
        //Top level buttons
        private Button profileButton;
        private Button settingsButton;
        private Button makeEntry;

        //Feed buttons
        private Button button1;
        private ReviewDialog review1 = new ReviewDialog();

        private Button button2;
        private ReviewDialog review2 = new ReviewDialog();

        private Button button3;
        private ReviewDialog review3 = new ReviewDialog();

        private Button button4;
        private ReviewDialog review4 = new ReviewDialog();

        private Button button5;
        private ReviewDialog review5 = new ReviewDialog();

        private Button button6;
        private ReviewDialog review6 = new ReviewDialog();

        private Button button7;
        private ReviewDialog review7 = new ReviewDialog();

        private Button button8;
        private ReviewDialog review8 = new ReviewDialog();

        private Button button9;
        private ReviewDialog review9 = new ReviewDialog();

        private Button button10;
        private ReviewDialog review10 = new ReviewDialog();

        private Button button11;
        private ReviewDialog review11 = new ReviewDialog();

        private Button button12;
        private ReviewDialog review12 = new ReviewDialog();

        private Button button13;
        private ReviewDialog review13 = new ReviewDialog();

        private Button button14;
        private ReviewDialog review14 = new ReviewDialog();

        private Button button15;
        private ReviewDialog review15 = new ReviewDialog();


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
            button1.Click += Button_Click;

            button2 = FindViewById<Button>(Resource.Id.entry2);
            button2.Click += Button_Click;

            button3 = FindViewById<Button>(Resource.Id.entry3);
            button3.Click += Button_Click;
            
            button4 = FindViewById<Button>(Resource.Id.entry4);
            button4.Click += Button_Click;

            button5 = FindViewById<Button>(Resource.Id.entry5);
            button5.Click += Button_Click;

            button6 = FindViewById<Button>(Resource.Id.entry6);
            button6.Click += Button_Click;

            button7 = FindViewById<Button>(Resource.Id.entry7);
            button7.Click += Button_Click;

            button8 = FindViewById<Button>(Resource.Id.entry8);
            button8.Click += Button_Click;

            button9 = FindViewById<Button>(Resource.Id.entry9);
            button9.Click += Button_Click;

            button10 = FindViewById<Button>(Resource.Id.entry10);
            button10.Click += Button_Click;

            button11 = FindViewById<Button>(Resource.Id.entry11);
            button11.Click += Button_Click;

            button12 = FindViewById<Button>(Resource.Id.entry12);
            button12.Click += Button_Click;

            button13 = FindViewById<Button>(Resource.Id.entry13);
            button13.Click += Button_Click;

            button14 = FindViewById<Button>(Resource.Id.entry14);
            button14.Click += Button_Click;

            button15 = FindViewById<Button>(Resource.Id.entry15);
            button15.Click += Button_Click;


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
            button15.Text = button14.Text;
            review15 = review14;
            button14.Text = button13.Text;
            review14 = review13;
            button13.Text = button12.Text;
            review13 = review12;
            button12.Text = button11.Text;
            review12 = review11;
            button10.Text = button9.Text;
            review11 = review10;
            button9.Text = button8.Text;
            review10 = review9;
            button8.Text = button7.Text;
            review8 = review7;
            button7.Text = button6.Text;
            review7 = review6;
            button6.Text = button5.Text;
            review6 = review5;
            button5.Text = button4.Text;
            review5 = review4;
            button4.Text = button3.Text;
            review4 = review3;
            button3.Text = button2.Text;
            review3 = review2;
            button2.Text = button1.Text;
            review2 = review1;
            button1.Text = Intent.GetStringArrayExtra("UserInfo")[0] + " - " + e.WhereInput;
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button buttonThatSent = sender as Button;
            if(buttonThatSent.Id == button1.Id)
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                review1.Show(transaction, "dialog fragment");
            }
            else if(buttonThatSent.Id == button2.Id)
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                review2.Show(transaction, "dialog fragment");
            }
            else if (buttonThatSent.Id == button3.Id)
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                review3.Show(transaction, "dialog fragment");
            }
            else if (buttonThatSent.Id == button4.Id)
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                review4.Show(transaction, "dialog fragment");
            }
            else if (buttonThatSent.Id == button5.Id)
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                review5.Show(transaction, "dialog fragment");
            }
            else if (buttonThatSent.Id == button6.Id)
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                review6.Show(transaction, "dialog fragment");

            }
            else if (buttonThatSent.Id == button7.Id)
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                review7.Show(transaction, "dialog fragment");
            }

            else if (buttonThatSent.Id == button8.Id)
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                review8.Show(transaction, "dialog fragment");
            }
            else if (buttonThatSent.Id == button9.Id)
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                review9.Show(transaction, "dialog fragment");
            }
            else if (buttonThatSent.Id == button10.Id)
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                review10.Show(transaction, "dialog fragment");
            }
            else if (buttonThatSent.Id == button11.Id)
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                review11.Show(transaction, "dialog fragment");
            }
            else if (buttonThatSent.Id == button12.Id)
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                review12.Show(transaction, "dialog fragment");
            }
            else if (buttonThatSent.Id == button13.Id)
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                review13.Show(transaction, "dialog fragment");
            }
            else if (buttonThatSent.Id == button14.Id)
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                review14.Show(transaction, "dialog fragment");
            }
            else 
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                review15.Show(transaction, "dialog fragment");
            }
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