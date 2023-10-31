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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AddEdit.xaml
    /// </summary>
    public partial class AddEdit1 : Window
    {
        ApplicationContext db;
        
        public string[] types {  get; set; }

        public AddEdit1()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = input_name.Text.Trim();
            string hours = input_hours.Text.Trim();

            input_name.ToolTip = "";
            input_name.Background = Brushes.Transparent;
            input_hours.ToolTip = "";
            input_hours.Background = Brushes.Transparent;

            Subject subject = new Subject(name, hours);

            db.Subjects.Add(subject);
            db.SaveChanges();

            input_name.Clear();
            input_hours.Clear(); 
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            Inf_system inf_System = new Inf_system();
            inf_System.Show();
            this.Hide();
        }
    }
}
