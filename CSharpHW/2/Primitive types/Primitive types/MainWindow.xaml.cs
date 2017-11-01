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

namespace Primitive_types
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (listBox.SelectedItem as ListBoxItem);

            switch(selectedItem.Content.ToString())
            {
                case "SByte":
                    maxValueText.Text = sbyte.MaxValue.ToString();
                    minValueText.Text = sbyte.MinValue.ToString();
                    defaultValueText.Text = "0";
                    break;
                case "Int16":
                    maxValueText.Text = short.MaxValue.ToString();
                    minValueText.Text = short.MinValue.ToString();
                    defaultValueText.Text = "0";
                    break;
                case "Int32":
                    maxValueText.Text = int.MaxValue.ToString();
                    minValueText.Text = int.MinValue.ToString();
                    defaultValueText.Text = "0";
                    break;
                case "Int64":
                    maxValueText.Text = long.MaxValue.ToString();
                    minValueText.Text = long.MinValue.ToString();
                    defaultValueText.Text = "0";
                    break;
                case "Byte":
                    maxValueText.Text = byte.MaxValue.ToString();
                    minValueText.Text = byte.MinValue.ToString();
                    defaultValueText.Text = "0";
                    break;
                case "UInt16":
                    maxValueText.Text = ushort.MaxValue.ToString();
                    minValueText.Text = ushort.MinValue.ToString();
                    defaultValueText.Text = "0";
                    break;
                case "UInt32":
                    maxValueText.Text = uint.MaxValue.ToString();
                    minValueText.Text = uint.MinValue.ToString();
                    defaultValueText.Text = "0";
                    break;
                case "UInt64":
                    maxValueText.Text = ulong.MaxValue.ToString();
                    minValueText.Text = ulong.MinValue.ToString();
                    defaultValueText.Text = "0";
                    break;
                case "Float":
                    maxValueText.Text = float.MaxValue.ToString();
                    minValueText.Text = float.MinValue.ToString();
                    defaultValueText.Text = "0.0";
                    break;
                case "Double":
                    maxValueText.Text = double.MaxValue.ToString();
                    minValueText.Text = double.MinValue.ToString();
                    defaultValueText.Text = "0.0";
                    break;
                case "Decimal":
                    maxValueText.Text = decimal.MaxValue.ToString();
                    minValueText.Text = decimal.MinValue.ToString();
                    defaultValueText.Text = "0.0";
                    break;
            }
        }        
    }
}
