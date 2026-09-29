using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Models;

namespace MauiApp1.ViewModels;

public partial class EmployeeListViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Employee> employees = new();

    [ObservableProperty]
    private Employee employee = new();

    public EmployeeListViewModel()
    {
        Employees.Add(new Employee
        {
            EmployeeId = "1001",
            EmployeeName = "John Thomas",
            Email = "johnthomas@gmail.com",
            IsPartTime = true
        });
        Employees.Add(new Employee
        {
            EmployeeId = "1002",
            EmployeeName = "Peter Parker",
            Email = "peter@gmail.com",
            IsPartTime = false
        });
        Employees.Add(new Employee
        {
            EmployeeId = "1003",
            EmployeeName = "Andrew Garfield",
            Email = "andrew@gmail.com",
            IsPartTime = true
        });
    }

    [RelayCommand]
    private void Add()
    {
        if (string.IsNullOrWhiteSpace(Employee.EmployeeName) && string.IsNullOrWhiteSpace(Employee.EmployeeId))
            return;

        var newEmp = new Employee
        {
            EmployeeId = string.IsNullOrWhiteSpace(Employee.EmployeeId) ? (1000 + Employees.Count + 1).ToString() : Employee.EmployeeId,
            EmployeeName = string.IsNullOrWhiteSpace(Employee.EmployeeName) ? "New Employee" : Employee.EmployeeName,
            Email = string.IsNullOrWhiteSpace(Employee.Email) ? "employee@company.com" : Employee.Email,
            IsPartTime = Employee.IsPartTime
        };

        Employees.Add(newEmp);
        Employee = new Employee();
    }
}

public class EmployeeListViewModels : EmployeeListViewModel { }
