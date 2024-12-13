using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;
using project.utils;

namespace Examen.Context.Models
{
    public class invoice_detail:CommonsModel<long>
    {
           public int amount { get; set; }
           public float discount {  get; set; }
           public float discount_per {  get; set; }
            public long productId { get; set; }
            public Product product { get; set; }
            public long invoice_id { get; set; }
            public Invoice invoice { get; set; }

    
     }
}
