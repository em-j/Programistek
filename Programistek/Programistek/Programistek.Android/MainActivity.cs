using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using FFImageLoading.Forms.Droid;

namespace Programistek.Droid
{
    [Activity( Label = "Programistek", Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {

        private static App _app;
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
            CachedImageRenderer.Init(true);

            _app = new App();

            if (App.InDesignMode)
            {
                LoadApplication(UXDivers.Gorilla.Droid.Player.UseApplication(_app, this,
                    new UXDivers.Gorilla.Config("Hello Emi")));
            }
            else
            {
                LoadApplication(_app);
            }
        }
    }
    
}

