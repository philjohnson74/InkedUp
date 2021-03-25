using System;
using System.Collections.Generic;
using Interactors.DTOs;
using Xamarin.Forms;

namespace InkedUpMobile
{
    public partial class InkUpPage : ContentPage
    {
        public IPen PenToInkUp { get; set; }

        public InkUpPage(IPen penToInkUp)
        {
            InitializeComponent();
            PenToInkUp = penToInkUp;

            LabelPenDisplayName.Text = PenToInkUp.DisplayName;

            if(penToInkUp.Ink != null)
                LabelCurrentInkDisplayName.Text = penToInkUp.Ink.DisplayName;

            var inks = App.PenCollectorInteractor.ListsInks();
            InksListView.ItemsSource = inks;
        }

        void InksListView_ItemSelected(Object sender, SelectedItemChangedEventArgs e)
        {
            var selectedInk = InksListView.SelectedItem as IInk;

            if (selectedInk != null)
            {
                if (App.PenCollectorInteractor.InkPen(PenToInkUp, selectedInk))
                    DisplayAlert("Success", "Pen successfully inked", "OK");
                else
                    DisplayAlert("Failure", "Pen failed to be inked", "OK");
            }
        }
    }
}
