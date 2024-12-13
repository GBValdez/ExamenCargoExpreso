using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.utils;

namespace Examen.Context.Models
{
    public class Invoice: CommonsModel<long>
    {
        public string serie {  get; set; }
        public string docNum { get; set; }
        public string authNum {  get; set; }
        public long clientId { get; set; }
        public Client client { get; set; }
    }
}
