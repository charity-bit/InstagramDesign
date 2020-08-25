using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using InstagramDesign.CustomRenderers;
using InstagramDesign.Droid;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(myEntry),typeof(entryCustomRenderer))]
namespace InstagramDesign.Droid
{
   public class entryCustomRenderer : EntryRenderer
    {

        public entryCustomRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            Control.SetBackgroundColor(Android.Graphics.Color.Transparent);


        }



    }
}