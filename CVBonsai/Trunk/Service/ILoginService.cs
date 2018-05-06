using System.Threading.Tasks;
using CorePCL;
using CVBonsai.Implementation.ViewModel;

namespace CVBonsai.Interface.Service
{
    public interface ILoginService<T>
        where T : BaseViewModel
    {
        Task<T> OnLogin(LoginViewModel model);
    }
}

