using System;
using System.Threading.Tasks;
using CorePCL;
using CVBonsai.Implementation.ViewModel;

namespace CVBonsai.Interface.Repository
{
    public interface ILoginRepository<T>
        where T : BaseViewModel
    {
        Task OnLogin(LoginViewModel model, Action<T> completeAction);
    }
}
