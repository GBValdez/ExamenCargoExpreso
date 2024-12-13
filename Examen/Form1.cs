
using System.Net;
using Examen.Context;
using MaterialSkin.Controls;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using project.roles;
using project.users;
using project.utils.dto;
using static Examen.utils.materialUI;
namespace Examen
{
    public partial class Form1 : MaterialForm
    {
        private UserManager<userEntity> userManager;
        private RoleManager<rolEntity> roleManagerSvc;
        public Form1(UserManager<userEntity> userManagerSvc, RoleManager<rolEntity> roleManager)
        {
            InitializeComponent();
            loadMaterial(this);
            userManager = userManagerSvc;
            roleManagerSvc = roleManager;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async Task<string> validationsLogin()
        {
            string emailWrite = txtEmail.Text;
            string passwordWrite = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(emailWrite))
                return "El correo es requerido";
            if (string.IsNullOrWhiteSpace(passwordWrite))
                return "La contraseña es requerida";

            userEntity EMAIL = await userManager.FindByEmailAsync(emailWrite);
            if (EMAIL == null)
                return "Credenciales Invalidas";
            //if (await userManager.IsEmailConfirmedAsync(EMAIL) == false)
            //    return "Credenciales Invalidas";
            if (EMAIL.deleteAt != null)
                return "Credenciales invalidas";
            bool result = await userManager.CheckPasswordAsync(EMAIL, passwordWrite);
            if (!result) return "Credenciales Invalidas";
            return "Success";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Text = "Cargando...";
            lb_error.Text=await validationsLogin();
            button1.Enabled = true;
            button1.Text = "Iniciar sesion";

            if (lb_error.Text== "Success")
            {
                lb_error.Text = "Logueado";
            }
        }

    }
}
