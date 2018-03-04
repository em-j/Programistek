using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Programistek
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CplusPage : ContentPage
    {
        public CplusPage()
        {
            InitializeComponent();

             
        }


        private void OpenWhile(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Navigation.PushModalAsync(new Cplus.While());
        }


    }
}