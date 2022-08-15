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
using VibrationDemo.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidVibration))]
namespace VibrationDemo.Droid
{
    internal class AndroidVibration : IVibration
    {
        public void DoVibration(string intensity)
        {
            var viber = Vibrator.FromContext(MainActivity.MyAppContext);
            VibrationEffect vibe;
            switch (intensity)
            {
                case "light":
                    vibe = VibrationEffect.CreateOneShot(50, 25);
                    viber.Vibrate(vibe);
                    break;
                case "medium":
                    vibe = VibrationEffect.CreateOneShot(125, 67);
                    viber.Vibrate(vibe);
                    break;
                case "heavy":
                    vibe = VibrationEffect.CreateOneShot(255, 125);
                    viber.Vibrate(vibe);
                    break;
                case "soft":
                    vibe = VibrationEffect.CreateOneShot(25, 25);
                    viber.Vibrate(vibe);
                    break;
                case "rigid":
                    vibe = VibrationEffect.CreateOneShot(25, 125);
                    viber.Vibrate(vibe);
                    break;
                case "success":
                    vibe = VibrationEffect.CreateWaveform(new long[] { 0, 50, 125, 100 }, new int[] { 0, 50, 0, 100 }, -1);
                    viber.Vibrate(vibe);
                    break;
                case "warning":
                    vibe = VibrationEffect.CreateWaveform(new long[] { 0, 100, 150, 100 }, new int[] { 0, 100, 0, 100 }, -1);
                    viber.Vibrate(vibe);
                    break;
                case "error":
                    vibe = VibrationEffect.CreateWaveform(new long[] { 0, 65, 50, 65, 50, 65, 50, 65 }, new int[] { 0, 50, 0, 50, 0, 50, 0, 50 }, -1);
                    viber.Vibrate(vibe);
                    break;
                case "feel":
                    vibe = VibrationEffect.CreateOneShot(25, 15);
                    viber.Vibrate(vibe);
                    break;
                case "sos":
                    vibe = VibrationEffect.CreateWaveform(new long[] { 0, 25, 200, 25, 200, 25, 200, 450, 150, 450, 150, 450, 150, 25, 200, 25, 200, 25 }, new int[] { 0, 165, 0, 165, 0, 165, 0, 100, 0, 100, 0, 100, 0, 165, 0, 165, 0, 165 }, -1);
                    viber.Vibrate(vibe);
                    break;
            }
        }
    }
}