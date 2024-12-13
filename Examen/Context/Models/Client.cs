using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.utils;

namespace Examen.Context.Models
{
    public class Client:CommonsModel<long>
    {
        public string nit {  get; set; }
        public string dpi { get; set; }
        public string name { get; set; }
        public string address {  get; set; }
    }
}
