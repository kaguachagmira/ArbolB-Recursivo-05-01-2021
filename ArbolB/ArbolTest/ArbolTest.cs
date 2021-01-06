using ArbolB;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArbolTest
{
    [TestClass]
    public class ArbolTest
    {
        [TestMethod]
        public void TestArbolSuma()
        {
            var arbolOperaciones = new Nodo("+",
                new Nodo("5"),
                new Nodo("+",
                    new Nodo("6"),
                    new Nodo("+",
                        new Nodo("-2"),
                            new Nodo("-1"))));
            var admin = new Administrador();
            var resultadoEsperado = 8;

            var resultado = admin.SumarArbol(arbolOperaciones);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
