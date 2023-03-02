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
using Microsoft.Win32;

namespace Image_Notes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }


        public void DisplayImageTest()
        {
            //OpenFileDialog dlg = new OpenFileDialog();
            //dlg.InitialDirectory = "c:\\";
            //dlg.Filter = "Image files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            //dlg.RestoreDirectory = true;

            //if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    string selectedFileName = dlg.FileName;
            //    FileNameLabel.Content = selectedFileName;

            //    // In order to get a bitmap, "image?", start here
            //    BitmapImage bitmap = new BitmapImage();
            //    bitmap.BeginInit();
            //    //we put image location in uri
            //    bitmap.UriSource = new Uri(selectedFileName);
            //    bitmap.EndInit();

            //    // Probably display our image to our image control
            //    ImageViewer1.Source = bitmap;
            //}
        }

        private void btnDisplayImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                imageDisplay.Source = new BitmapImage(new Uri(op.FileName));
            }
        }
    }
}
