using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolB
{
    public class Administrador
    {

        public void RecorrerArbol(Nodo nodo)
        {
            if(nodo == null)
                return;

            Console.WriteLine(nodo.Nombre);
            RecorrerArbol(nodo.Izquierdo);
            RecorrerArbol(nodo.Derecho);
        }
        public int Operador(Nodo nodo)
        {
            if(nodo.Derecho.Nombre !="+" || nodo.Derecho.Nombre !="-" )
                return int.Parse(nodo.Derecho.Nombre);
            
            int operacion =  int.Parse(nodo.Izquierdo.Nombre)+ int.Parse(nodo.Derecho.Nombre);
            Operador(new Nodo(operacion.ToString()));
        }
    }
}
