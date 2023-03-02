namespace EFTTools.Winform {
    public partial class App : Application {
        public App() {
            AppDomain.CurrentDomain.FirstChanceException += CurrentDomain_FirstChanceException;
            InitializeComponent();

            MainPage = new MainPage();
        }

        private void CurrentDomain_FirstChanceException(object sender, System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs e) {
            System.Diagnostics.Debug.WriteLine($"********************************** UNHANDLED EXCEPTION! Details: {e.Exception}");
            File.AppendAllText("D:\\efttools.log", e.Exception.ToString());
        }
    }
}