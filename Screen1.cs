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
    [Activity(Label = "Screen1", MainLauncher = false)]
    public class Screen1 : Activity
    {
        EditText userName, passwrd;
        Button loginButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_screen1);
            userName = FindViewById<EditText>(Resource.Id.edt_userName);
            passwrd = FindViewById<EditText>(Resource.Id.edt_password);
            loginButton = FindViewById<Button>(Resource.Id.bt_login);
            loginButton.Click += LoginButton_Click;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this,"your are cliked",ToastLength.Long).Show();
        }
    }
}