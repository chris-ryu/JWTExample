using JWTExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace JWTExample.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }

        public string Message { get; set; }

        public IActionResult OnPostLogin()
        {
            Console.WriteLine("Login");
            string baseUrl = "http://localhost:5243";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            var contentType = new MediaTypeWithQualityHeaderValue ("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);

            User userModel = new User();
            userModel.UserName = "user1";
            userModel.Password = "password1";

            string stringData = JsonConvert.SerializeObject(userModel);
            var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PostAsync ("/api/security/getToken", contentData).Result;
            string stringJWT = response.Content.ReadAsStringAsync().Result;
            JWT jwt = new JWT{ Token = stringJWT } ;

            HttpContext.Session.SetString("token", jwt.Token);

            this.Message = "User logged in successfully!";

            return Page();
        }
    }
}
