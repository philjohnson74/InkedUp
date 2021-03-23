using System;
using System.Collections.Generic;
using Interactors.DTOs;
using Xamarin.Forms;

namespace InkedUpMobile
{
    public partial class NewPenPage : ContentPage
    {
        public NewPenPage()
        {
            InitializeComponent();
        }
        
        void toolbarSave_Clicked(System.Object sender, System.EventArgs e)
        {
            Pen pen = new Pen()
            {
                Manufacturer = manufacturerEntry.Text,
                Model = modelEntry.Text
            };

            if (App.PenCollectorInteractor.AcquiresPen(pen))
                DisplayAlert("Success", "Pen successfully added", "OK");
            else
                DisplayAlert("Failure", "Pen failed to be added", "OK");
        }
    }
}
