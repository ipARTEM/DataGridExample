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

namespace DataGridExample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            Employee johnSmith = new Employee();

            johnSmith.employeeID = "001";

            johnSmith.employeeName = "Jonh Smith";

            johnSmith.employeeAddress = "122 Made Up Lane";

            johnSmith.employeeCity = "Camden";

            johnSmith.employeeState = "New Jersey";

            DG.Items.Add(johnSmith);


            Employee sallyMae = new Employee();


            sallyMae.employeeID = "002";

            sallyMae.employeeName = "Sally Mae";

            sallyMae.employeeAddress = "122 Made Up Lane";

            sallyMae.employeeCity = "Harlem";

            sallyMae.employeeState = "New York";

            DG.Items.Add(sallyMae);
        }

        public class Employee
        {
            public string employeeID { get; set; }
            public string employeeName { get; set; }
            public string employeeAddress { get; set; }
            public string employeeCity { get; set; }
            public string employeeState { get; set; }



        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = new Employee();

            employee.employeeID = TBID.Text;
            employee.employeeName = TBName.Text;
            employee.employeeAddress = TBAdress.Text;
            employee.employeeCity = TBCity.Text;
            employee.employeeState = TBState.Text;

            DG.Items.Add(employee);
        }
    }
}
