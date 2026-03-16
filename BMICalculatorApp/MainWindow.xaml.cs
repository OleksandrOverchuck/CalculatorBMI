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
    private double _userHeight;
    private double _userWeight;
    private double _bmi;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void CalculateButton_Click(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(HeightTextBox.Text, out double h) &&
              double.TryParse(WeightTextBox.Text, out double w))
        {
            _userHeight = h;
            _userWeight = w;

            double heightInMeters = _userHeight / 100.0;
            _bmi = _userWeight / (heightInMeters * heightInMeters);

            ResultLabel.Content = $"BMI: {Math.Round(_bmi, 2)}";
        }
        else
        {
            MessageBox.Show("Proszę wprowadzić poprawne wartości liczbowe.");
        }
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