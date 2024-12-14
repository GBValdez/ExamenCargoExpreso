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
using Examen.utils.Components.Menu;
using Examen.utils.FormGeneric;
using MaterialSkin.Controls;
using static Examen.utils.materialUI;

namespace Examen.catalogueFIle
{
    public partial class catalogueView : MaterialForm
    {
        private formGeneric<Catalogue> form;
        private menuPrincipal menuSvc;
        public catalogueView(formGeneric<Catalogue> formTemp, menuPrincipal menu)
       {
            InitializeComponent();
            loadMaterial(this);
            form = formTemp;

            form.load(this);
            form.clearForm = clearForm;
            form.setData = sendData;
            form.saveData = saveData;

            menuSvc = menu;
        }

        private void clearForm()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            form.currentRegister = null;

        }

        private void sendData(Catalogue catalogue)
        {
            txtName.Text = catalogue.name;
            txtDescription.Text = catalogue.description;
        }

        private async void saveData()
        {
            catalogueValidator<Catalogue> validator = new catalogueValidator<Catalogue>();
            Catalogue register = validator.setData(txtName, txtDescription);
            await form.save(register);
        }

        private void catalogueView_Load(object sender, EventArgs e)
        {
            menuSvc.redirect(this);
            form.loadList();

        }
    }
}
