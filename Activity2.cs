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
    [Activity(Label = "Activity2")]
    public class Activity2 : Activity
    {
        TextView txt_wish;
        Button bt_gotoact1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_layout2);
            txt_wish = FindViewById<TextView>(Resource.Id.txt_wish);
            bt_gotoact1 = FindViewById<Button>(Resource.Id.bt_gotoact1);
        var wishfromact1=    Intent.GetStringExtra("data");
            txt_wish.Text = wishfromact1;

            bt_gotoact1.Click += Bt_gotoact1_Click;
        }

        private void Bt_gotoact1_Click(object sender, EventArgs e)
        {
            Intent gotoingtoact1 = new Intent(this,typeof(Activity1));
            gotoingtoact1.PutExtra("datafromact1","Thanks,HAI");
            StartActivity(gotoingtoact1);
        }
    }
}