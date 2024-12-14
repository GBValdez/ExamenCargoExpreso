using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen.Context;
using Examen.Context.Models;
using Examen.utils.Catalogues;
using Examen.utils.Components.Menu;
using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;
using project.utils.catalogue;
using static Examen.utils.materialUI;

namespace Examen.brands
{
    public partial class brandsView : MaterialForm
    {
        private ExamenContext db = new ExamenContext();
        private IServiceProvider provider;
        private Brand currentRegister;
        public brandsView(ExamenContext context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            loadMaterial(this);
            db = context;
            provider = serviceProvider;
        }

        private async void brandsView_Load(object sender, EventArgs e)
        {
            menuPrincipal menu = provider.GetRequiredService<menuPrincipal>();
            menu.redirect(this);
            this.loadList();

        }

        private void loadList()
        {
            dataGriwList.DataSource = db.brands.Where(x => x.deleteAt == null).ToList();
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            catalogueValidator<Brand> validator = new catalogueValidator<Brand>();
            Brand brand = validator.setData(txtName, txtDescription);
            if (brand == null) return;
            if (currentRegister != null) {
                Brand registerTemp = await db.brands.FindAsync(currentRegister.Id);
                if (registerTemp == null)
                {
                    MessageBox.Show("Registro no encontrado");
                    return;
                }
                registerTemp.name = brand.name;
                registerTemp.description = brand.description;
            }
            else
            {
                await db.Set<Brand>().AddAsync(brand);
            }

            await db.SaveChangesAsync();

            MessageBox.Show("Registro guardado");
            loadList();
            clearForm();
        }

        private void clearForm()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            currentRegister = null;
        }

        private void setData(Brand brand)
        {
            txtName.Text = brand.name;
            txtDescription.Text = brand.description;
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (currentRegister == null)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }
            Brand brand = await db.brands.FindAsync(currentRegister.Id);
            if (brand == null)
            {
                MessageBox.Show("Registro no encontrado");
                return;
            }
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este registro?", 
                "Confirmación", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question); 

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                brand.deleteAt = DateTime.UtcNow;
                await db.SaveChangesAsync();
                loadList();
                MessageBox.Show("El registro ha sido eliminado.");
            }
            clearForm();
        }

        private void dataGriwList_Click(object sender, EventArgs e)
        {
            if (dataGriwList.SelectedRows.Count > 0)
            {
                int selectedRow = dataGriwList.SelectedRows[0].Index;
                currentRegister = (Brand)dataGriwList.Rows[selectedRow].DataBoundItem;
                setData(currentRegister);
            }
        }
    }
}
