using System;
using Interactors.DTOs;
using Xamarin.Forms;

namespace InkedUpMobile
{
    public partial class PensPage : ContentPage
    {
        public PensPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var pens = App.PenCollectorInteractor.ListsPens();
            pensListView.ItemsSource = pens;
        }

        void pensListView_ItemSelected(Object sender, SelectedItemChangedEventArgs e)
        {
            var selectedPen = pensListView.SelectedItem as IPen;

            if (selectedPen != null)
            {
                Navigation.PushAsync(new PenDetailPage(selectedPen));
            }
        }
    }
}
