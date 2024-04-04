using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciemento_de_Livros
{
    public class Emprestimo
    {
        public Guid Id { get; set; }
        public Guid IdUsuario { get; set; }
        public Guid IdLivro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataRetorno { get; set; }

        public void RegistroEmprestimo(Guid usuarioId, Guid livroId)
        {
            Console.WriteLine("Resgistre a data de retirada do livro:");

            Console.Write("Dia: ");
            int dia;

            while (!int.TryParse(Console.ReadLine(), out dia) || dia < 1 || dia > 31)
            {
                Console.WriteLine("Dia inexistente, por favor digite novamente.");
            }

            Console.WriteLine("Mês: ");
            int mes;
            while (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12)
            {
                Console.WriteLine("Mês inexistente, por favor digite novamente.");
            }

            Console.Write("Ano: ");
            int ano;
            while (!int.TryParse(Console.ReadLine(), out ano))
            {
                Console.WriteLine("Ano inexistente, por favor digite novamente.");
            }

            DateTime dataEmprestimo = new DateTime(ano, mes, dia);
            DataRetorno = dataEmprestimo.AddDays(5);

            Emprestimo emprestimo = new()
            {
                Id = Guid.NewGuid(),
                IdUsuario = usuarioId,
                IdLivro = livroId,
                DataEmprestimo = dataEmprestimo,
            };

            Console.WriteLine($"Empréstimo registrado com sucesso ID: {emprestimo.Id}, Usuário: {emprestimo.IdUsuario}, Livro: {emprestimo.IdLivro}, Data de Retirada: {emprestimo.DataEmprestimo}, Data de Devolução: {DataRetorno}");
        }

        public void DevolucaoLivro()
        {

            Console.WriteLine("Registre o livro a ser devolvido");

            Console.Write("Dia: ");
            int dia;
            while (!int.TryParse(Console.ReadLine(), out dia) || dia < 1 || dia > 31)
            {
                Console.WriteLine("Dia inexistente, por favor digite novamente.");
            }

            Console.Write("Mês: ");
            int mes;
            while (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12)
            {
                Console.WriteLine("Mês inexistente, por favor digite novamente.");
            }

            Console.Write("Ano: ");
            int ano;
            while (!int.TryParse(Console.ReadLine(), out ano))
            {
                Console.WriteLine("Ano inexistente, por favor digite novamente.");
            }

            DateTime dataRetorno = new(ano, mes, dia);

            int diasAtraso = (int)(dataRetorno - dataRetorno!).TotalDays;

            if (diasAtraso > 0)
            {
                Console.WriteLine($"Devolução com {diasAtraso} dia(s) de atraso.");
            }
            else
            {
                Console.WriteLine("Devolução realizada em dia.");
            }
        }
    }
}
