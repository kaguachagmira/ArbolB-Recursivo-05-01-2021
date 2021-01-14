# 05-01-2021-ArbolB-Recursivo

# Asignatura: Programación Visual

# Docente: Magister Gorky Estrella

# Nombre: Kevin Alexander Guachagmira Mantilla

# Fecha : 05-01-2021

# Actividad: 

Realizar un Arbol Recursivo que cumpla

Arbol binario

Arbol multiples hijos

Contar niveles

Contar hojas

Contar nodos

Navegacion horizontal

Expresion matematica con + - * / tomar en cuenta las prioridades



## Arbol Binario:

Esta opción del menu permite crear un arbol binario quemado con un Nombre, una unión tanto en derecha como izquierda a otro objeto de tipo Nodo

### public static void ConstruirArbol(); 

No recibe parametros ni retorna ninguna valor

### public Nodo(string nombre, Nodo izquierdo, Nodo derecho)

Constructor que recibe tres parametros y no retorna ningun valor
También existe un constructor vacio que recibe unicamente un nombre

### public void RecorrerArbol(Nodo nodo)

Recibe un único parametro que es el nodo raiz de un Arbol



## Arbol multiples hijos:

Esta opción del menu permite crear un arbol de multiples hijos es decir un Nodo con una propiedad que posea una lista de Nodos

### public static void construirArbolMultiplesHijos()

No recibe parametros ni retorna ningun valor

### public NodoExt(string nombre)

Constructor de NodoExt recibe el nombre del nodo y dentro del contructor se instancia una lista de nodos de tipo NodoExt 
También existe un constructor vacio que no recibe parametros.

### public static void ImprmirArbolMultiplesHijos(NodoExt nodo)

Este metodo permite imprimir de manera recursiva y mediante un ciclo for todos los hijos que pueden tener un Nodo ademas se verifica si el nodo es null o no tiene Hijos



## Contar Niveles:

Esta opción del menú me permite recorrer un arbol y contar todos los niveles en base a la teoria de arboles. 

### public static int ContarNiveles(NodoExt nodo)

Este método permite recorrer el arbol de multiples hijos y poder conocer mediante una función recursiva los niveles que posee el arbol.



## Contar Hojas:

Esta opción del menú me permite recorrer un arbol y contar todos las hojas en base a la teoria de arboles. 

### public static int ContarHojas(NodoExt nodo)

Este método permite recorrer el arbol de multiples hijos y poder conocer mediante una función recursiva la cantidad de hojas que posee el arbol.



## Contar Nodos:

Esta opción del menú me permite recorrer un arbol y contar todos los nodos en base a la teoria de arboles. 

### public static int ContarNodos(NodoExt nodo)

Este método permite recorrer el arbol de multiples hijos y poder conocer mediante una función recursiva la cantidad de nodos que posee el arbol.


## Navegación Horizontal:

Esta opción del menú me permite recorrer un arbol binario y recorrer mediante POSTORDEN sus nodos

### public void NavegarHorizontal(Nodo nodo)

Este método permite recorrer el arbol Binario mediante POSTORDEN esta función no retorna nad ay recibe como parametro un nodo de tipo Nodo




## Operar Expresión:

Esta opción del menú me permite operar en base a los signos de operación en base a su jerarquia que forman parte de un cadena de string
y se tranforma en un arbol binario donde los signos de operación se encuentran como parte de un nivel del arbol

### public void CrearArbol(Nodo nodo, string expresionMatematica)

Este método permite crear un arbol binario recibe como parametros un nodo de tipo Nodo y un string que posee una cadena con una operación en notación 
polaca no retorna ningun valor

### private int BuscarOperador(string expresionMatematica)

Este método me ayuda a buscar un operador dentro dentro de arbol binario para eso debo recorrerlo recursivamente en caso de encontrar 
un caracter que no corresponde a un número entonces se establece como signo caso contrario es un numero y se retorna la posicion en el arbol donde 
este signo fue hallado por eso tiene como valor de retorno un entero.

### public bool EsNumero(string nombre)

Este método me permite conocer si el caracter enviado es un numero o no en caso de serlo retorna un valor boleano afirmativo

### public int ConvertirEnNumero(string numero)

Este método me permite convertir un string numero a int y me retorna un int

### public int SumarArbol(Nodo nodo)

Este método implementa todo las funciones anteriores y permite realizar la suma en orden de las jerarquias.



# Actividad de Evaluación temas tratados el día 05-01-2021 en la clase de Programación Visual
