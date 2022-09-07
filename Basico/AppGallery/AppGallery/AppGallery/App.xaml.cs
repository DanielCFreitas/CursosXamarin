﻿using AppGallery.XamarinForms.Paginas.PaginaDeCarrossel;
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
            //var carousel = new CarouselPage();
            //carousel.Children.Add(new Conteudo01());
            //carousel.Children.Add(new Conteudo02());
            //carousel.Children.Add(new Conteudo03());
            //carousel.CurrentPage = carousel.Children[1];
            MainPage = new XamarinForms.Paginas.PaginaDeCarrossel.Carousel();


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
