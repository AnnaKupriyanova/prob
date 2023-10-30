using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
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
    /// Логика взаимодействия для Inf_system.xaml
    /// </summary>
    public partial class Inf_system : Window
    {
        ApplicationContext db;

        public Inf_system()
        {
            InitializeComponent();
            db = new ApplicationContext();
            List<Teacher> teachers = db.Teachers.ToList();

            list_teachers.ItemsSource = teachers;
        }

        private void Save_Button(object sender, RoutedEventArgs e)
        {
            string last_name = input_last_name.Text.Trim();
            string first_name = input_first_name.Text.Trim();
            string middle_name = input_middle_name.Text.Trim();

            input_last_name.ToolTip = "";
            input_last_name.Background = Brushes.Transparent;
            input_first_name.ToolTip = "";
            input_first_name.Background = Brushes.Transparent;
            input_middle_name.ToolTip = "";
            input_middle_name.Background = Brushes.Transparent;

            Teacher teacher = new Teacher(last_name, first_name, middle_name);

            db.Teachers.Add(teacher);
            db.SaveChanges();

            input_last_name.Clear();
            input_first_name.Clear();
            input_middle_name.Clear();

            List<Teacher> teachers = db.Teachers.ToList();

            list_teachers.ItemsSource = teachers;
            list_teachers.Items.Refresh();
        }

        private void Delete_Button(object sender, RoutedEventArgs e)
        {
            //list_teachers.Items.Remove(list_teachers.SelectedItem);
            //list_teachers.Items.Refresh();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddEdit addEdit = new AddEdit();
            addEdit.Show();
            this.Hide();
        }
    }
}
