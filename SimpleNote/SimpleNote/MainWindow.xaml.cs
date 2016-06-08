using System.Drawing;
using System.Windows;
using DevExpress.XtraBars.Alerter;

namespace SimpleNote.WPF
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
            e.Buttons.PinButton.SetDown(CheckEditPin.IsChecked.HasValue &&
                CheckEditPin.IsChecked.Value);
        }

        private void ButtonShow_Click(object sender, RoutedEventArgs e)
        {
            var img = GetImage();

            alertControl.Show(null, TextEditTitle.Text, TextEditText.Text, img);
        }

        private Image GetImage()
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
            return img;
        }
    }
}
