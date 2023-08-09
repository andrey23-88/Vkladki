using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Person> users = new ObservableCollection<Person>
        {
            new Person{Name="Alex", Age=30},
            new Person{Name="Bob", Age=20},
            new Person{Name="Cris", Age=40},
            new Person{Name="Dan", Age=33},
            new Person{Name="Edward", Age=35}
        };

        public MainWindow()
        {
            InitializeComponent();
            numberList.Items.Add("Six");
            numberList.Items.Insert(2,"Seven");
            numberList.Items.Remove("Six");
            numberList.Items.RemoveAt(2);
            /*numberList.Items.Clear();*/

            userList.ItemsSource = users;
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new Person { Name = nameTxt.Text, Age=Convert.ToInt32(ageTxt.Text) });
            /*userList.Items.Refresh();*/ //не нужен при использовании ObservableCollection в качестве источника данных ListBox
            nameTxt.Text = "";
            ageTxt.Text = "";
        }

        private void userList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var users = userList.SelectedItems;
                foreach(var user in users)
                {
                    MessageBox.Show($"Имя выбранных элементов: {(Person)user}");
                }
        }
    }
}
