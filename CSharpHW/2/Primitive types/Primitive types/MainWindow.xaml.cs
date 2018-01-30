using System.Globalization;
using System.Windows.Controls;

namespace Primitive_types
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (listBox.SelectedItem as ListBoxItem);

            switch(selectedItem?.Content.ToString())
            {
                case "SByte":
                    maxValueText.Text = sbyte.MaxValue.ToString();
                    minValueText.Text = sbyte.MinValue.ToString();
                    defaultValueText.Text = default(sbyte).ToString();
                    break;
                case "Int16":
                    maxValueText.Text = short.MaxValue.ToString();
                    minValueText.Text = short.MinValue.ToString();
                    defaultValueText.Text = default(short).ToString();
                    break;
                case "Int32":
                    maxValueText.Text = int.MaxValue.ToString();
                    minValueText.Text = int.MinValue.ToString();
                    defaultValueText.Text = default(int).ToString();
                    break;
                case "Int64":
                    maxValueText.Text = long.MaxValue.ToString();
                    minValueText.Text = long.MinValue.ToString();
                    defaultValueText.Text = default(long).ToString();
                    break;
                case "Byte":
                    maxValueText.Text = byte.MaxValue.ToString();
                    minValueText.Text = byte.MinValue.ToString();
                    defaultValueText.Text = default(byte).ToString();
                    break;
                case "UInt16":
                    maxValueText.Text = ushort.MaxValue.ToString();
                    minValueText.Text = ushort.MinValue.ToString();
                    defaultValueText.Text = default(ushort).ToString();
                    break;
                case "UInt32":
                    maxValueText.Text = uint.MaxValue.ToString();
                    minValueText.Text = uint.MinValue.ToString();
                    defaultValueText.Text = default(uint).ToString();
                    break;
                case "UInt64":
                    maxValueText.Text = ulong.MaxValue.ToString();
                    minValueText.Text = ulong.MinValue.ToString();
                    defaultValueText.Text = default(ulong).ToString();
                    break;
                case "Float":
                    maxValueText.Text = float.MaxValue.ToString(CultureInfo.CurrentCulture);
                    minValueText.Text = float.MinValue.ToString(CultureInfo.CurrentCulture);
                    defaultValueText.Text = default(float).ToString(CultureInfo.CurrentCulture);
                    break;
                case "Double":
                    maxValueText.Text = double.MaxValue.ToString(CultureInfo.CurrentCulture);
                    minValueText.Text = double.MinValue.ToString(CultureInfo.CurrentCulture);
                    defaultValueText.Text = default(double).ToString(CultureInfo.CurrentCulture);
                    break;
                case "Decimal":
                    maxValueText.Text = decimal.MaxValue.ToString(CultureInfo.CurrentCulture);
                    minValueText.Text = decimal.MinValue.ToString(CultureInfo.CurrentCulture);
                    defaultValueText.Text = default(decimal).ToString(CultureInfo.CurrentCulture);
                    break;
            }
        }        
    }
}
