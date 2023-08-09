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
using System.Windows.Shapes;

namespace WpfControls
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ObservableCollection<Phone> phones = new ObservableCollection<Phone>
        {
            new Phone{Title = "Xiaomi 13 Pro", Os = "Android 13", Memory = 12, CameraRes = 50, Price = 57990},
            new Phone{Title = "Nothing Phone 2", Os = "Android 13", Memory = 12, CameraRes = 50, Price = 67990},
            new Phone{Title = "Iphone 13 Pro", Os = "IOs", Memory = 8, CameraRes = 30, Price = 97990},
            new Phone{Title = "Xiaomi 14 Pro", Os = "IOs", Memory = 8, CameraRes = 50, Price = 107990},
            new Phone{Title = "Samsung ZFold", Os = "Android 13", Memory = 6, CameraRes = 50, Price = 77990}
        };

        ObservableCollection<Tablet> tablets = new ObservableCollection<Tablet>
        {
            new Tablet{Title = "Xiaomi Tab", Os = "Android 13", Memory = 4, Screen = 10, Price = 27990},
            new Tablet{Title = "IPad", Os = "IOs", Memory = 6, Screen = 8, Price = 67990},
            new Tablet{Title = "Samsung Galaxy Tab", Os = "Android 12", Memory = 6, Screen = 10, Price = 47990}
        };

        ObservableCollection<Notebook> notebooks = new ObservableCollection<Notebook>
        {
            new Notebook{Title = "Lenovo Legion Pro 7", Processor = "Intel i9", RAM = 32, HDD = 512, VRAM = "RTX 3080", Screen = 16, Price = 178990},
            new Notebook{Title = "ASUS ROG Zephyrus M16", Processor = "Intel i9-13900H", RAM = 32, HDD = 512, VRAM = "RTX 4090", Screen = 16, Price = 228990},
            new Notebook{Title = "MacBook Pro 16", Processor = "M2 Max", RAM = 32, HDD = 512, VRAM = "M2 Max", Screen = 16, Price = 248990}
        };

        public Window1()
        {
            InitializeComponent();
            phoneList.ItemsSource = phones;
            tabletsList.ItemsSource = tablets;
            phonesGrid.ItemsSource = phones;
        }

        private void addTabBtn_Click(object sender, RoutedEventArgs e)
        {
            ListBox noteList = new ListBox();
            noteList.ItemsSource = notebooks;

            products.Items.Insert(products.Items.Count - 1, new TabItem
            {
                Header = new TextBlock { Text = tabNameTxt.Text },
                Content = noteList
            });
        }

        private void addSmaBtn_Click(object sender, RoutedEventArgs e)
        {
            phones.Add(new Phone { Title = smaNameTxt.Text, Os = smaOsTxt.Text, Memory = Convert.ToInt32(smaMemTxt.Text), CameraRes = Convert.ToInt32(smaCamTxt.Text), Price = Convert.ToInt32(smaPriceTxt.Text) });
            smaNameTxt.Text = " "; smaOsTxt.Text = " "; smaMemTxt.Text = " "; smaCamTxt.Text = " "; smaPriceTxt.Text = " "; 
        }

        private void addTablBtn_Click(object sender, RoutedEventArgs e)
        {
            tablets.Add(new Tablet { Title = tablNameTxt.Text, Os = tablOsTxt.Text, Memory = Convert.ToInt32(tablMemTxt.Text), Screen = Convert.ToInt32(tablScreenTxt.Text), Price = Convert.ToInt32(tablPriceTxt.Text) });
            tablNameTxt.Text = " "; tablOsTxt.Text = " "; tablMemTxt.Text = " "; tablScreenTxt.Text = " ";
            tablPriceTxt.Text = " ";
        }
    }
}
