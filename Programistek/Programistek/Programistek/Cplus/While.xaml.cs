using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Programistek.Cplus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class While : ContentPage
    {
        public While()
        {
            InitializeComponent();

            labelWhile.Text = AppResources.StringWhileCplus;
            kodWhile.Text = AppResources.KodWhileCplus;
        }
    }
}