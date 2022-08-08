using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            }
        }
    }
}