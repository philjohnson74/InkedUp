using System;
using Adapters.DTOs;
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

            var pens = App.PenCollectorAdapter.ListsPens();
            pensListView.ItemsSource = pens;
        }

        void pensListView_ItemSelected(Object sender, SelectedItemChangedEventArgs e)
        {
            var selectedPen = pensListView.SelectedItem as Pen;

            if (selectedPen != null)
            {
                Navigation.PushAsync(new PenDetailPage(selectedPen));
            }
        }
    }
}
