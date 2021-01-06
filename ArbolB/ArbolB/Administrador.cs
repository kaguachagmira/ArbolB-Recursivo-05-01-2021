using System;
using System.Collections.Generic;
using System.Linq;
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
        public bool EsNumero(string nombre)
        {
            if (nombre != "+") 
                return true;
            else
                return false;
        }
        public int ConvertirEnNumero(string numero)
        {
            return int.Parse(numero);
        }
        
        public int SumarArbol(Nodo nodo)
        {
            if(!EsNumero(nodo.Nombre) || nodo==null){
                int izquierdo = SumarArbol(nodo.Derecho);
                int derecho = SumarArbol(nodo.Izquierdo);
                return (izquierdo + derecho);
            }
            else
            {
                return (ConvertirEnNumero(nodo.Nombre));
            }
        }
    }
}
