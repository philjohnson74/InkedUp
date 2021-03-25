using System;
using System.Collections.Generic;
using Interactors.DTOs;
using Xamarin.Forms;

namespace InkedUpMobile
{
    public partial class PenDetailPage : ContentPage
    {
        public IPen SelectedPen { get; set; }

        public PenDetailPage(IPen pen)
        {
            InitializeComponent();
            SelectedPen = pen;
            ManufacturerEntry.Text = SelectedPen.Manufacturer;
            ModelEntry.Text = SelectedPen.Model;
            LabelDisplayName.Text = pen.DisplayNameWithInk;
        }

        void ToolbarInkUp_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new InkUpPage(SelectedPen));
        }

        void UpdateButton_Clicked(System.Object sender, System.EventArgs e)
        {
            SelectedPen.Manufacturer = ManufacturerEntry.Text;
            SelectedPen.Model = ModelEntry.Text;

            if (App.PenCollectorInteractor.UpdatesPenDetails(SelectedPen))
                DisplayAlert("Success", "Pen successfully updated", "OK");
            else
                DisplayAlert("Failure", "Pen failed to be updated", "OK");
        }

        void DeleteButton_Clicked(System.Object sender, System.EventArgs e)
        {
            if (App.PenCollectorInteractor.GetsRidOfPen(SelectedPen))
                DisplayAlert("Success", "Pen successfully deleted", "OK");
            else
                DisplayAlert("Failure", "Pen failed to be deleted", "OK");
        }
    }
}
