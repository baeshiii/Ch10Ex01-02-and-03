using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Ch10Ex03
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Grid handler, bubbling up");
            e.Handled = true;
        }

        private void Grid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Grid handler, tunneling down");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Your button click event handler logic here
        }

        private void RotatedButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Window handler, bubbling up");
        }

        private void rotatedButton_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Window handler, tunneling down");
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Window handler, bubbling up");
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Window handler, tunneling down");
        }
    }
}
