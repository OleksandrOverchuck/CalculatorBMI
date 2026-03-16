using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BMICalculatorApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private double _height;
    private double _weight;
   
    public MainWindow()
    {
        InitializeComponent();
    }

    private void CalculateButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void ResetButton_Click(object sender, RoutedEventArgs e)
    {
        HeightTextBox.Text = "";
        WeightTextBox.Text = "";

        ResultLabel.Content = "BMI: -";

        _userHeight = 0;
        _userWeight = 0;
    }
}