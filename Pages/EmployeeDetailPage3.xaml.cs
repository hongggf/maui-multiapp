using System;
using Microsoft.Maui.Controls;

namespace MauiApp1.Pages;

public partial class EmployeeDetailPage3 : ContentPage
{
    public EmployeeDetailPage3()
    {
        InitializeComponent();
    }

    private void OnBackClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}
