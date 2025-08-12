using LibCommons.DTOs;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCommons.Client
{  
    public class LogInClient
    {
        private Uri uri = new Uri("");
        private HttpClient _client;
        private HttpResponseMessage _response;

        public LogInClient()
        {
            _client = new HttpClient();
            _client.BaseAddress = uri;
        }


        public async Task<UserDTO> GetUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDTO> FindUser(string userEmail)
        {
            throw new NotImplementedException();
        }
    }
}
