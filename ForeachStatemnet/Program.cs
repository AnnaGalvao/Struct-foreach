using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ForeachStatemnet
{
    
    class Program
    {
        public struct Livro
        {
            public string titulo;
            public string autor;
            public int codigo;
            public int anoPublicacao;
        }

        static void Main(string[] args)
        {
            Livro l1;
            l1.codigo = 1;
            l1.autor = "Machado de Assis";
            l1.titulo = "Dom Casmurro";
            l1.anoPublicacao = 1940;

            Livro l2;
            l2.codigo = 2;
            l2.autor = "Jorge Amado";
            l2.titulo = "Gabriela";
            l2.anoPublicacao = 1965;

            //ArrayList livros = new ArrayList(); - nao prudente  nese caso pois ele aceita qq object
            List < Livro> livros = new List<Livro>(); //Generic = mais seguro pois só aceita o tipo utilizavel e a performarce do list é melhor que do arraylist
            livros.Add(l1);
            livros.Add(l2);

            foreach (Livro item in livros)
            {
                Console.WriteLine("Livro Código: " + item.codigo.ToString());
                Console.WriteLine("Título: " + item.titulo);
                Console.WriteLine("Autor: " + item.autor);
                Console.WriteLine("Ano de publicação: " + item.anoPublicacao.ToString());
                Console.WriteLine("---------------------------------");
            }
            Console.ReadKey();

        }
    }
}
