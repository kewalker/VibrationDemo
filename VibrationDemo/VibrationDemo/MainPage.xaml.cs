using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VibrationDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            IVibration service = DependencyService.Get<IVibration>();

            var intensity = (sender as Button).BindingContext as string;
            service.DoVibration(intensity);
        }
    }
}
