using Microsoft.AspNetCore.Mvc;
using PrimeiroMVC.Models;

namespace PrimeiroMVC.Controllers
{
    public class AlunoController : Controller
    {
        private object listaAlunos;

        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Lorena", "lorena.victor@aluno.senai.br", 121212);
            Aluno a2 = new Aluno(2, "Juliana", "juliana.fulanetto@aluno.senai.br", 909090);
            Aluno a3 = new Aluno(3, "Maysa", "maysa.rondon@aluno.senai.br", 454545);
            Aluno a4 = new Aluno(4, "Matheus", "matheus.dias@aluno.senai.br", 707070);
            Aluno a5 = new Aluno(5, "Mavi", "maria.vitoria@aluno.senai.br", 262626);

            //Criar uma lista de alunos
            List<Aluno> listaAlunos = new List<Aluno>();
            //Adicionar os objetos alunos na lista alunos
            listaAlunos.Add(a1);
            listaAlunos.Add(a2);
            listaAlunos.Add(a3);
            listaAlunos.Add(a4);
            listaAlunos.Add(a5);
            //Enviando a lista de alunos por parametros de view index
            return View(listaAlunos);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}