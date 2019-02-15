using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogWeb.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace BlogWeb.Controllers
{
    public class HomeController : Controller
    {
        private IList<Post> lista;

        public HomeController()
        {
            this.lista = new List<Post>()
            {
                new Post() {titulo = "Harry POtter 1", resumo = "Pedra filosofal", categoria = "Filme, livro" },

                new Post() {titulo = "Cassino royale", resumo = "007", categoria = "filme" },

                new Post() { titulo = "New York, New York", resumo = "Romance sobre liderança", categoria = "Livro"}
            };
        }

        public ActionResult Index()
        {
            var lista = new List<Post>();
            string stringConexao = ConfigurationManager.ConnectionStrings["Blog"].ConnectionString;
            //using (SqlConnection cnx = new SqlConnection(stringConexao))
            //{
            //    cnx.Open();
            //    SqlCommand comando = cnx.CreateCommand();
            //    comando.CommandText = "select * from Posts";
            //    SqlDataReader leitor = comando.ExecuteReader();
            //    while (leitor.Read())
            //    {
            //        Post post = new Post()
            //        {
            //            Id = Convert.ToInt32(leitor["id"]),
            //            titulo = Convert.ToString(leitor["titulo"]),
            //            resumo = Convert.ToString(leitor["resumo"]),
            //            categoria = Convert.ToString(leitor["categoria"])
            //        };
            //        lista.Add(post);
            //    }
            //}
            return View(lista);
        }

        public ActionResult NovoPost()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdicionaPost(Post p)
        {
            lista.Add(p);
            return View("Index", lista);
        }
    }
}
// 3.2 ABRINDO A CONEXÃO COM O ADO.NET