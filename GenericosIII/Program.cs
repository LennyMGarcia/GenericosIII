using System;

namespace GenericosIII
{
    class Program
    {
        static void Main(string[] args)
        {
            //debido a la restriccion no acepta la clase estudiante
            alamacenEmpleados<director> empleados = new alamacenEmpleados<director>(3);
            //Se instancia un nuevo director que un valor especifico
            empleados.agregar(new director(4500));
            empleados.agregar(new director(4500));
            empleados.agregar(new director(4500));
          

            Console.WriteLine("Hello World!");
        }
    }
    //Asi se crea una clase generica con restricciones se usa el where para indica que tiene que aplicar las interfaces
    //Esta podra almacenar cualquier clase que tenga salario (objetos)
    class alamacenEmpleados<T> where T:IParaEmpleados
    {
        public alamacenEmpleados(int z)
        {
            //Almacena el numero de datos con z elementos
            datosEmpleados = new T[z];
        }
        //Agrega elementos de tipo generico como empleados de diferente tipos
        //cada vez que se agrega aumenta su  numero
        public void agregar( T obj)
        {
            datosEmpleados[i] = obj;

            i++;
        }
        //devuleve generico indicado por T
        public T getEmpleado(int i)
        {
            return datosEmpleados[i];
        }
        private int i = 0;
        //array generico
        private T[] datosEmpleados;


    }
    interface IParaEmpleados
    {
        double getSalario();
    }
    class director:IParaEmpleados
    {

        public director(double salario)
        {
            this.salario = salario;
        }
        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }

    class secretaria:IParaEmpleados
    {
        public secretaria(double salario)
        {
            this.salario = salario;
        }
        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }

    class electricista:IParaEmpleados
    {
        public electricista(double salario)
        {
            this.salario = salario;
        }
        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }

    class estudiant
    {

        public estudiant(double edad)
        {
            this.edad = edad;
        }

        public double getEdad()
        {
            return edad;
        }
        private double edad;

        
    }
}
