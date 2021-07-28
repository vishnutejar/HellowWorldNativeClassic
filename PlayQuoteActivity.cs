using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HellowWorldNativeClassic
{
    [Activity(Label = "PlayQuoteActivity")]
    public class PlayQuoteActivity : FragmentActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var playId = Intent.Extras.GetInt("current_play_id", 0);

            var detailsFrag = PlayQuoteFragment.NewInstance(playId);
            SupportFragmentManager.BeginTransaction()
                            .Replace(Android.Resource.Id.Content, detailsFrag)
                            .Commit();
        }
    }
}