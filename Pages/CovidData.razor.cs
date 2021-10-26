using CovidBlazorWasm.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CovidBlazorWasm.Pages
{
    public partial class CovidData : ComponentBase
    {
        [Inject]
        protected HttpClient Http { get; set; }

        protected USCurrentCovidData usCurrentCovidData;

        private string covidActNowAPIKey = "69021268a9e04f0fae0953b20e78a575";

        protected override async Task OnInitializedAsync()
        {

            string url = $"https://api.covidactnow.org/v2/country/US.json?apiKey={covidActNowAPIKey}";
            //usCurrentItems = await Http.GetFromJsonAsync<UsCurrentItem[]>("https://api.covidtracking.com/v1/us/current.json");
            usCurrentCovidData = await Http.GetFromJsonAsync<USCurrentCovidData>(url);
            Console.WriteLine(usCurrentCovidData.actuals.cases);
        }
    }
}
