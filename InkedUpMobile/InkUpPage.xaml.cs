using System;
using Adapters.DTOs;
using Xamarin.Forms;

namespace InkedUpMobile
{
    public partial class InkUpPage : ContentPage
    {
        public Pen PenToInkUp { get; set; }

        public InkUpPage(Pen penToInkUp)
        {
            InitializeComponent();
            PenToInkUp = penToInkUp;

            LabelPenDisplayName.Text = PenToInkUp.DisplayName;

            if(penToInkUp.Ink != null)
                LabelCurrentInkDisplayName.Text = penToInkUp.Ink.DisplayName;

            var inks = App.PenCollectorAdapter.ListsInks();
            InksListView.ItemsSource = inks;
        }

        void InksListView_ItemSelected(Object sender, SelectedItemChangedEventArgs e)
        {
            var selectedInk = InksListView.SelectedItem as Ink;

            if (selectedInk != null)
            {
                if (App.PenCollectorAdapter.InkPen(PenToInkUp, selectedInk))
                    DisplayAlert("Success", "Pen successfully inked", "OK");
                else
                    DisplayAlert("Failure", "Pen failed to be inked", "OK");
            }
        }
    }
}