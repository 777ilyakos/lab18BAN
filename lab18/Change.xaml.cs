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
    /// Логика взаимодействия для Change.xaml
    /// </summary>
    public partial class Change : Window
    {
        
        public Change()
        {
            InitializeComponent();
           var vs =(Table_1) db.Table_1.Find(Class1.id);
            Id.Text =Convert.ToString( vs.NumberZach);
            Fn.Text = Convert.ToString(vs.FirstName);
            Mn.Text = Convert.ToString(vs.MidleName);
            Sn.Text = Convert.ToString(vs.SecondName);
            Ng.Text = Convert.ToString(vs.NumberGroup);
            Wl.Text = Convert.ToString(vs.WhereLeav);
            Pa.Text = Convert.ToString(vs.PredmetA);
            Pb.Text = Convert.ToString(vs.PredmetB);
            Pc.Text = Convert.ToString(vs.PredmetC);
            Pd.Text = Convert.ToString(vs.PredmetD);
            Pe.Text = Convert.ToString(vs.PredmetE);
        }
        DiscipEntities db = DiscipEntities.GetContext();

        private void Add_(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(Pa.Text) > 0 & Convert.ToInt32(Pa.Text) < 6 & Convert.ToInt32(Pb.Text) > 0 & Convert.ToInt32(Pb.Text) < 6 & Convert.ToInt32(Pc.Text) > 0 & Convert.ToInt32(Pc.Text) < 6 & Convert.ToInt32(Pd.Text) > 0 & Convert.ToInt32(Pd.Text) < 6 & Convert.ToInt32(Pe.Text) > 0 & Convert.ToInt32(Pe.Text) < 6)
            {
                try
                {

                    var vs = (Table_1)db.Table_1.Find(Class1.id);
                    vs.NumberZach = Convert.ToInt32(Id.Text);
                    vs.FirstName = Fn.Text;
                    vs.MidleName = Mn.Text;
                    vs.SecondName = Sn.Text;
                    vs.NumberGroup = Ng.Text;
                    vs.WhereLeav = Wl.Text; 
                        vs.PredmetA = Convert.ToInt32(Pa.Text);
                        vs.PredmetB = Convert.ToInt32(Pb.Text);
                        vs.PredmetC = Convert.ToInt32(Pc.Text);
                        vs.PredmetD = Convert.ToInt32(Pd.Text);
                        vs.PredmetE = Convert.ToInt32(Pe.Text);
                    db.SaveChanges();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
