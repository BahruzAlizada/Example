using ExampleMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExampleMVC.ViewComponents
{
    public class SubjectViewComponent : ViewComponent
    {
        private readonly IHttpClientFactory clientFactory;
        public SubjectViewComponent(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = clientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7083/api/Subjects/GetSubjects");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<SubjectModel>>(jsonData);
                values = values.Where(x => x.Status).ToList();
                return View(values);
            }
            return View();
        }
    }
}
