using System;
using System.Collections.Generic;
using Interactors.DTOs;
using Xamarin.Forms;

namespace InkedUpMobile
{
    public partial class InksPage : ContentPage
    {
        public InksPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var inks = App.PenCollectorInteractor.ListsInks();
            inksListView.ItemsSource = inks;
        }

        void inksListView_ItemSelected(Object sender, SelectedItemChangedEventArgs e)
        {
            var selectedInk = inksListView.SelectedItem as IInk;

            if (selectedInk != null)
            {
                Navigation.PushAsync(new InkDetailPage(selectedInk));
            }
        }
    }
}
