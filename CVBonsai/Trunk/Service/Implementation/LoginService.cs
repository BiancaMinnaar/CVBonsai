using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CorePCL;
using CVBonsai.Implementation.ViewModel;
using CVBonsai.Interface.Service;

namespace CVBonsai.Implementation.Service
{
        public class LoginService<T> : BaseService<T>, ILoginService<T>
            where T : BaseViewModel
        {
            public LoginService(Func<string, Dictionary<string, ParameterTypedValue>, BaseViewModel, BaseNetworkAccessEnum, Task<T>> networkInterface)
                :base(networkInterface)
            {
            }

        public async Task<T> OnLogin(LoginViewModel model)
        {
            string requestURL = "/path/{Parameter}";
            var httpMethod = BaseNetworkAccessEnum.Get;
            var parameters = new Dictionary<string, ParameterTypedValue>()
            {
                //{"Parameter", model.Property},
            };
            return await _NetworkInterface(requestURL, parameters, null, httpMethod);
        }
    }
}
