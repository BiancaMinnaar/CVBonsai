using System;
using System.Threading.Tasks;
using CorePCL;
using CVBonsai.Implementation.ViewModel;
using CVBonsai.Interface.Repository;
using CVBonsai.Interface.Service;
using CVBonsai.Root.Repository;

namespace CVBonsai.Implementation.Repository
{
    public class LoginRepository<T> : ProjectBaseRepository, ILoginRepository<T>
        where T : BaseViewModel
    {
        ILoginService<T> _Service;

        public LoginRepository(IMasterRepository masterRepository, ILoginService<T> service)
            : base(masterRepository)
        {
            _Service = service;
        }

        public async Task OnLogin(LoginViewModel model, Action<T> completeAction)
        {
            var serviceReturnModel = await _Service.OnLogin(model);
            completeAction(serviceReturnModel);
        }
    }
}