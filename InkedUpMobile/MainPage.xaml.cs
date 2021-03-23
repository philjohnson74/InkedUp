using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InkedUpMobile
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void ToolbarAddPen_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NewPenPage());
        }

        void ToolbarAddInk_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NewInkPage());
        }
    }
}
