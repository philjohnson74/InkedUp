using System;
using System.Collections.Generic;
using Interactors.DTOs;
using Xamarin.Forms;

namespace InkedUpMobile
{
    public partial class InkUpPage : ContentPage
    {
        public InkUpPage(IPen penToInkUp)
        {
            InitializeComponent();
        }
    }
}
