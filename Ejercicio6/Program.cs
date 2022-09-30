using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    public class Libro
    {

        private int ISBN;
        private string titulo;
        private string autor;
        private int numPaginas;

        public Libro(int ISBN, string Titulo, string Autor, int NumPaginas)
        {

            this.ISBN = ISBN;
            this.titulo = Titulo;
            this.autor = Autor;
            this.numPaginas = NumPaginas;

        }

        public int isbn
        {
            get
            {
                return ISBN;
            }
            set
            {
                ISBN = value;
            }
        }
        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }
        public string Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
            }
        }
        public int NumPaginas
        {
            get
            {
                return numPaginas;
            }
            set
            {
                numPaginas = value;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {

                Libro libro1 = new Libro(1423456, "Libro1", "Autor1", 516);
                Libro libro2 = new Libro(5985458, "Libro1LaSecuela", "Autor2", 2);

                Console.WriteLine("El libro " + libro1.Titulo + " con ISBN " + libro1.isbn + " creado por el autor " + libro1.Autor + " tiene " + libro1.NumPaginas + " páginas");
                Console.WriteLine("El libro " + libro2.Titulo + " con ISBN " + libro2.isbn + " creado por el autor " + libro2.Autor + " tiene " + libro2.NumPaginas + " páginas");

                if (libro1.NumPaginas > libro2.NumPaginas)
                {
                    Console.WriteLine("El libro " + libro1.titulo + "es el que tiene mas paginas");
                }
                else
                {
                    Console.WriteLine("El libro " + libro2.titulo + "es el que tiene mas paginas");
                }
            }
        }
    }
}
