using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FizzBuzzWeb.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;


namespace FizzBuzzWeb.Pages
{
    public class SavedInSessionModel : PageModel
    {
        public List<FizzBuzz> FizzBuzzs { get; set; }
        public void OnGet()
        {
            var data = HttpContext.Session.GetString("Data");
            if (!string.IsNullOrEmpty(data))
            {
                FizzBuzzs = JsonConvert.DeserializeObject<List<FizzBuzz>>(data);
            }

        }
    }
}
