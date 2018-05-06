using System.Threading.Tasks;
using CVBonsai.Implementation.Repository;
using CVBonsai.Implementation.Service;
using CVBonsai.Implementation.ViewModel;
using CVBonsai.Interface.Repository;
using CVBonsai.Interface.Service;
using CVBonsai.Interface.ViewController;
using CVBonsai.Root.ViewController;

namespace CVBonsai.Implementation.ViewController
{
    public class LoginViewController : ProjectBaseViewController<LoginViewModel>, ILoginViewController
    {
        ILoginRepository<LoginViewModel> _Reposetory;
        ILoginService<LoginViewModel> _Service;

        public override void SetRepositories()
        {
            _Service = new LoginService<LoginViewModel>((U, P, C, A) => 
                                                           ExecuteQueryWithReturnTypeAndNetworkAccessAsync<LoginViewModel>(U, P, C, A));
            _Reposetory = new LoginRepository<LoginViewModel>(_MasterRepo, _Service);
        }

        public async Task OnLogin()
        {
            
        }
    }
}