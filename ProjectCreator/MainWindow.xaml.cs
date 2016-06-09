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
using System.IO;

namespace ProjectCreator
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

        //Define Variables:
        string mProjectNumber;
        string mProjectName;
        string mPath;

        private void createProject_button_Click(object sender, RoutedEventArgs e)
        {
            mProjectNumber = projectName_textbox.Text;
            mProjectName = projectNumber_textbox.Text;
            mPath = @"c:\" + mProjectNumber + "." + mProjectName;

            try
            {
                if (Directory.Exists(mPath))
                {
                    information_label.Content = "That path already exists.";
                    return;
                }

                // Try to create directory:
                DirectoryInfo di = Directory.CreateDirectory(mPath);
                information_label.Content = "The directory was created successfully";
            }
            catch (Exception err)
            {
                information_label.Content = "The directory creation failed.";
            }
            finally {}
            

        }
    }
}
