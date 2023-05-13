using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace List_Employees
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///  
    public partial class MainWindow : Window
    {
     
        List<CEmployees> employees = new List<CEmployees>();

        public MainWindow()
        {
            InitializeComponent();
            AddEmployees();
            LoadList();
        }
        public void AddEmployees()
        {
            employees.Add(new CEmployees { Name = "Іван", Position = "Менеджер", Salary = 50000 });
            employees.Add(new CEmployees { Name = "Марія", Position = "Розробник", Salary = 60000 });
            employees.Add(new CEmployees { Name = "Світлана", Position = "Менеджер", Salary = 5000 });
            employees.Add(new CEmployees { Name = "Ігор", Position = "Директор", Salary = 1000 });
            employees.Add(new CEmployees { Name = "Жора", Position = "Розробник", Salary = 800 });
            employees.Add(new CEmployees { Name = "Максим", Position = "Співробітник", Salary = 1000 });
            employees.Add(new CEmployees { Name = "Петро", Position = "Менеджер", Salary = 55000 });
            employees.Add(new CEmployees { Name = "Антон", Position = "Співробітник", Salary = 1000 });
            employees.Add(new CEmployees { Name = "Катя", Position = "Директор", Salary = 5000 });
            employees.Add(new CEmployees { Name = "Сергій", Position = "Розробник", Salary = 3000 });
            employees.Add(new CEmployees { Name = "Денис", Position = "Співробітник", Salary = 800 });
        }

        public void LoadList()
        {
            listViewEmployees.ItemsSource = employees;
        }
    }
}
      