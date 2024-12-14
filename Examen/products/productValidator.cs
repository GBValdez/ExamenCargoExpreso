using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.Context.Models;
using Examen.utils.FormGeneric;
using FluentValidation;

namespace Examen.products
{
    public class productValidator : formValidator<Product>
    {
        public productValidator()
        {
            RuleFor(x => x.name).NotEmpty().WithMessage("El nombre es requerido");
            RuleFor(x => x.name).MaximumLength(50).WithMessage("El nombre no puede tener mas de 50 caracteres");
            RuleFor(x => x.description).MaximumLength(100).WithMessage("La descripcion no puede tener mas de 100 caracteres");
            RuleFor(x => x.price).NotEmpty().WithMessage("El precio es requerido");
            RuleFor(x => x.price).GreaterThan(0).WithMessage("El precio debe ser mayor a 0");

            RuleFor(x => x.brandId).NotEmpty().WithMessage("La marca es requerida");
            RuleFor(x => x.catalogueId).NotEmpty().WithMessage("El catalogo es requerido");
        }

        public Product setData(TextBox name, TextBox description, NumericUpDown price, long brandId, long catalogueId)
        {
            Product newRegister = new Product();
            newRegister.name = name.Text;
            newRegister.description = description.Text;
            newRegister.price = float.Parse(price.Text);
            newRegister.brandId = brandId;
            newRegister.catalogueId = catalogueId;
            entity = newRegister;
            return acValidate();
        }

    }
}
