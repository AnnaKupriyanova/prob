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

        //public string[] types {  get; set; }
        //public string[] degrees { get; set; }

        public Inf_system()
        {
            InitializeComponent();
            db = new ApplicationContext();
            List<Teacher> teachers = db.Teachers.ToList();
            List<Subject> subjects = db.Subjects.ToList();
            List<Load> loads = db.Loads.ToList();

            list_teachers.ItemsSource = teachers;
            list_subjects.ItemsSource = subjects;
            list_loads.ItemsSource = loads;

            //types = new string[] { "Практика", "Лекция" };
            //DataContext.this;
        }

        private void Delete_Button(object sender, RoutedEventArgs e)
        {
            db.Teachers.Remove(list_teachers.SelectedItem as Teacher);
            db.SaveChanges();

            List<Teacher> teachers = db.Teachers.ToList();

            list_teachers.ItemsSource = teachers;
            list_teachers.Items.Refresh();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddEdit addEdit = new AddEdit();
            addEdit.Show();
            this.Hide();

            List<Teacher> teachers = db.Teachers.ToList();

            list_teachers.ItemsSource = teachers;
            list_teachers.Items.Refresh();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            AddEdit1 addEdit1 = new AddEdit1();
            addEdit1.Show();
            this.Hide();

            List<Subject> subjects = db.Subjects.ToList();

            list_subjects.ItemsSource = subjects;
            list_subjects.Items.Refresh();
        }

        private void Delete1_Button(object sender, RoutedEventArgs e)
        {
            db.Subjects.Remove(list_subjects.SelectedItem as Subject);
            db.SaveChanges();

            List<Subject> subjects = db.Subjects.ToList();

            list_subjects.ItemsSource = subjects;
            list_subjects.Items.Refresh();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            AddEdit2 addEdit2 = new AddEdit2();
            addEdit2.Show();
            this.Hide();

            List<Load> loads = db.Loads.ToList();

            list_loads.ItemsSource = loads;
            list_loads.Items.Refresh();
        }

        private void Delete2_Button(object sender, RoutedEventArgs e)
        {
            db.Loads.Remove(list_loads.SelectedItem as Load);
            db.SaveChanges();

            List<Load> loads = db.Loads.ToList();

            list_loads.ItemsSource = loads;
            list_loads.Items.Refresh();
        }
    }
}
