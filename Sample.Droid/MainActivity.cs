using Android.App;
using Android.Content;
using Android.Hardware;
using Android.OS;
using Android.Widget;
using System;

namespace Sample.Droid
{
    [Activity(Label = "Sample.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private SensorManager _sensorManager;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            if (bundle != null)
            {
                var myParam = bundle.GetString("MyParam");
            }

            _sensorManager = (SensorManager)GetSystemService(Context.SensorService);

            SetContentView(Resource.Layout.Main);
        }

        protected override void OnStart()
        {
            base.OnStart();

            var button = FindViewById<Button>(Resource.Id.MyButton);
            button.Background = GetDrawable(Resource.Drawable.Icon);
            button.Click += (e, args) =>
            {
                Console.WriteLine("Button clicked !");
            };
        }

        protected override void OnRestart()
        {
            base.OnRestart();
            Console.WriteLine("-> Restart activity");
        }

        protected override void OnResume()
        {
            base.OnResume();

            
        }

        protected override void OnPause()
        {
            base.OnPause();
            Console.WriteLine("-> Pause activity");
        }

        protected override void OnStop()
        {
            base.OnStop();
            Console.WriteLine("-> Stop activity");
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            Console.WriteLine("-> Destroy activity");
        }
    }
}

