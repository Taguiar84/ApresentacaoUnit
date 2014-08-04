using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Models
{
    public class Task
    {
        public string Nome { get; set; }

        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public TaskStatus Status { get; set; }
        public Responsavel Responsavel { get; set; }

        public Prioridade Prioridade { get; set; }
    }


    //[Default]
    public enum TaskStatus
    {
        Aberta,
        Execucao,
        Finalizada
    }

    public enum Prioridade
    {
        Baixa,
        Normal,
        Alta,
        PraOntem
    }




    public class Responsavel
    {
        public string Nome { get; set; }
    }

}