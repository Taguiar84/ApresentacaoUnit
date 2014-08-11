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
            var model = Seed();
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var model = Seed().Where(it => it.Id == id).First();            
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Task model)
        {
            return RedirectToAction("Index");
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
                Id = 1,
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
                Id = 2,
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
                Id = 3,
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
                Id = 4,
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
                Id = 5,
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
