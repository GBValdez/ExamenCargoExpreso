using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.utils;

namespace Examen.Context.Models
{
    public class Product:CommonsModel<long>
    {
        public string name { get; set; }
        public string description { get; set; }
        public float price { get; set; }

        public long brandId { get; set; }
        public Brand brand { get; set; }
        public long catalogueId { get; set; }
        public Catalogue catalogue { get; set; }

    }
}
