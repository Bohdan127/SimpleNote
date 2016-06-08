using DevExpress.XtraBars.Alerter;
using System.Drawing;
using System.Windows;

namespace WpfApplicationTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AlertControl alertControl;

        public MainWindow()
        {
            InitializeComponent();
            alertControl = new AlertControl();
            alertControl.FormLoad += AlertControl_FormLoad;
        }

        private void AlertControl_FormLoad(object sender, AlertFormLoadEventArgs e)
        {
            e.Buttons.PinButton.Down = CheckEditPin.IsChecked.HasValue &&
                CheckEditPin.IsChecked.Value;
        }

        private void ButtonShow_Click(object sender, RoutedEventArgs e)
        {
            Image img;
            switch (ComboBoxEditType.SelectedIndex)
            {
                case 0:
                    img = Image.FromFile(@".\Images\success.png");
                    break;
                case 1:
                    img = Image.FromFile(@".\Images\stop.png");
                    break;
                default:
                    img = Image.FromFile(@".\Images\warning.png");
                    break;

            }
            alertControl.Show(null, TextEditTitle.Text, TextEditText.Text, img);
        }
    }
}
