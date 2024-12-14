using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.utils.dto
{
    internal class dtoError<t>
    {
        public string? message { get; set; } = null;
        public t? data { get; set; }

        public dtoError<t> error(string message)
        {
            this.message = message;
            return this;
        }

        public dtoError<t> success(t data)
        {
            this.data = data;
            this.message = null;
            return this;
        }
    }
}
