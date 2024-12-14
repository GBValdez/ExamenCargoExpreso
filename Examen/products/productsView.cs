using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen.Context.Models;
using Examen.utils.Catalogues;
using System.Xml.Linq;
using Examen.utils.Components.Menu;
using Examen.utils.FormGeneric;
using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;
using static Examen.utils.materialUI;
using Examen.Context;
using System.Data.Entity;

namespace Examen.products
{
    public partial class productsView : MaterialForm
    {

        private formGeneric<Product> form;
        private menuPrincipal menuSvc;
        private Brand brand;
        private Catalogue catalogue;
        private ExamenContext context;
        public productsView(formGeneric<Product> formTemp, menuPrincipal menu, ExamenContext db)
        {
            InitializeComponent();
            loadMaterial(this);
            form = formTemp;

            form.load(this);
            form.clearForm = clearForm;
            form.setData = sendData;
            form.saveData = saveData;

            menuSvc = menu;
            context = db;
        }

        private void clearForm()
        {
            txt_name.Text = "";
            txt_description.Text = "";
            txt_price.Text = "";
            combo_brand.SelectedIndex = 0;
            combo_catalog.SelectedIndex = 0;
            form.currentRegister = null;

        }

        private void sendData(Product register)
        {
            txt_name.Text = register.name;
            txt_description.Text = register.description;
            txt_price.Text = register.price.ToString();

            if (combo_brand.DataSource is List<Brand> brands)
            {
                int index = brands.FindIndex(x => x.Id == register.brandId);
                if (index != -1)
                {
                    combo_brand.SelectedIndex = index; 
                }
                else
                {
                    combo_brand.SelectedIndex = -1; 
                }
            }
            else
            {
                combo_brand.SelectedIndex = -1;
            }

            if (combo_catalog.DataSource is List<Catalogue> catalogues)
            {
                int index = catalogues.FindIndex(x => x.Id == register.catalogueId);
                if (index != -1)
                {
                    combo_catalog.SelectedIndex = index; 
                }
                else
                {
                    combo_catalog.SelectedIndex = -1; 
                }
            }
            else
            {
                combo_catalog.SelectedIndex = -1;
            }
        }

        private async void saveData()
        {
            productValidator validator = new productValidator();
            getValues();
            if(brand == null || catalogue == null)
            {
                MessageBox.Show("Debe seleccionar una marca y un catalogo");
                return;
            }
            
            Product register = validator.setData(txt_name, txt_description, txt_price, brand.Id, catalogue.Id);
            await form.save(register);
        }

        private void productsView_Load(object sender, EventArgs e)
        {
            menuSvc.redirect(this);
            form.loadList();
            List<Brand> brands = context.brands.Where(x => x.deleteAt == null).ToList();
            combo_brand.DataSource = brands;
            combo_brand.DisplayMember = "name";
            combo_brand.ValueMember = "Id";

            List<Catalogue> catalogues = context.catalogues.Where(x => x.deleteAt == null).ToList();
            combo_catalog.DataSource = catalogues;
            combo_catalog.DisplayMember = "name";
            combo_catalog.ValueMember = "Id";

            Brand brandTemp = combo_brand.SelectedItem as Brand;
            if (brandTemp != null)
            {
                brand = brandTemp;
            }
            else
            {
                brand = null;
            }

            Catalogue catalogue = combo_catalog.SelectedItem as Catalogue;
            if (catalogue != null)
            {
                this.catalogue = catalogue;
            }
            else
            {
                this.catalogue = null;
            }

        }

        
        private void getValues() {

            Catalogue catalogue = combo_catalog.SelectedItem as Catalogue;
            if (catalogue != null)
            {
                this.catalogue = catalogue;
            }
            else
            {
                this.catalogue = null;
            }

            Brand brandTemp = combo_brand.SelectedItem as Brand;
            if (brandTemp != null)
            {
                brand = brandTemp;
            }
            else
            {
                brand = null;
            }

        }
    }
}
