using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen.brands;
using Examen.catalogueFIle;
using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;

namespace Examen.utils.Components.Menu
{
    public class menuPrincipal
    {
        private MaterialForm form;
        private IServiceProvider provider;
        private localStorage localStorageSvc;
        public void redirect(MaterialForm formTemp)
        {
            if(localStorageSvc.get("user") == null)
            {
                Application.Exit();
            }

            this.form = formTemp;
            MenuStrip menuStrip = new MenuStrip();

            var ingresoMenu = new ToolStripMenuItem("Ingreso");
            ingresoMenu.DropDownItems.Add("Facturas", null, invoiceClick);
            ingresoMenu.DropDownItems.Add("Productos", null, productClick);
            ingresoMenu.DropDownItems.Add("Marcas", null, brandClick);
            ingresoMenu.DropDownItems.Add("Catalogo", null, catalogClick);

            var reportesMenu = new ToolStripMenuItem("Reportes");
            reportesMenu.Click += reportesClick;
            var mantenimientoMenu = new ToolStripMenuItem("Mantenimiento");
            mantenimientoMenu.Click += mantenimientoClick;
            var exitMenu = new ToolStripMenuItem("Salida");
            exitMenu.Click += exitClick;

            menuStrip.Items.Add(ingresoMenu);
            menuStrip.Items.Add(reportesMenu);
            menuStrip.Items.Add(mantenimientoMenu);
            menuStrip.Items.Add(exitMenu);
            formTemp.Controls.Add(menuStrip);
        }

        public menuPrincipal(IServiceProvider serviceProvider,localStorage local)
        {
            provider = serviceProvider;
            localStorageSvc = local;
        }



        public void invoiceClick(object sender, EventArgs e)
        {
            MessageBox.Show("Facturas");
        }

        public void productClick(object sender, EventArgs e)
        {
            MessageBox.Show("Productos");
        }

        public void brandClick(object sender, EventArgs e)
        {
            this.form.Hide();
            brandsView brandsViewTemp = provider.GetRequiredService<brandsView>();
            brandsViewTemp.Show();

        }

        public void catalogClick(object sender, EventArgs e)
        {
            this.form.Hide();
            catalogueView catalogueViewTemp = provider.GetRequiredService<catalogueView>();
            catalogueViewTemp.Show();
        }

        public void exitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void reportesClick(object sender, EventArgs e)
        {
            MessageBox.Show("Reportes");
        }

        public void mantenimientoClick(object sender, EventArgs e)
        {
            MessageBox.Show("Mantenimiento");
        }



    }
}
