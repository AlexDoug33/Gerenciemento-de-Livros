using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciemento_de_Livros
{
    public class Usuarios
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Email { get; set; }

        public List<Usuarios> Usuario { get; set; } = new List<Usuarios>();

        public void RegistroUsuario()
        {
            Console.WriteLine("----  Registro de Usuario ----");

            Console.WriteLine("Informe o nome do usuário: ");
            var nome = Console.ReadLine();

            if (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Nenhum resultado encontrado! digite um nome valido: ");
            }

            Console.WriteLine("Informe o nome do usuário: ");
            var email = Console.ReadLine();
           
            if (string.IsNullOrEmpty(email))
            {
                Console.WriteLine("Nenhum resultado encontrado! digite um email valido: ");
            }

            Usuarios usuario = new()
            {
                Id = Id,
                Nome = nome,
                Email = email,
            };

            Usuario.Add(usuario);

            Console.WriteLine($"Usuário cadastrado com sucesso!! ID: {usuario.Id}, Nome: {usuario.Nome}, E-mail: {usuario.Email}");
        }
    }
}
