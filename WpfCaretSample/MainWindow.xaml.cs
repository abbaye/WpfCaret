using System.Windows;
using System.Windows.Input;
using WpfCaret;

namespace WpfCaretSample
{
    public partial class MainWindow
    {
        readonly Caret _caret = new Caret();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = _caret;

            _caret.MoveCaret(new Point(200, 100));
            _caret.BlinkPeriod = 600;
            _caret.Start();

            MainGrid.Children.Add(_caret);
        }

        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e) => _caret.MoveCaret(e.GetPosition(this));

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _caret.Start();
            _caret.MoveCaret(new Point(200, 100));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) => _caret.Stop();
    }
}
