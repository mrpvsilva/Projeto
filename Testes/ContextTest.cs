using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataSource.Infra.Context;
using Dominio.Models;

namespace Testes
{
    [TestClass]
    public class ContextTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var db = new MyDbContext();
            
                var u = new Usuario { Login = "Paulo" };
                db.Usuarios.Add(u);
                db.SaveChanges();

                

            
        }
    }
}
