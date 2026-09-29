using MauiApp1.ViewModels;

namespace MauiApp1.Pages;

public partial class Exercise3Page : ContentPage
{
    public Exercise3Page()
    {
        InitializeComponent();
    }

    private void EmployeeButton1_Clicked(object sender, EventArgs e)
    {
        var employDetailViewModels2 = new EmployeeDetailViewModels2
        {
            EmployeeId = "1001",
            EmployeeName = "John Thomas",
            Email = "johnthomas@gmail.com",
            IsPartTime = true
        };
        var employeeDetailPage2 = new EmployeeDetailPage2();
        employeeDetailPage2.BindingContext = employDetailViewModels2;
        Navigation.PushAsync(employeeDetailPage2);
    }

    private void EmployeeButton2_Clicked(object sender, EventArgs e)
    {
        var employDetailViewModels2 = new EmployeeDetailViewModels2
        {
            EmployeeId = "1002",
            EmployeeName = "Peter",
            Email = "peter@gmail.com",
            IsPartTime = false
        };
        var employeeDetailPage2 = new EmployeeDetailPage2();
        employeeDetailPage2.BindingContext = employDetailViewModels2;
        Navigation.PushAsync(employeeDetailPage2);
    }

    private void EmployeeButton3_Clicked(object sender, EventArgs e)
    {
        var employDetailViewModels2 = new EmployeeDetailViewModels2
        {
            EmployeeId = "1003",
            EmployeeName = "Andrew",
            Email = "andraw@gmail.com",
            IsPartTime = true
        };
        var employeeDetailPage2 = new EmployeeDetailPage2();
        employeeDetailPage2.BindingContext = employDetailViewModels2;
        Navigation.PushAsync(employeeDetailPage2);
    }
}
