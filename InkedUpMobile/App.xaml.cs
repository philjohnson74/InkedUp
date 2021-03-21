using System;
using Interactors;
using StorageSqlite;
using UseCasesShared.Interfaces.Storage;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InkedUpMobile
{
    public partial class App : Application
    {
        public static IPenCollectorInteractor PenCollectorInteractor { get; set; }

        public App(string databaseLocation)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            IStorage storage = new SqliteRepository(databaseLocation);
            PenCollectorInteractor = new PenCollectorInteractor(storage);
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
