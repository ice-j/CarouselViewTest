using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Reflection;
using Xamarin.Forms;

namespace CarouselViewTest.Droid
{
	[Activity (Label = "CarouselViewTest", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
            var cv = typeof(CarouselView);
            var assembly = Assembly.Load(cv.FullName);
            LoadApplication (new CarouselViewTest.App ());
		}
	}
}

