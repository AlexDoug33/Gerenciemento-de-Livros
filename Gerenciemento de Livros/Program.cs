using Gerenciemento_de_Livros;

class Program
{
    static void Main()
    {
        Opcoes opcoes = new();
        Livro livro = new();
        Usuarios usuarios = new();
        Emprestimo emprestimo = new();

        do
        {
            opcoes.MostrarOpcoes();
            int escolha = opcoes.LerEscolher();

            switch (escolha)
            {
                case 1:
                    livro.RegistroLivro();
                    break;
                case 2:
                    livro.ListaLivros();
                    break;
                case 3:
                    livro.PesquisaLivros();
                    break;
                case 4:
                    livro.RemoverLivro();
                    break;
                case 5:
                    usuarios.RegistroUsuario();
                    break;
                case 6:
                    emprestimo.RegistroEmprestimo(usuarios.Id, livro.Id);
                    break;
                case 7:
                    emprestimo.DevolucaoLivro();
                    break;
                case 0:
                    Console.WriteLine("Sair, Até logo!!");
                    break;
                default:
                    Console.WriteLine("Número Inválido, digite novamente.");
                    break;

            }
        } while (true);
    }
}




