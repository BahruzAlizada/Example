using ExampleMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExampleMVC.Controllers
{
    public class SubjectController : Controller
    {
        private readonly IHttpClientFactory clientFactory;
        public SubjectController(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Chapter(int id)
        {
            var client = clientFactory.CreateClient();
            var responeMessage = await client.GetAsync("https://localhost:7083/api/Subjects/GetSubjectwithChapter/{id}");
            if (responeMessage.IsSuccessStatusCode)
            {
                var jsonData = await responeMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<SubjectWithChapter>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
