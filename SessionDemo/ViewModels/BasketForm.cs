using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SessionDemo.ViewModels
{
    public class BasketForm
    {
        [Display(Name = "Cena")]
        public decimal Price { get; set; }
    
        [Display(Name = "Popis produktu")]
        public string Description { get; set; }
    }
}
