using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.CampoDeEntradaSimplesControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CampoDeEntradaSimples : ContentPage
    {
        public CampoDeEntradaSimples()
        {
            InitializeComponent();
        }

        private void Entry_Focused(object sender, FocusEventArgs e)
        {
            lblFocus.Text = "Campo focado!";
        }

        private void Entry_Unfocused(object sender, FocusEventArgs e)
        {
            lblFocus.Text = "Foco removido do campo!";
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblTextChanged.Text = e.NewTextValue + " - " + e.NewTextValue.Length;
        }

        private void Entry_Completed(object sender, System.EventArgs e)
        {
            lblComplete.Text = "Preenchimento finalizado!";
        }
    }
}