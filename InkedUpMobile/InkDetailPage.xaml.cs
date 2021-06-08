using System;
using System.Collections.Generic;
using Adapters.DTOs;
using Xamarin.Forms;

namespace InkedUpMobile
{
    public partial class InkDetailPage : ContentPage
    {
        public Ink SelectedInk { get; set; }

        public InkDetailPage(Ink ink)
        {
            InitializeComponent();
            SelectedInk = ink;
            ManufacturerEntry.Text = SelectedInk.Manufacturer;
            ColourEntry.Text = SelectedInk.Colour;
            LabelDisplayName.Text = SelectedInk.DisplayName;
        }

        void UpdateButton_Clicked(System.Object sender, System.EventArgs e)
        {
            SelectedInk.Manufacturer = ManufacturerEntry.Text;
            SelectedInk.Colour = ColourEntry.Text;

            if (App.PenCollectorAdapter.UpdatesInkDetails(SelectedInk))
                DisplayAlert("Success", "Ink successfully updated", "OK");
            else
                DisplayAlert("Failure", "Ink failed to be updated", "OK");
        }

        void DeleteButton_Clicked(System.Object sender, System.EventArgs e)
        {
            if (App.PenCollectorAdapter.GetsRidOfInk(SelectedInk))
                DisplayAlert("Success", "Ink successfully deleted", "OK");
            else
                DisplayAlert("Failure", "Ink failed to be deleted", "OK");
        }
    }
}
