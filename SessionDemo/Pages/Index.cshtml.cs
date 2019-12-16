using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SessionDemo.Services;

namespace SessionDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly DataManipulator dm;

        public IndexModel(DataManipulator dm)
        {
            this.dm = dm;
        }

        public List<SessionDemo.Models.Basket> AllItems { get; set; }

        public void OnGet()
        {
            dm.LoadData();
            AllItems = new List<Models.Basket>();
            foreach (var item in dm)
            {
                AllItems.Add(item);
            }
        }
    }
}
