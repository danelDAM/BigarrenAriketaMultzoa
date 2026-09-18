using System.Windows;

namespace _9.ariketa
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void gehitu(object sender, RoutedEventArgs e)
        {
            if (lagunBerriaTB.Text != "")
            {
                lagunListaLB.Items.Add(lagunBerriaTB.Text);

                lagunBerriaTB.Text = "";
            }
        }

        private void ezabatu(object sender, RoutedEventArgs e)
        {
            if (lagunListaLB.SelectedItems.Count > 0)
            {
                while (lagunListaLB.SelectedItems.Count > 0)
                {
                    lagunListaLB.Items.Remove(lagunListaLB.SelectedItems[0]);
                }
            }
            else if (hautatutakoLagunaTB.Text != "")
            {
                lagunListaLB.Items.Remove(hautatutakoLagunaTB.Text);

                hautatutakoLagunaTB.Text = "";
            }
        }

        private void garbitu(object sender, RoutedEventArgs e)
        {
            lagunListaLB.Items.Clear();
        }
    }
}