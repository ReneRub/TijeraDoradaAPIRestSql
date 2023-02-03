using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.Contracts.Dtos.Request;
using TD.Contracts.Dtos.Response;
using TD.Core.Abstraction.Services;
using TD.Infrastructure.Abstraction.Repositories;

namespace TD.Core.Services
{
    public  class LoginService : ILoginService
    {
        private readonly ILogger<EmployeeService> logger;
        private readonly IMapper mapper;
        private readonly ILoginRepository loginRepository;

        public LoginService(ILogger<EmployeeService> logger, IMapper mapper, ILoginRepository loginRepository)
        {
            this.logger = logger;   
            this.mapper = mapper;
            this.loginRepository = loginRepository;
        }

        /// <summary>
        /// Gets the Access to Application
        /// </summary>
        public async Task<List<LoginResponseDto>> GetAccess(LoginRequestDto Credentials)
        {
            var employees = await loginRepository
                .GetAccessLogin(Credentials)
                .ConfigureAwait(false);

            return employees;
        }
    }
}
