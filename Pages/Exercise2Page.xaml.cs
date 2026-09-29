using MauiApp1.ViewModels;

namespace MauiApp1.Pages;

public partial class Exercise2Page : ContentPage
{
    public Exercise2Page()
    {
        InitializeComponent();
    }

    private void EmployeeButton1_Clicked(object sender, EventArgs e)
    {
        var employDetailViewModels1 = new EmployeeDetailViewModels1
        {
            EmployeeId = "1001",
            EmployeeName = "John Thomas",
            Email = "johnthomas@gmail.com",
            IsPartTime = true
        };
        var employeeDetailPage1 = new EmployeeDetailPage1();
        employeeDetailPage1.BindingContext = employDetailViewModels1;
        Navigation.PushAsync(employeeDetailPage1);
    }

    private void EmployeeButton2_Clicked(object sender, EventArgs e)
    {
        var employDetailViewModels1 = new EmployeeDetailViewModels1
        {
            EmployeeId = "1002",
            EmployeeName = "Peter",
            Email = "peter@gmail.com",
            IsPartTime = false
        };
        var employeeDetailPage1 = new EmployeeDetailPage1();
        employeeDetailPage1.BindingContext = employDetailViewModels1;
        Navigation.PushAsync(employeeDetailPage1);
    }

    private void EmployeeButton3_Clicked(object sender, EventArgs e)
    {
        var employDetailViewModels1 = new EmployeeDetailViewModels1
        {
            EmployeeId = "1003",
            EmployeeName = "Andrew",
            Email = "andraw@gmail.com",
            IsPartTime = true
        };
        var employeeDetailPage1 = new EmployeeDetailPage1();
        employeeDetailPage1.BindingContext = employDetailViewModels1;
        Navigation.PushAsync(employeeDetailPage1);
    }
}
