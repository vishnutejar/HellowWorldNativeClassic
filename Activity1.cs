using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace HellowWorldNativeClassic
{
    [Activity(Label = "Activity1", MainLauncher = true)]
    public class Activity1 : Activity
    {
        Button gotoactivity2;
        TextView txt_wishfrmact2;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_layout1);
            gotoactivity2 = FindViewById<Button>(Resource.Id.bt_gotoact2);
            txt_wishfrmact2 = FindViewById<TextView>(Resource.Id.txt_wishfrmact2);
            gotoactivity2.Click += Gotoactivity2_Click;
            // Create your application here
           var wishfromact2= Intent.GetStringExtra("datafromact1");
            txt_wishfrmact2.Text = wishfromact2;
        }

        private void Gotoactivity2_Click(object sender, System.EventArgs e)
        {
            Intent gotoact2intent = new Intent(this,typeof(Activity2));
            gotoact2intent.PutExtra("data", "hellow activity 2");
            StartActivity(gotoact2intent);
        }
    }
}