using System;

namespace deber2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nomina de mejores Empleados");

            var random = new Random();

            var empresa = new EmpresaReciclaje
            {
                Id = random.Next(),
                Nombre = "JDJ RECICLAJE",
                Direccion = "Quito",
                Telefono = "0956434534",
                Record = "12.000.000",
                Empleado1 = new Empleado1
                {
                    Id = random.Next(),
                    Nombre = "Juan",
                    Apellido = "cazares",
                    Sector = "Sur",
                    RecordMes = "12.000"
                },
                Empleado2 = new Empleado2
                {
                    Id = random.Next(),
                    Nombre = "Manuel",
                    Apellido = "Caballero",
                    Sector = "Centro",
                    RecordMes = "8.000"
                },
                Empleado3 = new Empleado3
                {
                    Id = random.Next(),
                    Nombre = "Julio",
                    Apellido = "Perez",
                    Sector = "Norte",
                    RecordMes = "5.000"
                },
                Premio1 = new Premio
                {
                    Id = random.Next(),
                    numCheque = "000002565765456",
                    Banco = "Pichincha",
                    Monto = "5.000"
                },
                Premio2 = new Premio
                {
                    Id = random.Next(),
                    numCheque = "000002565763456",
                    Banco = "Pichincha",
                    Monto = "2.000"
                },
                Premio3 = new Premio
                {
                    Id = random.Next(),
                    numCheque = "000002565768976",
                    Banco = "Pichincha",
                    Monto = "1.000"
                }
            };
            Console.WriteLine(empresa.Presentarse());
            Console.WriteLine(empresa.Ubicarse());
            Console.WriteLine(empresa.Contactarse());
            Console.WriteLine(empresa.Reconocer());


            Console.WriteLine(empresa.Presentar1());
            Console.WriteLine(empresa.Reconocer1());

            Console.WriteLine(empresa.Presentar2());
            Console.WriteLine(empresa.Reconocer2());

            Console.WriteLine(empresa.Presentar3());
            Console.WriteLine(empresa.Reconocer3());

            Console.WriteLine(empresa.Indicar());
            Console.WriteLine(empresa.Indicar2());
            Console.WriteLine(empresa.Indicar3());
            //Espera una tecla para culminar
            Console.ReadKey();
        }
    }
}
