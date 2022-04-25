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

namespace lab18
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public Add()
        {
            InitializeComponent();
        }
        DiscipEntities db = DiscipEntities.GetContext();
        private void Add_(object sender, RoutedEventArgs e)
        {
            Table_1 _1 = new Table_1();
            if (Convert.ToInt32(Pa.Text) > 0 & Convert.ToInt32(Pa.Text) < 6 & Convert.ToInt32(Pb.Text) > 0 & Convert.ToInt32(Pb.Text) < 6 & Convert.ToInt32(Pc.Text) > 0 & Convert.ToInt32(Pc.Text) < 6 & Convert.ToInt32(Pd.Text) > 0 & Convert.ToInt32(Pd.Text) < 6 & Convert.ToInt32(Pe.Text) > 0 & Convert.ToInt32(Pe.Text) < 6)
            {
                try
                {

                    _1.NumberZach = Convert.ToInt32(Id.Text);
                    _1.FirstName = Fn.Text;
                    _1.MidleName = Mn.Text;
                    _1.SecondName = Sn.Text;
                    _1.NumberGroup = Ng.Text;
                    _1.WhereLeav = Wl.Text;
                   
                        _1.PredmetA = Convert.ToInt32(Pa.Text);
                        _1.PredmetB = Convert.ToInt32(Pb.Text);
                        _1.PredmetC = Convert.ToInt32(Pc.Text);
                        _1.PredmetD = Convert.ToInt32(Pd.Text);
                        _1.PredmetE = Convert.ToInt32(Pe.Text);
                    
                    db.Table_1.Add(_1);
                    db.SaveChanges();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода","Error",MessageBoxButton.OK,MessageBoxImage.Error);
                }
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
