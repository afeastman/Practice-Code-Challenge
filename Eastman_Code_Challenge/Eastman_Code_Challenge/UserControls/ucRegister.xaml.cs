using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Eastman_Code_Challenge
{

    /// <summary>
    /// Interaction logic for ucRegister.xaml
    /// </summary>
    public partial class ucRegister : UserControl
    {
        //private ICollection<ModuloResults> ModResults;

        public ucRegister()
        {
            InitializeComponent();

            ModuloResults.SelectedIndex = 0;
        }


        private void OnLoaded(object sender, RoutedEventArgs args)
        {
            int Modulo3 = 0;
            int Modulo5 = 0;
            ObservableCollection<ModuloResults> xModResults = new ObservableCollection<ModuloResults>();
            for (int i = 1; i <= 100; i++)
            {
                Modulo3 = i % 3;
                Modulo5 = i % 5;
                
                ModuloResults mItem = new ModuloResults();

                if (Modulo3 == 0 && Modulo5 == 0)
                    mItem.Modulo = "Register Patient";
                else
                if (Modulo3 == 0)
                    mItem.Modulo = "Register";
                else
                if (Modulo5 == 0)
                    mItem.Modulo = "Patient";
                else
                    mItem.Modulo = i.ToString();

                xModResults.Add(mItem);
            }

            ModuloResults.ItemsSource = xModResults;
        }

        private void ModuloResults_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
