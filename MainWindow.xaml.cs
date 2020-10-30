using Syncfusion.UI.Xaml.TreeGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.UI.Xaml.Grid;
using System.Windows.Threading;
using Syncfusion.UI.Xaml.Grid.Cells;
using Syncfusion.Windows.Shared;

namespace SfDataGridDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.dataGrid.CellRenderers.Remove("Numeric");
            this.dataGrid.CellRenderers.Add("Numeric", new GridCellNumericRendererExt());
        }

        public class GridCellNumericRendererExt : GridCellNumericRenderer
        {
            public override void OnInitializeEditElement(DataColumnBase dataColumn, DoubleTextBox uiElement, object dataContext)
            {
                base.OnInitializeEditElement(dataColumn, uiElement, dataContext);
                uiElement.TextChanged += UiElement_TextChanged;
            }

            private void UiElement_TextChanged(object sender, TextChangedEventArgs e)
            {
                var doubleTextBox = (sender as DoubleTextBox);
                //while editing change the condition based on value
                if (doubleTextBox.Text != "0.00")
                    doubleTextBox.Background = new SolidColorBrush(Colors.Green);
                else if (doubleTextBox.Text == "0.00")
                    doubleTextBox.Background = new SolidColorBrush(Colors.Red);
            }
        }
    }

    public class CustomValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            //while change background color based on condition
            if (value == null || ((value != null) && double.Parse(value.ToString()) == 0))
                return new SolidColorBrush(Colors.Red);
            return new SolidColorBrush(Colors.Green);

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            throw new NotImplementedException();
        }
    }
}
