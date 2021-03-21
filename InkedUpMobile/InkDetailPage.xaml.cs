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
        }
    }
}
