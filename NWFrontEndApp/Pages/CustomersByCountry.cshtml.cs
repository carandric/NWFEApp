using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NWCusServiceReference;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NWFrontEndApp.Pages
{
    public class CustomersByCountryModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Country { get; set; }

        public Customers[] customers;

        public async Task OnGetAsync()
        {
            try
            {     
                HttpClient client = new HttpClient();
                
                if (!string.IsNullOrEmpty(Country))
                {
                    string countryName = Country;

                    string urlBase = "http://localhost:50611/NWCustomerService.svc/GetCustomersByCountry";
                    string url = $"{urlBase}/{countryName}";

                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string data = await response.Content.ReadAsStringAsync();
                        customers = JsonSerializer.Deserialize<Customers[]>(data);
                    }
                }
                
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
