using System;
using System.Collections.Generic;
using Interactors.DTOs;
using Xamarin.Forms;

namespace InkedUpMobile
{
    public partial class NewInkPage : ContentPage
    {
        public NewInkPage()
        {
            InitializeComponent();
        }

        void toolbarSave_Clicked(System.Object sender, System.EventArgs e)
        {
            Ink ink = new Ink()
            {
                Manufacturer = manufacturerEntry.Text,
                Colour = colourEntry.Text
            };

            if (App.PenCollectorInteractor.AcquiresInk(ink))
                DisplayAlert("Success", "Ink successfully added", "OK");
            else
                DisplayAlert("Failure", "Ink failed to be added", "OK");
        }
    }
}
