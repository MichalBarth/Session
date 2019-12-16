using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SessionDemo.Services;
using SessionDemo.ViewModels;

namespace SessionDemo
{
    public class InsertModel : PageModel
    {
        private readonly DataManipulator dm;

        public InsertModel(DataManipulator dm)
        {
            this.dm = dm;
        }

        [BindProperty]
        public BasketForm BasketForm { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                SessionDemo.Models.Basket basket = new Models.Basket();
                basket.Description = BasketForm.Description;
                basket.Price = BasketForm.Price;
                dm.AddItem(basket);

                dm.SaveData();

                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}