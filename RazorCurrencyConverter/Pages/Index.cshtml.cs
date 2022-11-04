using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;


namespace RazorCurrencyConverter.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
               
        public string? Amount { get; set; }
        public const double RATE = 1.15;
        public void OnGet()
        {
            
        }
        double result;

        public void OnPost()
        {
            if (!String.IsNullOrWhiteSpace(Amount))
            {
                result = Convert.ToDouble(Amount) * RATE;
                ViewData["Message"] = $"{Amount} ==> GBP is {result.ToString("0.00")} ==> EUR ";
            }
          
        }
    }
}