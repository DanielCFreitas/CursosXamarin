using AppGallery.XamarinForms.Paginas.PaginaDeNavegacao;
using Xamarin.Forms;

namespace AppGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var pagina = new NavigationPage(new Conteudo01());
            MainPage = pagina;
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
