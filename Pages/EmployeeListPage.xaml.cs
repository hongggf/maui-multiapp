using MauiApp1.Models;
using MauiApp1.ViewModels;

namespace MauiApp1.Pages;

public partial class EmployeeListPage : ContentPage
{
    public EmployeeListPage()
    {
        InitializeComponent();
        BindingContext = new EmployeeListViewModel();
    }

    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is Employee employee)
        {
            var employeeDetailViewModel3 = new EmployeeDetailViewModels3 { Employee = employee };
            var employeeDetailPage3 = new EmployeeDetailPage3();
            employeeDetailPage3.BindingContext = employeeDetailViewModel3;
            Navigation.PushAsync(employeeDetailPage3);
        }
    }
}
