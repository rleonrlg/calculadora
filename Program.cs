using System;
namespace process
{

    class ejercicio
    {
        static void Main(String[] args)
        {


            acciones o = new acciones();
            o.data();
            o.sum();
            o.res();


            Console.ReadKey();


        }
    }
}


class acciones
{
    double a, b;

    public void data()
    {//en este metodo solo guardaremos valores en las variables a y b para utilizar luego
        Console.WriteLine("Digite el primer numero");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite el segundo numero");
        b = int.Parse(Console.ReadLine());


        while (a <= 0 || b <= 0)
        {
            Console.Clear();
            Console.WriteLine("Digite el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            b = int.Parse(Console.ReadLine());

        }

    }//cierre del metodo pedir_datos


    public void sum()
    {//metodo que hace una impresion y muestra a, b y la suma de a y b
        Console.WriteLine("La suma de {0} + {1} es {2}", a, b, a + b);
    }

    public void res()
    {
        Console.WriteLine("La resta de {0} - {1} es {2}", a, b, a - b);
    }



}

