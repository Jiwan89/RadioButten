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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RadioButten
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           if (rb_Bronze.IsChecked == true)
            {
                lbl_abo.Content = "Du hast das Bromze_Abo gewählt";
            }
           else if(rb_Silber.IsChecked == true)
            {
                lbl_abo.Content = "Du hast das Silber_Abo gewählt";
            }
           else if(rb_Gold.IsChecked == true)
            {
                lbl_abo.Content = "Du hast das Gold_Abo gewählt";
            }

           if (rb_Mann.IsChecked == true)
            {
                lbl_geschlecht.Content = "Du bist ein Mann !";
            }
           else if (rb_Frau.IsChecked == true)
            {
                lbl_geschlecht.Content = " Du bist eine Frau !";
            }
           else if (rb_Devr.IsChecked == true)
            {
                lbl_geschlecht.Content = "geschlecht bleib nicht angezeigt !!";
            }
        }
    }
}
