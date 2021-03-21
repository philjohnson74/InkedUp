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
        }
    }
}
