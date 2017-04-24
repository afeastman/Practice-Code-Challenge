using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

namespace Eastman_Code_Challenge
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<string, UserControl> SettingsControls;

        public MainWindow()
        {
            InitializeComponent();

            SettingsControls = new Dictionary<string, UserControl>();
            SettingsControls.Add("NoEventType", new NoEventType());
            SettingsControls.Add("Register", new ucRegister());
            SettingsControls.Add("Diagnose", new ucDiagnose());
            // Add any new User Controls to the 'UserControl' Dictionary
        }

        #region OnLoaded App.Config logic
        private void OnLoaded(object sender, RoutedEventArgs args)
        {
            string str0 = System.Configuration.ConfigurationManager.AppSettings["key0"].ToString();
            if (!String.IsNullOrEmpty(str0))
            {
                ComboEventLst.Items.Add(str0);
            }
            else
                sbMessages.Text = "App.Config Key0 entry is empty.";

            string str1 = System.Configuration.ConfigurationManager.AppSettings["key1"].ToString();
            if (!String.IsNullOrEmpty(str1))
            {
                ComboEventLst.Items.Add(str1);
            }
            else
                sbMessages.Text = "App.Config Key1 entry is empty.";

            string str2 = System.Configuration.ConfigurationManager.AppSettings["key2"].ToString();
            if (!String.IsNullOrEmpty(str2))
            {
                ComboEventLst.Items.Add(str2);
            }
            else
                sbMessages.Text = "App.Config Key2 entry is empty.";

            // Add any new Event Types to the ComboEventList by creating an app.config key# entry.

            sbMessages.Text = "Please select an event type using the above ComboBox.";
        }
        #endregion

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            winAbout win = new winAbout();

            win.Owner = this;
            win.ShowDialog();
        }

        private void Combo_SelChange(object sender, SelectionChangedEventArgs e)
        {
            string item = ComboEventLst.SelectedItem as String;
            if (string.IsNullOrEmpty(item)) return;
            if (SettingsControls.ContainsKey(item) && !docMain.Children.Contains(SettingsControls[item]))
            {
                docMain.Children.Clear();
                docMain.Children.Add(SettingsControls[item]);
            }
            else
            { sbMessages.Text = "No Event Type Selected"; }

        }
    }
}
