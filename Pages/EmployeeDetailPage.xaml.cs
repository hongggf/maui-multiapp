using MauiApp1.ViewModels;

namespace MauiApp1.Pages;

public partial class EmployeeDetailPage : ContentPage
{
    public EmployeeDetailPage()
    {
        InitializeComponent();

        var employeeDetailViewModel = new EmployeeDetailViewModels
        {
            EmployeeID = "1001",
            EmployeeName = "John Thomas",
            Email = "johnthomas@gmail.com",
            IsPartTime = true
        };
        BindingContext = employeeDetailViewModel;
    }
}
