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
using Android.Support.V7.App;
using Felipecsl.GifImageViewLibrary;
using System.IO;
using System.Timers;
using Android.Content.Res;
using FFImageLoading;

namespace Programistek.Droid
{
    [Activity(Label = "Programistek", Icon = "@drawable/logo", MainLauncher = true, Theme ="@style/Theme.AppCompat.Light.NoActionBar", NoHistory = true)]
    public class SplashPage : AppCompatActivity
    {
        private GifImageView gifImageView; 

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SplashScreen);


            gifImageView = FindViewById<GifImageView>(Resource.Id.gifSplash);
            AssetManager assets = this.Assets;
            Stream input = assets.Open("splash_dragon5.gif");

            byte[] bytes = ConvertFileToByteArray(input);
            gifImageView.SetBytes(bytes);
            gifImageView.StartAnimation();
              
            //Wait for 3 seconds and start new Activity
                       

            Timer timer = new Timer();
            timer.Interval = 4200;
            timer.AutoReset = false;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            StartActivity(new Intent(this, typeof(MainActivity)));
        }
     
        private byte[] ConvertFileToByteArray(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                    ms.Write(buffer, 0, read);
                return ms.ToArray();
            }
    }
         
    }
}