using System.Windows;

namespace MyWpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            MyTextBox.Text = "Button Clicked!";
        }

        private void MyComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (MyComboBox.SelectedItem is System.Windows.Controls.ComboBoxItem selectedItem)
            {
                MyTextBox.Text = $"Selected: {selectedItem.Content}";
            }
        }
    }
}