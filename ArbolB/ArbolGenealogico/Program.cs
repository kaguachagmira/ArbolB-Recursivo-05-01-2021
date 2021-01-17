using ArbolB;
using System;

namespace ArbolGenealogico
{
    class Program
    {
        static void Main(string[] args)
        {

            var opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("**************************");
                Console.WriteLine("*    Kevin Guachagmira   *");
                Console.WriteLine("*       05/01/2021       *");
                Console.WriteLine("*                        *");
                Console.WriteLine("*     ARBOLES    EN C#   *");
                Console.WriteLine("*                        *");
                Console.WriteLine("**************************");
                Console.WriteLine("(1) Arbol Binario");
                Console.WriteLine("(2) Arbol Multiples Hijos");
                Console.WriteLine("(3) Contar Niveles");
                Console.WriteLine("(4) Contar Hojas");
                Console.WriteLine("(5) Contar Nodos");
                Console.WriteLine("(6) Navegación Horizontal");
                Console.WriteLine("(7) Expresión matemática con +-*/");
                Console.WriteLine("(8) Salir");
                Console.WriteLine("Seleccione una opción del menú: ");
                try
                {
                    opcion = int.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Opcion de menu invalida");
                }
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Elegiste contruir Arbol binario");
                        Program.construirArbolB();
                        Program.PresionarSalir();
                        break;
                    case 2:
                        Console.WriteLine("Elegiste contruir Arbol multiples Hijos");
                        Program.construirArbolMultiplesHijos();
                        Program.PresionarSalir();
                        break;
                    case 3:
                        Console.WriteLine("Elegiste contar niveles Arbol Mutiples Hijos");
                        Program.contarNiveles();
                        Program.PresionarSalir();
                        break;
                    case 4:
                        Console.WriteLine("Elegiste contar hoijas Arbol Mutiples Hijos");
                        Program.contarHojas();
                        Program.PresionarSalir();
                        break;
                    case 5:
                        Console.WriteLine("Elegiste contar nodos Arbol Mutiples Hijos");
                        Program.contarNodos();
                        Program.PresionarSalir();
                        break;
                    case 6:
                        Console.WriteLine("Elegiste navegación horizontal POSTORDEN");
                        Program.NavegarHorizontalmente();
                        Program.PresionarSalir();
                        break;
                    case 7:
                        Console.WriteLine("Elegiste operar mediante expresión matematica");
                        Program.OperarExpresion();
                        Program.PresionarSalir();
                        break;
                    case 8:
                        Console.WriteLine("Muchas gracias por usar este programita");
                        Program.PresionarSalir();
                        opcion = 8;
                        break;
                    default:
                        Console.WriteLine("La opción escogida no esta dentro del menú vuelve a digitarlo porfavor");
                        Program.PresionarSalir();
                        break;
                }
            } while (opcion != 8);


        }
        public static void construirArbolB()
        {
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


            Administrador admin = new Administrador();
            admin.RecorrerArbol(raiz);
        }
        public static void construirArbolMultiplesHijos()
        {
            NodoExt nodoA = new NodoExt("A");
            NodoExt nodoB = new NodoExt("B");
            NodoExt nodoC = new NodoExt("C");
            NodoExt nodoD = new NodoExt("D");
            NodoExt nodoE = new NodoExt("E");
            NodoExt nodoF = new NodoExt("F");
            NodoExt nodoG = new NodoExt("G");

            //Raiz
            nodoA.Hijos.Add(nodoB);
            nodoA.Hijos.Add(nodoC);

            //
            nodoB.Hijos.Add(nodoD);
            nodoB.Hijos.Add(nodoE);
            //
            nodoC.Hijos.Add(nodoF);
            nodoC.Hijos.Add(nodoG);
            //
            nodoD.Hijos.Add(new NodoExt("H"));
            nodoD.Hijos.Add(new NodoExt("I"));
            nodoE.Hijos.Add(new NodoExt("J"));
            nodoE.Hijos.Add(new NodoExt("K"));

            nodoF.Hijos.Add(new NodoExt("L"));
            nodoF.Hijos.Add(new NodoExt("M"));
            nodoG.Hijos.Add(new NodoExt("N"));
            nodoG.Hijos.Add(new NodoExt("Ñ"));

            NodoExt.ImprmirArbolMultiplesHijos(nodoA);
        }
        public static void contarNiveles()
        {
            NodoExt nodoA = new NodoExt("A");
            NodoExt nodoB = new NodoExt("B");
            NodoExt nodoC = new NodoExt("C");
            NodoExt nodoD = new NodoExt("D");
            NodoExt nodoE = new NodoExt("E");
            NodoExt nodoF = new NodoExt("F");
            NodoExt nodoG = new NodoExt("G");

            NodoExt nodoN = new NodoExt("N");
            NodoExt nodoX = new NodoExt("X");

            //Raiz
            nodoA.Hijos.Add(nodoB);
            nodoA.Hijos.Add(nodoC);

            //
            nodoB.Hijos.Add(nodoD);
            nodoB.Hijos.Add(nodoE);
            //
            nodoC.Hijos.Add(nodoF);
            nodoC.Hijos.Add(nodoG);
            //
            nodoD.Hijos.Add(new NodoExt("H"));
            nodoD.Hijos.Add(new NodoExt("I"));
            nodoE.Hijos.Add(new NodoExt("J"));
            nodoE.Hijos.Add(new NodoExt("K"));

            nodoF.Hijos.Add(new NodoExt("L"));
            nodoF.Hijos.Add(new NodoExt("M"));
            nodoG.Hijos.Add(nodoN);
            nodoG.Hijos.Add(new NodoExt("Ñ"));

            nodoN.Hijos.Add(nodoX);

            NodoExt.ImprmirArbolMultiplesHijos(nodoA);

            Console.WriteLine("EL ARBOL TIENE {0} NIVELES !!!", NodoExt.ContarNiveles(nodoA));
        }
        public static void contarHojas()
        {
            NodoExt nodoA = new NodoExt("A");
            NodoExt nodoB = new NodoExt("B");
            NodoExt nodoC = new NodoExt("C");
            NodoExt nodoD = new NodoExt("D");
            NodoExt nodoE = new NodoExt("E");
            NodoExt nodoF = new NodoExt("F");
            NodoExt nodoG = new NodoExt("G");

            //Raiz
            nodoA.Hijos.Add(nodoB);
            nodoA.Hijos.Add(nodoC);

            //
            nodoB.Hijos.Add(nodoD);
            nodoB.Hijos.Add(nodoE);
            //
            nodoC.Hijos.Add(nodoF);
            nodoC.Hijos.Add(nodoG);
            //
            nodoD.Hijos.Add(new NodoExt("H"));
            nodoD.Hijos.Add(new NodoExt("I"));
            nodoE.Hijos.Add(new NodoExt("J"));
            nodoE.Hijos.Add(new NodoExt("K"));

            nodoF.Hijos.Add(new NodoExt("L"));
            nodoF.Hijos.Add(new NodoExt("M"));
            nodoG.Hijos.Add(new NodoExt("N"));
            nodoG.Hijos.Add(new NodoExt("Ñ"));

            NodoExt.ImprmirArbolMultiplesHijos(nodoA);
            Console.WriteLine("EL ARBOL TIENES {0} HOJAS !!!", NodoExt.ContarHojas(nodoA));

        }
        public static void contarNodos()
        {
            NodoExt nodoA = new NodoExt("A");
            NodoExt nodoB = new NodoExt("B");
            NodoExt nodoC = new NodoExt("C");
            NodoExt nodoD = new NodoExt("D");
            NodoExt nodoE = new NodoExt("E");
            NodoExt nodoF = new NodoExt("F");
            NodoExt nodoG = new NodoExt("G");

            //Raiz
            nodoA.Hijos.Add(nodoB);
            nodoA.Hijos.Add(nodoC);

            //
            nodoB.Hijos.Add(nodoD);
            nodoB.Hijos.Add(nodoE);
            //
            nodoC.Hijos.Add(nodoF);
            nodoC.Hijos.Add(nodoG);
            //
            nodoD.Hijos.Add(new NodoExt("H"));
            nodoD.Hijos.Add(new NodoExt("I"));
            nodoE.Hijos.Add(new NodoExt("J"));
            nodoE.Hijos.Add(new NodoExt("K"));

            nodoF.Hijos.Add(new NodoExt("L"));
            nodoF.Hijos.Add(new NodoExt("M"));
            nodoG.Hijos.Add(new NodoExt("N"));
            nodoG.Hijos.Add(new NodoExt("Ñ"));

            NodoExt.ImprmirArbolMultiplesHijos(nodoA);
            Console.WriteLine("EL ARBOL TIENE {0} NODOS!!", NodoExt.ContarNodos(nodoA));
        }
        public static void NavegarHorizontalmente()
        {
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


            Administrador admin = new Administrador();
            admin.NavegarHorizontal(raiz);
        }
        public static void OperarExpresion()
        {

            Administrador admin = new Administrador();

            //Ejemplo 1
            //Crear arbol manual 
            var arbolOperaciones = new Nodo("*",
                new Nodo("5"),
                new Nodo("*",
                    new Nodo("6"),
                    new Nodo("*",
                        new Nodo("-2"),
                            new Nodo("-1"))));
            //Operar arbol apartir del arbol creado
            Console.WriteLine("LA OPERACION QUE SE REALIZO MEDIANTE EL ARBOL ES: " + admin.SumarArbol(arbolOperaciones));
            Console.WriteLine("\n");


            //Ejemplo 2
            //Crear arbol manual 
            var arbolOperaciones2 = new Nodo("-",
                new Nodo("5"),
                new Nodo("-",
                    new Nodo("6"),
                    new Nodo("*",
                        new Nodo("-2"),
                            new Nodo("-1"))));
            //Operar arbol apartir del arbol creado
            Console.WriteLine("LA OPERACION QUE SE REALIZO MEDIANTE EL ARBOL ES: " + admin.SumarArbol(arbolOperaciones2));
            Console.WriteLine("\n");

            //Ejemplo 3
            //Crear arbol manual 
            var arbolOperaciones3 = new Nodo("/",
                new Nodo("5"),
                new Nodo("/",
                    new Nodo("6"),
                    new Nodo("-",
                        new Nodo("-2"),
                            new Nodo("-1"))));
            //Operar arbol apartir del arbol creado
            Console.WriteLine("LA OPERACION QUE SE REALIZO MEDIANTE EL ARBOL ES: " + admin.SumarArbol(arbolOperaciones3));
            Console.WriteLine("\n");

            //Ejemplo 3
            //Crear arbol manual 
            var arbolOperaciones4 = new Nodo("/",
                new Nodo("5"),
                new Nodo("+",
                    new Nodo("6"),
                    new Nodo("*",
                        new Nodo("-2"),
                            new Nodo("-1"))));
            //Operar arbol apartir del arbol creado
            Console.WriteLine("LA OPERACION QUE SE REALIZO MEDIANTE EL ARBOL ES: " + admin.SumarArbol(arbolOperaciones4));
            Console.WriteLine("\n");

            //Crear arbol apartir de un string
            //Nodo nodoOperacion = new Nodo();  
            //admin.CrearArbol(nodoOperacion, "5+6+2+1");
            //admin.RecorrerArbol(nodoOperacion);
            //Console.WriteLine(admin.SumarArbol(nodoOperacion));
        }
        public static void PresionarSalir()
        {
            Console.WriteLine("Presiona una tecla para continuar");
            Console.ReadLine();
        }
    }
}
