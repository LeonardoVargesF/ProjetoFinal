using IFSPStore;
using IFStore.Domain.Entities;
using System.Text.Json;

namespace IFSPStore.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var usuario = new Usuario();
            usuario.Nome = "Leonardo";
            Console.WriteLine(JsonSerializer.Serialize(usuario));

            Assert.AreEqual(usuario.Nome, "Leonardo");
        }

        public void TestMethod2()
        {
            var cliente = new Cliente();
            cliente.Nome = "Marta";
            Console.WriteLine(JsonSerializer.Serialize(cliente));

            Assert.AreEqual(cliente.Nome, "Marta");
        }
    }
}