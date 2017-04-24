using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace Eastman_Code_Challenge
{
    /// <summary>
    /// Interaction logic for ucDiagnose.xaml
    /// </summary>
    public partial class ucDiagnose : UserControl
    {
        public ucDiagnose()
        {
            InitializeComponent();

            ModuloResults.SelectedIndex = 0;
        }

        private void OnLoaded(object sender, RoutedEventArgs args)
        {
            int Modulo2 = 0;
            int Modulo7 = 0;
            ObservableCollection<ModuloResults> xModResults = new ObservableCollection<ModuloResults>();
            for (int i = 1; i <= 100; i++)
            {
                Modulo2 = i % 2;
                Modulo7 = i % 7;

                ModuloResults mItem = new ModuloResults();

                if (Modulo2 == 0 && Modulo7 == 0)
                    mItem.Modulo = "Diagnose Patient";
                else
                    if (Modulo2 == 0)
                        mItem.Modulo = "Diagnose";
                    else
                        if (Modulo7 == 0)
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
