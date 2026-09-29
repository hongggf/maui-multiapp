using CommunityToolkit.Mvvm.ComponentModel;
using System;

namespace MauiApp1.Models;

public partial class Employee : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Initials))]
    private string employeeId = string.Empty;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Initials))]
    private string employeeName = string.Empty;

    [ObservableProperty]
    private string email = string.Empty;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(WorkType))]
    [NotifyPropertyChangedFor(nameof(WorkTypeColor))]
    [NotifyPropertyChangedFor(nameof(WorkTypeBg))]
    private bool isPartTime;

    public string WorkType => IsPartTime ? "Part-Time" : "Full-Time";
    public string WorkTypeColor => IsPartTime ? "#FBBF24" : "#34D399";
    public string WorkTypeBg => IsPartTime ? "#2B1D04" : "#042B1A";

    public string Initials
    {
        get
        {
            if (string.IsNullOrWhiteSpace(EmployeeName)) return "EM";
            var parts = EmployeeName.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length >= 2) return $"{char.ToUpper(parts[0][0])}{char.ToUpper(parts[1][0])}";
            return EmployeeName.Length >= 2 ? EmployeeName.Substring(0, 2).ToUpper() : EmployeeName.ToUpper();
        }
    }
}
