using System;
using CVBonsai.Implementation.ViewController;
using CVBonsai.Implementation.ViewModel;
using CVBonsai.Root.View;
using Xamarin.Forms;

namespace CVBonsai.Implementation.View
{
    public partial class LoginView : ProjectBaseContentPage<LoginViewController, LoginViewModel>
    {
        public LoginView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _ViewController.InputObject;
        }

        protected override void SetSVGCollection()
        {
        }

        public async void On_OnLogin_Event(object sender, EventArgs e)
        {
            await _ViewController.OnLogin();
        }
    }
}


