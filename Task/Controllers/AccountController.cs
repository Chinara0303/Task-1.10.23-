using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Controllers
{
    internal class AccountController
    {
        private readonly IAccountService _service;
        public AccountController() => _service = new AccountService();
        public void Register()
        {
            Console.WriteLine(_service.Register("chinara","Chinara123", "chinarae88i@code.edu.az"));
        }
    }
}
