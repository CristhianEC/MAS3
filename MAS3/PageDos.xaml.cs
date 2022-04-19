using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MAS3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDos : ContentPage
    {
        public PageDos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor que recibe parámetros
        /// </summary>
        /// <param name="strUsuario">Usuario</param>
        /// <param name="strPassword">Password</param>
        public PageDos(string strUsuario, string strPassword)
        {
            InitializeComponent();
            LblUsuario.Text = strUsuario;
            LblPassword.Text = strPassword;
        }

    }
}