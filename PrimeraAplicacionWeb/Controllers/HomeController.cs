using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrimeraAplicacionWeb.Models;
using PrimeraAplicacionWeb;
using MySql.Data.MySqlClient;
using System.Data;

namespace PrimeraAplicacionWeb.Controllers
{
    public class HomeController : Controller
    {
        //Crear coneccion
    
         MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=crud_asp;password='';SslMode=none");
         

         public void Crear(string nombreUsuario, string emailUsuario, string idUsuario)
         {
            Usuario user = new Usuario(idUsuario, nombreUsuario, emailUsuario);
            ViewBag.Titulo = "Agregar Usuarios";

            ViewBag.NombreUsuario = user.nombre;
            ViewBag.EmailUsuario = user.email;
            ViewBag.IdUsuario = user.id;


            ViewBag.UsuarioInfo = user.ToString();

          
            if (idUsuario != null)
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into usuarios values(" + user.id + ",'" + user.nombre + "','" + user.email + "')";
                cmd.ExecuteNonQuery();
                con.Close();
            }
           
        }

 

      //  [HttpPost]
        public ActionResult Index( string nombreUsuario,string emailUsuario, string idUsuario)
        {

            Crear(nombreUsuario, emailUsuario, idUsuario);
            return View();
            
        }

      

    }
}