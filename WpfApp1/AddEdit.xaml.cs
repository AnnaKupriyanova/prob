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
    public partial class AddEdit : Window
    {
        ApplicationContext db;
        public AddEdit()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string last_name = input_last_name.Text.Trim();
            string first_name = input_first_name.Text.Trim();
            string middle_name = input_middle_name.Text.Trim();
            string degree = input_degree.Text.Trim();
            string position = input_position.Text.Trim();
            string exp = input_exp.Text.Trim();
            

            input_last_name.ToolTip = "";
            input_last_name.Background = Brushes.Transparent;
            input_first_name.ToolTip = "";
            input_first_name.Background = Brushes.Transparent;
            input_middle_name.ToolTip = "";
            input_middle_name.Background = Brushes.Transparent;
            input_degree.ToolTip = "";
            input_degree.Background = Brushes.Transparent;
            input_position.ToolTip = "";
            input_position.Background = Brushes.Transparent;
            input_exp.ToolTip = "";
            input_exp.Background = Brushes.Transparent;

            Teacher teacher = new Teacher(last_name, first_name, middle_name, degree, position, exp);

            db.Teachers.Add(teacher);
            db.SaveChanges();

            input_last_name.Clear();
            input_first_name.Clear();
            input_middle_name.Clear();
            input_position.Clear();
            input_exp.Clear();
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            Inf_system inf_System = new Inf_system();
            inf_System.Show();
            this.Hide();
        }
    }
}
