using System.Windows;
namespace Baseball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly BaseballSimulator baseballSimulator;
            public MainWindow()
        {
            InitializeComponent();

            DataContext = baseballSimulator = new();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            baseballSimulator.PlayBall();
        }
    }
}
