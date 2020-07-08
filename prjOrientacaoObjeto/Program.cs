using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOrientacaoObjeto.Classes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Loja.Classes.Cliente cli2 = new Loja.Classes.Cliente(2);

            cli2.Nome = "carlos".PrimeiraMaiuscula(true);
            cli2.DataCadastro = new DateTime(2020, 07, 07);

            //using (Classes.Cliente cli2 = new Classes.Cliente(2))
            //{
            //}

            //using (Classes.Cliente cli = new Classes.Cliente())
            //{
            //    cli.Codigo = 2;
            //    cli.Nome = "Carlos";
            //    cli.Tipo = 2;
            //    cli.DataCadastro = new DateTime(2020, 06, 29);
            //}
            //try,
            //{
            //    cli.Codigo = 1;
            //    cli.Nome = "Matheus".PrimeiraMaiuscula(true);
            //    cli.Tipo = 1;
            //    cli.DataCadastro = new DateTime(2020, 06, 23);
            //    cli.Dispose();
            //}
            //catch (prjOrientacaoObjeto.Excecoes.ValidacaoException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //using (Classes.Cliente cli2 = new Classes.Cliente(5))
            //{
            //    cli2.Nome = "Veloso";
            //}

            //< ------------------------------------------------>

            //Classes.Contato contato = new Classes.Contato();
            //contato.Codigo = 1;
            //contato.DadosContato = "666-6666";
            //contato.Tipo = "Telefone";

            //< ------------------------------------------------>

            //Classes.Contato contato2 = new Classes.Contato();
            //contato2.Codigo = 2;
            //contato2.DadosContato = "mtbveloso0321@gmail.com.br";
            //contato2.Tipo = "E-mail";

            //< ------------------------------------------------>

            //cli.Contatos = new List<Contato>();
            //cli.Contatos.Add(contato);
            //cli.Contatos.Add(contato2);

            //cli.Gravar();

            //foreach (Classes.Contato cont in cli.Contatos)
            //{
            //    cont.Gravar();
            //}

            //cli.Contatos.ForEach(cont => cont.Gravar());
            //Classes.Contato contatoBuscado = cli.Contatos.FirstOrDefault(x => x.Tipo == "Telefone");
            //Console.WriteLine(contatoBuscado.DadosContato);

            //Console.ReadLine();
        }
    }
}