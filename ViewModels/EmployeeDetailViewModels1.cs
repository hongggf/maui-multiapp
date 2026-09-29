using System.ComponentModel;

namespace MauiApp1.ViewModels;

public partial class EmployeeDetailViewModels1 : INotifyPropertyChanged
{
    private string employeeID = string.Empty;
    private string employeeName = string.Empty;
    private string email = string.Empty;
    private bool isPartTime;

    public string EmployeeId
    {
        get => employeeID;
        set
        {
            if (employeeID != value)
            {
                employeeID = value;
                NotifyPropertyChanged(nameof(EmployeeId));
                NotifyPropertyChanged(nameof(EmployeeID));
            }
        }
    }

    public string EmployeeID
    {
        get => employeeID;
        set
        {
            if (employeeID != value)
            {
                employeeID = value;
                NotifyPropertyChanged(nameof(EmployeeId));
                NotifyPropertyChanged(nameof(EmployeeID));
            }
        }
    }

    public string EmployeeName
    {
        get => employeeName;
        set
        {
            if (employeeName != value)
            {
                employeeName = value;
                NotifyPropertyChanged(nameof(EmployeeName));
            }
        }
    }

    public string Email
    {
        get => email;
        set
        {
            if (email != value)
            {
                email = value;
                NotifyPropertyChanged(nameof(Email));
            }
        }
    }

    public bool IsPartTime
    {
        get => isPartTime;
        set
        {
            if (isPartTime != value)
            {
                isPartTime = value;
                NotifyPropertyChanged(nameof(IsPartTime));
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void NotifyPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
