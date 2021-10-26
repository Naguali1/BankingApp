using Contracts.Models.Request;
using Contracts.Models.Response;
using Domain.Clients.Firebase;
using Microsoft.AspNetCore.Mvc;
using Persistence.Models;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthController : ControllerBase
    {
        private readonly IFirebaseClient _firebaseClient;
        private readonly IUserRepository _userRepository;

        public AuthController(IFirebaseClient firebaseClient, IUserRepository userRepository)
        {
            _firebaseClient = firebaseClient;
            _userRepository = userRepository;
        }

        [HttpPost]
        [Route("signUp")]
        public async Task<ActionResult<SignUpResponse>> SignUp(SignUpRequest request)
        {
            var user = await _firebaseClient.SignUpAsync(request.Email, request.Password);

            var userReadModel = new UserReadModel
            {
                UserId = Guid.NewGuid(),
                FirebaseId = user.FirebaseId,
                UserName = request.UserName,
                Email = request.Email,
                DateCreated = DateTime.Now
            };

            await _userRepository.SaveOrUpdateAsync(userReadModel);

            return new SignUpResponse
            {
                UserName = userReadModel.UserName,
                Email = userReadModel.Email,
                UserId = userReadModel.UserId,
                DateCreated = userReadModel.DateCreated
            };
        }

        [HttpPost]
        [Route("signIn")]
        public async IActionResult SignIn()
        { 
            
        }
    }
}
