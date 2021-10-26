using Domain.Clients.Firebase.Models;
using System.Threading.Tasks;

namespace Domain.Clients.Firebase
{
    public interface IFirebaseClient
    {
        Task<SignUpResponse> SignUpAsync(string email, string password);

        Task<SignInResponse> SignInAsync(string email, string password);
    }
}
