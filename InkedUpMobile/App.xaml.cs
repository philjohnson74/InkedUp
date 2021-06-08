using Adapters;
using StorageSqlite;
using UseCasesShared.Interfaces.Storage;
using Xamarin.Forms;

namespace InkedUpMobile
{
    public partial class App : Application
    {
        public static IPenCollectorAdapter PenCollectorAdapter { get; set; }

        public App(string databaseLocation)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            IStorage storage = new SqliteRepository(databaseLocation);
            PenCollectorAdapter = new PenCollectorAdapter(storage);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
