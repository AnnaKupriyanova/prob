using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AddEdit.xaml
    /// </summary>
    public partial class AddEdit2 : Window
    {
        ApplicationContext db;
        public AddEdit2()
        {
            InitializeComponent();
            db = new ApplicationContext();

            List<Teacher> teachers = db.Teachers.ToList();
            List<Subject> subjects = db.Subjects.ToList();

            input_teacher.ItemsSource = teachers;
            input_subject.ItemsSource = subjects;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string teacher = input_teacher.Text.Trim();
            string subject = input_subject.Text.Trim();
            string group = input_group.Text.Trim();
            string type = input_type.Text.Trim();

            input_teacher.ToolTip = "";
            input_teacher.Background = Brushes.Transparent;
            input_subject.ToolTip = "";
            input_subject.Background = Brushes.Transparent;
            input_group.ToolTip = "";
            input_group.Background = Brushes.Transparent;
            input_type.ToolTip = "";
            input_type.Background = Brushes.Transparent;

            if (input_teacher.Text == "" || input_subject.Text == "" || input_group.Text == "" || input_type.Text == "")
            {
                MessageBox.Show("Заполните поля", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Load load = new Load(teacher, subject, group, type);

                db.Loads.Add(load);
                db.SaveChanges();

                input_group.Clear();
            }
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            Inf_system inf_System = new Inf_system();
            inf_System.Show();
            this.Hide();
        }
    }
}
