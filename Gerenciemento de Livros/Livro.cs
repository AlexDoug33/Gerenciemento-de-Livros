namespace Gerenciemento_de_Livros
{
    public class Livro
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Autor { get; set; }

        public string Titulo { get; set; }

        public string ISBN { get; set; }

        public string AnoPublicacao { get; set; }

        public List<Livro> Livros { get; set; } = new List<Livro>();

        public void RegistroLivro()
        {
            Console.WriteLine("Cadastro do Livro\n");

            Console.WriteLine("Digite o Título:");
            var titulo = Console.ReadLine();

            if (string.IsNullOrEmpty(Titulo))
            {
                Console.WriteLine("Título vazio, por favor digite um título válido.");
                titulo = Console.ReadLine();
            }

            Console.WriteLine("Digite o nome do Autor:");
            var autor = Console.ReadLine();

            if (string.IsNullOrEmpty(Autor))
            {
                Console.WriteLine("Autor vazio, por favor digite um Autor válido.");
                autor = Console.ReadLine();
            }

            Console.WriteLine("Digite a ISBN do livro:");
            var iSBN = Console.ReadLine();

            if (string.IsNullOrEmpty(iSBN))
            {
                Console.WriteLine("ISBN vazia, por favir digite uma ISBN válida.");
                iSBN = Console.ReadLine();
            }

            Console.WriteLine("Digite o ano da publicação:");
            var anoPublicacao = Console.ReadLine();

            int anoProcurado;
            while (!int.TryParse(anoPublicacao, out anoProcurado) || anoProcurado < 0)
            {
                Console.WriteLine("Ano inválido, por favor digite um ano válido.");
                anoPublicacao = Console.ReadLine();
            }

            Livro novoLivro = new()
            {
                Id = Id,
                Titulo = titulo,
                Autor = autor,
                ISBN = iSBN,
                AnoPublicacao = anoPublicacao
            };

            Livros.Add(novoLivro);

            Console.WriteLine("Livro cadastrado com sucesso.\n");
        }
        public void ListaLivros()
        {
           if (Livros.Count > 0)
            {
                Console.WriteLine("Nenhum livro cadastrado.");
            }

            Console.WriteLine("Livros que já foram cadastrados: ");
            foreach (var livro in Livros)
            {
                Console.WriteLine($"ID: {livro.Id}, Título: {livro.Titulo}, Autor: {livro.Autor}, ISBN: {livro.ISBN}, Ano da Publicação: {livro.AnoPublicacao}");
            }
        }

        public void PesquisaLivros()
        {
            Console.WriteLine("Digite o Nome do Livro:");
            var tituloPesquisa = Console.ReadLine();

            if(string.IsNullOrEmpty(tituloPesquisa))
            {
                Console.WriteLine("Livro não encontrado, digite um nome válido: ");
                tituloPesquisa = Console.ReadLine();
            }

            bool livroEncontrado = false;

            foreach (var livro in Livros)
            {
                if (livro.Titulo.Equals(tituloPesquisa, StringComparison.InvariantCultureIgnoreCase) == true)
                {
                    Console.WriteLine($"Livro:\nID: {livro.Id}, Título: {livro.Titulo}, Autor: {livro.Autor}, ISBN: {livro.ISBN}, Ano de Publicação: {livro.AnoPublicacao}");
                    livroEncontrado = true;
                    break;
                }
            }
            if (!livroEncontrado)
            {
                Console.WriteLine("Livro não encontrado! ");
            }
        }

        public void RemoverLivro()
        {
            Console.WriteLine("Digite o Nome do Livro:");
            var removerLivro = Console.ReadLine();

            if (string.IsNullOrEmpty(removerLivro))
            {
                Console.WriteLine("Livro não encontrado, digite um nome válido: ");
                return;
            }

            Livro LivroParaRemover = null;

            for (int i = Livros.Count - 1; i >= 0; i --)
            {
                var livro = Livros[i];

                if (livro.Titulo.Equals (removerLivro, StringComparison.OrdinalIgnoreCase) == true)
                {
                    LivroParaRemover = livro;
                    Livros.RemoveAt(i);
                   
                    Console.WriteLine($"Livro deletado:\nID: {livro.Id}, Título: {livro.Titulo}, Autor: {livro.Autor}, ISBN: {livro.ISBN}, Ano de Publicação: {livro.AnoPublicacao}");
                    break;
                }
            }
            if(LivroParaRemover == null)
            {
                Console.WriteLine("Livro não encontrado!");
            }
        }

    }
}
