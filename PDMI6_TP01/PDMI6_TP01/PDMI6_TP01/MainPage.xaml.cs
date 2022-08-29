using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDMI6_TP01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            var ids = id.Text;
            var pass = senha.Text;

            if(ids == "admin" && pass == "@dmin")
                DisplayAlert("LOGADO COM SUCESSO", "", "OK");
            else
                DisplayAlert("LOGIN NÃO AUTORIZADO", "", "OK");
            

        }

         void Limpa(object sender, EventArgs e)
        {

            senha.Text = "";
            id.Text = "";

        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
        }

        async void Contatos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}
