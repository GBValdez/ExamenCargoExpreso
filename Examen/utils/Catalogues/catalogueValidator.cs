using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.utils.FormGeneric;
using FluentValidation;
using FluentValidation.Results;
using project.utils.catalogue;

namespace Examen.utils.Catalogues
{
    public class catalogueValidator<t>  : formValidator<t>
        where t : CatalogueModel, new()
    {
        public catalogueValidator() { 
            RuleFor(x => x.name).NotEmpty().WithMessage("El nombre es requerido");
            RuleFor(x => x.name).MaximumLength(50).WithMessage("El nombre no puede tener mas de 50 caracteres");
            RuleFor(x => x.description).MaximumLength(100).WithMessage("La descripcion no puede tener mas de 100 caracteres");
        }

        public t setData(TextBox name, TextBox description)
        {
            t catalogue = new t();
            catalogue.name = name.Text;
            catalogue.description = description.Text;
            entity = catalogue;

            return acValidate();
        }
        
    }
}
