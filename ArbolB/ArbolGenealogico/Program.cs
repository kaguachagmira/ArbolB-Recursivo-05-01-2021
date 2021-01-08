using ArbolB;
using System;

namespace ArbolGenealogico
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nodo Raiz nivel 0
            var raiz = new Nodo("*",
                new Nodo("0",
                    new Nodo("00",
                        new Nodo("000"),
                        new Nodo("001")),
                    new Nodo("01",
                        new Nodo("010"),
                        new Nodo("011"))),
                new Nodo("1",
                    new Nodo("10",
                        new Nodo("100"),
                        new Nodo("101")),
                    new Nodo("11",
                        new Nodo("110"),
                        new Nodo("111"))));


            Administrador  admin = new Administrador();
            //admin.RecorrerArbol(raiz);


            //Crear arbol manual 
            var arbolOperaciones = new Nodo("+", 
                new Nodo("5"), 
                new Nodo("+", 
                    new Nodo("6"), 
                    new Nodo("+", 
                        new Nodo("-2"),     
                            new Nodo("-1"))));
            Console.WriteLine("La suma del arbol es: "+ admin.SumarArbol(arbolOperaciones));
            Console.WriteLine("\n");

            //Crear arbol apartir de un string
            Nodo nodoOperacion = new Nodo();
            admin.CrearArbol(nodoOperacion, "5+6+2+1");
            admin.RecorrerArbol(nodoOperacion);
            //Console.WriteLine(admin.SumarArbol(nodoOperacion));

        }
    }
}
