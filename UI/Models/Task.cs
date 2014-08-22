using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UI.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name="Nome")]
        public string Nome { get; set; }



        [Display(Name = "Data de Inicio")]
        public DateTime? DataInicio { get; set; }
        [UIHint("Date")]
        public DateTime? DataFim { get; set; }

        [Required]
        public TaskStatus Status { get; set; }
        public Responsavel Responsavel { get; set; }

        public Prioridade Prioridade { get; set; }
    }


    //[Default]
    public enum TaskStatus
    {
        Aberta,
        [Display(Name="Execução")]
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


    public class TaskDbContextFake : DbContext
    {
        public DbSet<Task> Task { get; set; }
    }

}