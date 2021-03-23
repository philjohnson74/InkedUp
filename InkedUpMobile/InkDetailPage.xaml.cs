using System;
using System.Collections.Generic;
using Interactors.DTOs;
using Xamarin.Forms;

namespace InkedUpMobile
{
    public partial class InkDetailPage : ContentPage
    {
        public IInk SelectedInk { get; set; }

        public InkDetailPage(IInk ink)
        {
            InitializeComponent();
            SelectedInk = ink;
            manufacturerEntry.Text = SelectedInk.Manufacturer;
            colourEntry.Text = SelectedInk.Colour;
        }

        void updateButton_Clicked(System.Object sender, System.EventArgs e)
        {
            SelectedInk.Manufacturer = manufacturerEntry.Text;
            SelectedInk.Colour = colourEntry.Text;

            if (App.PenCollectorInteractor.UpdatesInkDetails(SelectedInk))
                DisplayAlert("Success", "Ink successfully updated", "OK");
            else
                DisplayAlert("Failure", "Ink failed to be updated", "OK");
        }

        void deleteButton_Clicked(System.Object sender, System.EventArgs e)
        {
            if (App.PenCollectorInteractor.GetsRidOfInk(SelectedInk))
                DisplayAlert("Success", "Ink successfully deleted", "OK");
            else
                DisplayAlert("Failure", "Ink failed to be deleted", "OK");
        }
    }
}
