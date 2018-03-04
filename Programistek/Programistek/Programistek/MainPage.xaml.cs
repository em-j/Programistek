using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Programistek
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Padding = new OnPlatform<Thickness>
            {
                Android = new Thickness(0,20,0,20),
                Default = new Thickness(0,50,0,50),
                WinPhone = new Thickness(0,30,0,50)
            };
        }

        private  void OpenCplus(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            button.Navigation.PushModalAsync(new CplusPage());
        }


        protected override bool OnBackButtonPressed()
        {

            if (Device.OS == TargetPlatform.Android)
               {
                    DependencyService.Get<ICloseApplication>().closeApplication();
               }   
            //if you want stop the back button 
            return true;

           
        }
    }
}
