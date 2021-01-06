using ArbolB;
using System;

namespace ArbolGenealogico
{
    class Program
    {
        static void Main(string[] args)
        {
            //5+6-2-1
            var raizOperacion = new Nodo("+",
                new Nodo("5"),
                new Nodo("-",
                    new Nodo("6"),
                    new Nodo("-",
                        new Nodo("2"),
                        new Nodo("1"))));
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
            /*raiz.Nombre = "*";

            //Nodo nivel 1
            var nodo0 = new Nodo();
            nodo0.Nombre = "0";
            var nodo1 = new Nodo();
            nodo1.Nombre = "1";

            //Nodo nivel 2
            var nodo00 = new Nodo();
            nodo00.Nombre = "00";
            var nodo01 = new Nodo();
            nodo01.Nombre = "01";

            var nodo10 = new Nodo();
            nodo10.Nombre = "10";
            var nodo11 = new Nodo();
            nodo11.Nombre = "11";

            //Nodo nivel 3

            var nodo000 = new Nodo();
            nodo000.Nombre = "000";
            var nodo001 = new Nodo();
            nodo001.Nombre = "001";
            var nodo010 = new Nodo();
            nodo010.Nombre = "010";
            var nodo011 = new Nodo();
            nodo011.Nombre = "011";

            var nodo100 = new Nodo();
            nodo100.Nombre = "100";
            var nodo101 = new Nodo();
            nodo101.Nombre = "101";
            var nodo110 = new Nodo();
            nodo110.Nombre = "110";
            var nodo111 = new Nodo();
            nodo111.Nombre = "111";

            raiz.Izquierdo = nodo0;
            raiz.Derecho = nodo1;

            nodo0.Izquierdo = nodo00;
            nodo0.Derecho = nodo01;

            nodo00.Izquierdo = nodo000;
            nodo00.Derecho = nodo001;

            nodo01.Izquierdo = nodo010;
            nodo01.Derecho = nodo011;
            //Derecho de la raiz
            nodo1.Izquierdo = nodo10;
            nodo1.Derecho = nodo11;

            nodo10.Izquierdo = nodo100;
            nodo10.Derecho = nodo101;

            nodo11.Izquierdo = nodo110;
            nodo11.Derecho = nodo111;*/

            Administrador  admin = new Administrador();
            admin.RecorrerArbol(raiz);

            var arbolOperaciones = new Nodo("+", 
                new Nodo("5"), 
                new Nodo("+", 
                    new Nodo("6"), 
                    new Nodo("+", 
                        new Nodo("-2"), 
                            new Nodo("-1"))));
            Console.WriteLine(admin.SumarArbol(arbolOperaciones));

        }
    }
}
