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

namespace WizardControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WizardControl_Next(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (i < (wizardControl.Items.Count - 1))
            {
                wizardControl.MoveNext(); i++;
                if (i == (wizardControl.Items.Count - 1))
                {
                    Button FinishButton = VisualUI.FindChild<Button>(Application.Current.MainWindow, "Part_FinishButton");

                    FinishButton.Visibility = Visibility.Visible;

                    Button NextButton = VisualUI.FindChild<Button>(Application.Current.MainWindow, "Part_NextButton");

                    NextButton.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void Part_FinishButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
        
    }
}
