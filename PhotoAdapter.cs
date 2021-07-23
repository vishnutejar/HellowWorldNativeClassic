using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System;

namespace HellowWorldNativeClassic
{
    public class PhotoAdapter : RecyclerView.Adapter
    {
        // Event handler for item clicks:
        public event EventHandler<int> ItemClick;
        Photo[] mPhts;
        public PhotoAdapter(Photo[] photos)
        {
            mPhts = photos;
        }
        public override int ItemCount => mPhts.Length;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            Photo photoData = mPhts[position];
            var holderView = holder as MyViewHolder;
            holderView.photo.SetImageResource(photoData.PhotoID);
            holderView.namePht.Text = photoData.Caption;

        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View v = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.item_layout_photos, parent,false);

            return new MyViewHolder(v,OnClick);
        }
        public class MyViewHolder : RecyclerView.ViewHolder
        {
            public ImageView photo { get; set; }
            public TextView namePht { get; set; }

            public MyViewHolder(View view, Action<int> action) : base(view)
            {

                photo = view.FindViewById<ImageView>(Resource.Id.imageView);
                namePht = view.FindViewById<TextView>(Resource.Id.textView);
                view.Click += (sender, e) => action(base.LayoutPosition);
            }


        }
        void OnClick(int position)
        {
            if (ItemClick != null)
                ItemClick(this, position);
        }


    }

}