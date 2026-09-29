using MauiApp1.Pages;

namespace MauiApp1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(EmployeeDetailPage), typeof(EmployeeDetailPage));
            Routing.RegisterRoute(nameof(EmployeeDetailPage1), typeof(EmployeeDetailPage1));
            Routing.RegisterRoute(nameof(EmployeeDetailPage2), typeof(EmployeeDetailPage2));
            Routing.RegisterRoute(nameof(EmployeeDetailPage3), typeof(EmployeeDetailPage3));
        }
    }
}
