using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace lab18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        DiscipEntities db = DiscipEntities.GetContext();
        private void Window_Activated(object sender, EventArgs e)
        {
            db.Table_1.Load();
            Data.ItemsSource = db.Table_1.Local.ToBindingList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            Class1.id = Data.SelectedIndex+1;
            Change change = new Change();
            change.ShowDialog();
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult REZ = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (REZ == MessageBoxResult.Yes)
            {
                int i = Data.SelectedIndex;
                var vs = (Table_1)Data.Items[i];
                db.Table_1.Remove(vs);
                db.SaveChanges();
            }      
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        List<Table_1> _1s;
  
        private void Poisk_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void Filter_Click(object sender, RoutedEventArgs e)
        {
           
                if (FilterCheck.IsChecked == true)
                {
                    _1s = db.Table_1.ToList();
                
                    var filtered = _1s.Where(p => p.SecondName == filtr.Text);
                    Data.ItemsSource = filtered;
                }
                if (FilterCheck.IsChecked == false)
                {
                    Data.ItemsSource = db.Table_1.Local.ToBindingList();
                }

            
        }
    }
}
