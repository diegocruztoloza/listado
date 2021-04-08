using System;

namespace listado
{
    class program2
    {
        

        struct Datos
        {
            
            public string nombre, carnet;
            public int edad;
            public bool solvente;
            public string curso;
            public double nota1;
            public double nota2;
            public double notafinal;
            
            static void Main(string[] args)
            {
                int i;
                Datos[] estudiante = new Datos[4];

                for (int i = 0; i <= 3; i++);
                {
                    Console.Write("Nombre del estudiante: ");
                    estudiante[i].nombre = Console.ReadLine();

                    Console.Write("Ingrese el carnet: ");
                    estudiante[i].carnet = Console.ReadLine();

                    Console.Write("Ingrese la edad: ");
                    estudiante[i].edad = int.Parse(Console.ReadLine());

                    Console.Write("Indique si esta Solvente: ");
                    estudiante[i].solvente = bool.Parse(Console.ReadLine());

                    Console.Write("Ingrese el curso:");
                    estudiante[i].curso = Console.ReadLine();

                    Console.Write("nota1: ");
                    estudiante[i].nota1 = double.Parse(Console.ReadLine());

                    Console.Write("nota2: ");
                    estudiante[i].nota2 = double.Parse(Console.ReadLine());

                    Console.Write("notafinal: ");
                    estudiante[i].notafinal = double.Parse(Console.ReadLine());

                    estudiante[i].notafinal = (estudiante[i].nota1 + estudiante[i].nota2 + estudiante[i].notafinal) / 5;




                }

                Console.WriteLine("*****///**************///////////");

                for (int i = 0; i <= 3; i++);

                {
                    Console.WriteLine("Nombre" + estudiante[i].nombre);
                    Console.WriteLine("Carnet" + estudiante[i].carnet);
                    Console.WriteLine("Edad" + estudiante[i].edad);
                    Console.WriteLine("Solvente" + estudiante[i].solvente);
                    Console.WriteLine("Curso" + estudiante[i].curso);
                    Console.WriteLine("Notafinal" + estudiante[i].notafinal);

                    Console.WriteLine("*******************************");

                }

                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

            }
        }
    }

}
