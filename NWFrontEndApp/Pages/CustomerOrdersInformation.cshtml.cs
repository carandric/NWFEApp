using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NWCusServiceReference;
using NWFrontEndApp.Utilities;
using System.ServiceModel;
using System.Text.Json;

namespace NWFrontEndApp.Pages
{
    public class CustomerOrdersInformationModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string CustomerID { get; set; }
        public Orders[] orders;

        public async Task OnGetAsync()
        {
            try
            {
                if (!string.IsNullOrEmpty(CustomerID))
                {
                    string customerId = CustomerID;
                    string urlBase = "http://localhost:50611/NWCustomerService.svc/GetOrdersByCustomer";
                    string url = $"{urlBase}/{customerId}";

                    HttpClient client = new HttpClient();
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string data = await response.Content.ReadAsStringAsync();
                        var options = new JsonSerializerOptions
                        {
                            Converters = { new MSDateTimeConverter() }
                        };
                        orders = JsonSerializer.Deserialize<Orders[]>(data, options);
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
