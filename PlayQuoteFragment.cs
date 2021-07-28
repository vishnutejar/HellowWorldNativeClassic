using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using System;

namespace HellowWorldNativeClassic
{
    public class PlayQuoteFragment : Fragment
    {
        public int PlayId => Arguments.GetInt("current_play_id", 0);

        public static PlayQuoteFragment NewInstance(int playId)
        {
            var bundle = new Bundle();
            bundle.PutInt("current_play_id", playId);
            return new PlayQuoteFragment { Arguments = bundle };
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

             base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.frg_play, container,false);

            TextView selectedtext = view.FindViewById<TextView>(Resource.Id.txt_selectedText);
            var padding = Convert.ToInt32(TypedValue.ApplyDimension(ComplexUnitType.Dip, 4, Activity.Resources.DisplayMetrics));
            selectedtext.TextSize = 24;
            selectedtext.Text = Shakespeare.Dialogue[PlayId];
            return view;
        }
    }
}