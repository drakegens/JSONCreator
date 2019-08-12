using JSONCreator.BusinessLogic;
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

namespace JSONCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var x = new JSONObjectCreator();
            var myDict = new Dictionary<string, string>
        {
            { "key1", "value1" },
            { "key2", "value2" }
        };
            x.createJSONObject(myDict);


        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Hey i clicked");
            //needs to take the dictionary and spit out a json

            //how to access the textbox values and fill in the textblock with a json string

        }
    }
}
