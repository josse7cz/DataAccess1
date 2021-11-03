using DataAccess.Model;
using DataAccess1.Interface;
using DataAccess1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DataAccess.Model
{
    public class Item:IEntity

    {

        public virtual int Id { get; set; }
        [Required(ErrorMessage ="Název je vyžadován")]//validace dat
        public virtual string Name { get; set; }
        [Required(ErrorMessage = "Producent je vyžadován")]
        public virtual string Producer { get; set; }
        [Required(ErrorMessage = "Rok je vyžadován")]
        [Range(2000, 2050, ErrorMessage = "Rozsah není 2000-2050")]
        public virtual int YearProduct { get; set; }

        [Required(ErrorMessage = "Cena je vyžadována")]
        public virtual int Price { get; set; }
        [Required(ErrorMessage = "Producent je vyžadován")]
        [Range (1,2000,ErrorMessage = "Rozsah není od 1 do 2000")]
        public virtual int Quantity { get; set; }

       [AllowHtml]//pro zachovani HTML je treba pridat system.mvc zavislst
        public virtual string Description { get; set; }

        public virtual string ImageName { get; set; }

        public virtual ItemCategory Category { get; set; }

    }
}
