using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;
using FluentValidation;

namespace Examen.utils.FormGeneric
{
    public abstract class formValidator<t> : AbstractValidator<t>
        where t : class, new()
    {
        protected t entity;
        public t acValidate()
        {        
            var validator = this.Validate(entity);
            IList<ValidationFailure> failures = validator.Errors;
            if (!validator.IsValid)
            {
                foreach (ValidationFailure failure in failures)
                {
                    MessageBox.Show(failure.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
            }
            return entity;
        }
    }
}
