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
                    vibe = VibrationEffect.CreateOneShot(50, 50);
                    //vibe = VibrationEffect.CreatePredefined(VibrationEffect.EffectTick);
                    viber.Vibrate(vibe);
                    break;
                case "medium":
                    vibe = VibrationEffect.CreateOneShot(150, 150);
                    //vibe = VibrationEffect.CreatePredefined(VibrationEffect.EffectClick);
                    viber.Vibrate(vibe);
                    break;
                case "heavy":
                    vibe = VibrationEffect.CreateOneShot(255, 255);
                    //vibe = VibrationEffect.CreatePredefined(VibrationEffect.EffectHeavyClick);
                    viber.Vibrate(vibe);
                    break;
                case "soft":
                    //vibe = VibrationEffect.CreateWaveform(new long[] {0,10,1000,10},-1);
                    vibe = VibrationEffect.CreateOneShot(50, 50);
                    viber.Vibrate(vibe);
                    break;
                case "rigid":
                    vibe = VibrationEffect.CreateOneShot(50, 250);
                    //vibe = VibrationEffect.CreatePredefined(VibrationEffect.EffectHeavyClick);
                    viber.Vibrate(vibe);
                    break;
                case "success":
                    vibe = VibrationEffect.CreateWaveform(new long[] { 0, 50, 150, 100 }, new int[] { 0, 100, 0, 255 }, -1);
                    viber.Vibrate(vibe);
                    break;
                case "warning":
                    vibe = VibrationEffect.CreateWaveform(new long[] { 0, 100, 150, 100 }, new int[] { 0, 200, 0, 200 }, -1);
                    viber.Vibrate(vibe);
                    break;
                case "error":
                    vibe = VibrationEffect.CreateWaveform(new long[] { 0, 65, 50, 65, 50, 65, 50, 65 }, new int[] { 0, 200, 0, 100, 0, 100, 0, 100 }, -1);
                    viber.Vibrate(vibe);
                    break;
                case "feel":
                    vibe = VibrationEffect.CreateOneShot(50, 50);
                    //vibe = VibrationEffect.CreatePredefined(VibrationEffect.EffectTick);
                    viber.Vibrate(vibe);
                    break;

            }

            //Vibrator viber = (Vibrator) GetSystemService(ApplicationContext.Vib)
            //Vibrator viber = new Vibrator();



            //VibrationEffect.CreatePredefined(VibrationEffect.)
            //viber.Vibrate(VibrationEffect.CreateOneShot(10000, 255));
        }
    }
}