using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models;

namespace UI.Controllers
{
    public class TaskController : Controller
    {
        //
        // GET: /Task/

        public ActionResult Index()
        {
            ViewBag.Task = Seed();
            return View();
        }

        public ActionResult Index2()
        {
            var model = Seed();
            return View(model);
        }


        private Task[] Seed()
        {
            List<Responsavel> reposnsaveis = new List<Responsavel>();

            reposnsaveis.Add(new Responsavel() { Nome = "Peter Jackson" });
            reposnsaveis.Add(new Responsavel() { Nome = "Steve Jobs" });
            reposnsaveis.Add(new Responsavel() { Nome = "Linux Trovalds" });

            List<Task> itens = new List<Task>();

            itens.Add(new Task()
            {
                Nome = "Fazer o Kernel"
                ,
                Prioridade = Prioridade.Alta
                ,
                Status = TaskStatus.Aberta
                ,
                Responsavel = reposnsaveis[2]
            });

            itens.Add(new Task()
            {
                Nome = "Roubar a interface do SO"
                ,
                Prioridade = Prioridade.PraOntem
                ,
                Status = TaskStatus.Finalizada
                ,
                Responsavel = reposnsaveis[1]
            });

            itens.Add(new Task()
            {
                Nome = "Forjar o Anel"
                ,
                Prioridade = Prioridade.PraOntem
                ,
                Status = TaskStatus.Execucao
                ,
                Responsavel = reposnsaveis[0]
            });

            itens.Add(new Task()
            {
                Nome = "Task 4"
                ,
                Prioridade = Prioridade.Baixa
                ,
                Status = TaskStatus.Execucao
                ,
                Responsavel = reposnsaveis[2]
            });

            itens.Add(new Task()
            {
                Nome = "Task 5"
                ,
                Prioridade = Prioridade.Normal
                ,
                Status = TaskStatus.Finalizada
                ,
                Responsavel = reposnsaveis[1]
            });



            return itens.ToArray();
        }

    }
}
