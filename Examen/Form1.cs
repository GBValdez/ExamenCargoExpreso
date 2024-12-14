
using System.Net;
using Examen.Context;
using Examen.products;
using Examen.utils;
using Examen.utils.dto;
using MaterialSkin.Controls;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using project.roles;
using project.users;
using static Examen.utils.materialUI;
namespace Examen
{
    public partial class Form1 : MaterialForm
    {
        private UserManager<userEntity> userManager;
        private RoleManager<rolEntity> roleManagerSvc;
        private IServiceProvider serviceProvider;
        private localStorage localStorageSvc;
        public Form1(
            UserManager<userEntity> userManagerSvc, 
            RoleManager<rolEntity> roleManager, 
            IServiceProvider serviceProviderTemp,
            localStorage local
            )
        {
            InitializeComponent();
            loadMaterial(this);
            userManager = userManagerSvc;
            roleManagerSvc = roleManager;
            serviceProvider = serviceProviderTemp;
            localStorageSvc = local;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async Task<dtoError<userEntity>> validationsLogin()
        {
            string emailWrite = txtEmail.Text;
            string passwordWrite = txtPassword.Text;
            dtoError<userEntity> dtoError = new dtoError<userEntity>();
            if (string.IsNullOrWhiteSpace(emailWrite))
                return dtoError.error("El email es requerido");
            if (string.IsNullOrWhiteSpace(passwordWrite))
                return dtoError.error("La contraseña es requerida");
            userEntity USER_CURRENT = await userManager.FindByEmailAsync(emailWrite);
            if (USER_CURRENT == null)
                return dtoError.error("Credenciales Invalidas");
            if (USER_CURRENT.deleteAt != null)
                return dtoError.error("Credenciales Invalidas");
            bool result = await userManager.CheckPasswordAsync(USER_CURRENT, passwordWrite);
            if (!result) dtoError.error("Credenciales Invalidas");
            return dtoError.success(USER_CURRENT);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Text = "Cargando...";
            dtoError<userEntity> dtoError =await validationsLogin();
            button1.Enabled = true;
            button1.Text = "Iniciar sesion";

            if(dtoError.message != null)
            {
                lb_error.Text = dtoError.message;
                return;
            }

            lb_error.Text = "";
            localStorageSvc.saveData("user", dtoError.data.Id);
            productsView productsView = serviceProvider.GetRequiredService<productsView>();
            productsView.Show();
            this.Hide();
        }

    }
}
