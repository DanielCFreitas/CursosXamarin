using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.ImagemControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Imagem : ContentPage
    {
        public Imagem()
        {
            InitializeComponent();

            // Imagem01.Source = ImageSource.FromResource("AppGallery.XamarinForms.Controles.ImagemControle.background.jpg");
        }
    }
}