using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Paginas.PaginaDeMenuLateral
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaComMenuLateral : MasterDetailPage
    {
        public PaginaComMenuLateral()
        {
            InitializeComponent();
        }

        private void AbrirPagina01(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Conteudo01());
            IsPresented = false;
        }

        private void AbrirPagina02(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Conteudo02());
            IsPresented = false;
        }

        private void AbrirPagina03(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Conteudo03());
            IsPresented = false;
        }
    }
}