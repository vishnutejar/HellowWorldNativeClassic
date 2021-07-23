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
   public class Photo
    {
        public Photo(int id, string caption)
        {
            PhotoID = id;
            Caption = caption;
        }

        // Return the ID of the photo:
        public int PhotoID { get; }

        // Return the Caption of the photo:
        public string Caption { get; }
    }
}