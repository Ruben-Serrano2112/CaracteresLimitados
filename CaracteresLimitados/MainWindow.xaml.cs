using System.Windows;


namespace CaracteresLimitados
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Contenedor_TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

            Contador_TextBox.Text = Contenedor_TextBox.Text.Length + "/ 140";
            if (Contenedor_TextBox.Text.Length >= 140)
            {
                Contenedor_TextBox.IsReadOnly = true;
            }
        }
    }

}
