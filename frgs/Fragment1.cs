using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace HellowWorldNativeClassic.frgs
{
    public class Fragment1 : Fragment
    {
        RecyclerView recyclerView1;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            View v= inflater.Inflate(Resource.Layout.layout_frg1, container, false);
            recyclerView1 = v.FindViewById<RecyclerView>(Resource.Id.recyclerView1);
            var layoutManager = new LinearLayoutManager(this.Activity,LinearLayoutManager.Vertical,false);
            recyclerView1.SetLayoutManager(layoutManager);

            var photoAdapter = new PhotoAdapter(DataSet.mBuiltInPhotos);
            photoAdapter.ItemClick += PhotoAdapter_ItemClick;

            recyclerView1.SetAdapter(photoAdapter);
            return v;
        }

        private void PhotoAdapter_ItemClick(object sender, int e)
        {
            var selectedVale = DataSet.mBuiltInPhotos[e];
            Toast.MakeText(this.Activity, selectedVale.Caption,ToastLength.Long).Show();
        }
    }
}