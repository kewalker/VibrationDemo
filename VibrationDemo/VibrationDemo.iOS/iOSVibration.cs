using CoreHaptics;
using Foundation;
using UIKit;
using VibrationDemo.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(iOSVibration))]
namespace VibrationDemo.iOS
{
    internal class iOSVibration : IVibration
    {
        public void DoVibration(string intensity)
        {
            UIImpactFeedbackGenerator feedbackGenerator;
            UINotificationFeedbackGenerator notificationFeedbackGenerator;
            UISelectionFeedbackGenerator selectionFeedbackGenerator;
            switch (intensity)
            {
                case "light":
                    feedbackGenerator = new UIImpactFeedbackGenerator(UIImpactFeedbackStyle.Light);
                    feedbackGenerator.Prepare();
                    feedbackGenerator.ImpactOccurred();
                    break;
                case "medium":
                    feedbackGenerator = new UIImpactFeedbackGenerator(UIImpactFeedbackStyle.Medium);
                    feedbackGenerator.Prepare();
                    feedbackGenerator.ImpactOccurred();
                    break;
                case "heavy":
                    feedbackGenerator = new UIImpactFeedbackGenerator(UIImpactFeedbackStyle.Heavy);
                    feedbackGenerator.Prepare();
                    feedbackGenerator.ImpactOccurred();
                    break;
                case "soft":
                    feedbackGenerator = new UIImpactFeedbackGenerator(UIImpactFeedbackStyle.Soft);
                    feedbackGenerator.Prepare();
                    feedbackGenerator.ImpactOccurred();
                    break;
                case "rigid":
                    feedbackGenerator = new UIImpactFeedbackGenerator(UIImpactFeedbackStyle.Rigid);
                    feedbackGenerator.Prepare();
                    feedbackGenerator.ImpactOccurred();
                    break;
                case "success":
                    notificationFeedbackGenerator = new UINotificationFeedbackGenerator();
                    notificationFeedbackGenerator.Prepare();
                    notificationFeedbackGenerator.NotificationOccurred(UINotificationFeedbackType.Success);
                    break;
                case "warning":
                    notificationFeedbackGenerator = new UINotificationFeedbackGenerator();
                    notificationFeedbackGenerator.Prepare();
                    notificationFeedbackGenerator.NotificationOccurred(UINotificationFeedbackType.Warning);
                    break;
                case "error":
                    notificationFeedbackGenerator = new UINotificationFeedbackGenerator();
                    notificationFeedbackGenerator.Prepare();
                    notificationFeedbackGenerator.NotificationOccurred(UINotificationFeedbackType.Error);
                    break;
                case "feel":
                    selectionFeedbackGenerator = new UISelectionFeedbackGenerator();
                    selectionFeedbackGenerator.Prepare();
                    selectionFeedbackGenerator.SelectionChanged();
                    break;
                case "sos":
                    try
                    {
                        // CHHapticEngine is only available on devices ~10+
                        var engine = new CHHapticEngine(out NSError error);
                        engine.Start(null);
                        var hapticIntensity = new CHHapticEventParameter(CHHapticEventParameterId.HapticIntensity, 1);
                        var sharpness = new CHHapticEventParameter(CHHapticEventParameterId.HapticSharpness, 1);
                        var short1 = new CHHapticEvent(CHHapticEventType.HapticTransient, new CHHapticEventParameter[] { hapticIntensity, sharpness }, 0);
                        var short2 = new CHHapticEvent(CHHapticEventType.HapticTransient, new CHHapticEventParameter[] { hapticIntensity, sharpness }, 0.2);
                        var short3 = new CHHapticEvent(CHHapticEventType.HapticTransient, new CHHapticEventParameter[] { hapticIntensity, sharpness }, 0.4);
                        var long1 = new CHHapticEvent(CHHapticEventType.HapticContinuous, new CHHapticEventParameter[] { hapticIntensity, sharpness }, 0.6, .5);
                        var long2 = new CHHapticEvent(CHHapticEventType.HapticContinuous, new CHHapticEventParameter[] { hapticIntensity, sharpness }, 1.2, .5);
                        var long3 = new CHHapticEvent(CHHapticEventType.HapticContinuous, new CHHapticEventParameter[] { hapticIntensity, sharpness }, 1.8, .5);
                        var short4 = new CHHapticEvent(CHHapticEventType.HapticTransient, new CHHapticEventParameter[] { hapticIntensity, sharpness }, 2.4);
                        var short5 = new CHHapticEvent(CHHapticEventType.HapticTransient, new CHHapticEventParameter[] { hapticIntensity, sharpness }, 2.6);
                        var short6 = new CHHapticEvent(CHHapticEventType.HapticTransient, new CHHapticEventParameter[] { hapticIntensity, sharpness }, 2.8);
                        var pattern = new CHHapticPattern(new CHHapticEvent[] { short1, short2, short3, long1, long2, long3, short4, short5, short6 }, new CHHapticDynamicParameter[] { }, out NSError someError);
                        var player = engine.CreatePlayer(pattern, out NSError playerError);
                        player.Start(0, out NSError playError);
                    }
                    catch { }
                    break;
            }
        }
    }
}