using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Com.John.Waveview;

namespace WaveViewExample
{
    [Activity(Label = "WaveViewExample", MainLauncher = true,Theme ="@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var seekBar = FindViewById<SeekBar>(Resource.Id.seek_bar);
            var waveView = FindViewById<WaveView>(Resource.Id.wave_view);

            seekBar.ProgressChanged += (sender, eArgs) =>
            {
                waveView.SetProgress(seekBar.Progress);
            };
        }
    }
}

