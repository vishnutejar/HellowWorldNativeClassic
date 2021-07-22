using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Widget;
using HellowWorldNativeClassic.frgs;
using FragmentManager = Android.Support.V4.App.FragmentManager;

namespace HellowWorldNativeClassic
{
    [Activity(Label = "HomeActivity")]
    public class HomeActivity : Activity
    {
        TextView userName;
        BottomNavigationView bottom_navigation;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_home);
            string datafromScreen1 = Intent.GetStringExtra("data");
            // userName = FindViewById<TextView>(Resource.Id.username);
            bottom_navigation = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation);
            //userName.Text = datafromScreen1;
            bottom_navigation.NavigationItemSelected += Bottom_navigation_NavigationItemSelected;
        }

        private void Bottom_navigation_NavigationItemSelected(object sender, BottomNavigationView.NavigationItemSelectedEventArgs e)
        {
            LoadFragment(e.Item.ItemId);
        }

        void LoadFragment(int id)
        {
            Fragment fragment = null;
            switch (id)
            {
                case Resource.Id.menu_home:
                    fragment = new Fragment1();
                    break;
                case Resource.Id.menu_home1:
                    fragment = new Fragment2();
                    break;
                case Resource.Id.menu_home2:
                    fragment = new Fragment1();
                    break;
            }

            if (fragment == null)
                return;


            FragmentManager.BeginTransaction()
                .Replace(Resource.Id.content_frame, fragment)
                .Commit();
        }
    }
}