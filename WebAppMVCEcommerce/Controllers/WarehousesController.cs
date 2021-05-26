using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVCEcommerce.Models.Stock;

namespace WebAppMVCEcommerce.Controllers
{
    public class WarehousesController : Controller
    {
        public ActionResult Novo(NewRegistrationForm form)
        {
            if(ModelState.IsValid)
            {
                return Redirect("warehouse.html");
            }
            else
            {
                var errorMenssages = ModelState.SelectMany(s => s.Value.Errors).Select(e => e.ErrorMessage);

            }
        }

        public class NewRegistrationForm 
        {
            [Required]
            public string DescriptionWarehouse { get; set; }
        }
    }
}
