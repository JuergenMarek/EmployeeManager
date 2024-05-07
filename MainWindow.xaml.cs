using System.Windows;

namespace EmployeeManager
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

        private void btn_ausfuehren_Click(object sender, RoutedEventArgs e)
        {
            // Auslesen der Inhalte der beiden Textboxen
            string name = txt_name.Text;
            string alter = txt_alter.Text;

            // Bergrüßungstext generieren
            string begruessung = $"Herzlich willkommen, {name}! Ihr Alter ist {alter} Jahre.";

            // Ausgabe der Begrüßung im Textblock
            txtblk_ausgabe.Text = begruessung;
        }
    }
}
