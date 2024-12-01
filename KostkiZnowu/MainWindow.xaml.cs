using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KostkiZnowu
{
    public partial class MainWindow : Window
    {
        private int punkty;
        private Kostka kostka;

        public MainWindow()
        {
            InitializeComponent();
            ResetujGre();
        }

        private void RzutButton_Click(object sender, RoutedEventArgs e)
        {
            punkty += kostka.Rzut();
            WynikTextBlock.Text = punkty.ToString();
            GrafikaLabel.Content = kostka.Rzut().ToString();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            ResetujGre();
        }

        private void ResetujGre()
        {
            punkty = 0;
            kostka = new Kostka6Scienna();
            WynikTextBlock.Text = punkty.ToString();
            GrafikaLabel.Content = "?";
        }
    }

    public class Kostka
    {
        public virtual int Rzut()
        {
            return 0;
        }
    }

    public class Kostka6Scienna : Kostka
    {
        public override int Rzut()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }
    }
}
