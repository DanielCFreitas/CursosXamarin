using Xamarin.Forms;

namespace AppGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            /**
             * NavigationPage
             * */
            // MainPage = new NavigationPage(new Conteudo01());  


            /**
             *  Modal
             * */
            // MainPage = new XamarinForms.Paginas.Modal.Conteudo01();


            /**
             *  Carousel 
             * */
            // VIA C#
            //var carousel = new CarouselPage();
            //carousel.Children.Add(new Conteudo01());
            //carousel.Children.Add(new Conteudo02());
            //carousel.Children.Add(new Conteudo03());
            //carousel.CurrentPage = carousel.Children[1];
            // VIA XAML
            //MainPage = new XamarinForms.Paginas.PaginaDeCarrossel.Carousel();

            /**
             *  TabPage
             */
            //MainPage = new XamarinForms.Paginas.PaginaDeAbas.Abas();


            /**
             *   Master Detail Page
             */
            // VIA C#
            //var pagina = new MasterDetailPage();
            //pagina.Master =  ;// MENU
            //pagina.Detail =  new Conteudo01();// CONTEUDO
            //MainPage = pagina;
            // VIA XAML
            //MainPage = new XamarinForms.Paginas.PaginaDeMenuLateral.PaginaComMenuLateral();


            MainPage = new AppBase.Menu();
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
