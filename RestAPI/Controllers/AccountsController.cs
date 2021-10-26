using Microsoft.AspNetCore.Mvc;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Controllers
{
    [ApiController]
    [Route("accounts")]
    public class AccountsController : ControllerBase
    {

        private readonly IUserRepository _usersRepository;
        private readonly IAccountRepository _accountsRepository;

        public AccountsController(IUserRepository usersRepository, IAccountRepository accountsRepository)
        {
            _usersRepository = usersRepository;
            _accountsRepository = accountsRepository;
        }

        public async Task<ActionResult<>> NewAccount()
        {

        }
    }
}
