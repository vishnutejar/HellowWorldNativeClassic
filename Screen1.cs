using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HellowWorldNativeClassic
{
    [Activity(Label = "Screen1", MainLauncher = true)]
    public class Screen1 : Activity
    {
        EditText userName, Passwrd;
        Button loginButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_screen1);
            userName = FindViewById<EditText>(Resource.Id.edt_userName);
            Passwrd = FindViewById<EditText>(Resource.Id.edt_password);
            loginButton = FindViewById<Button>(Resource.Id.bt_login);
            //addeding a event to button 
            loginButton.Click += LoginButton_Click;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username, paswword;
            username = userName.Text;
            paswword = Passwrd.Text;

            if (string.IsNullOrEmpty(username))
            {
                Toast.MakeText(this, "Enter your Username", ToastLength.Long).Show();

            }
            else if (string.IsNullOrEmpty(paswword))
            {
                Toast.MakeText(this, "Enter Your Password", ToastLength.Long).Show();

            }
            else {
                Toast.MakeText(this, "congraulations...", ToastLength.Long).Show();

                Intent GotoHome = new Intent(this,typeof(HomeActivity));
                GotoHome.PutExtra("data",username);
                StartActivity(GotoHome);
            }
        }
    }
}