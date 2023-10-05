using IFSPStore;
using IFStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace IFSPStore.Test
{
    [TestClass]
    public class UnitTestRepository
    {
        public class MyDbContext : DbContext
        {
            public DbSet<Usuario> Usuario { get; set; }
            public DbSet<Cidade> Cidade { get; set; }
            public DbSet<Grupo> Grupo { get; set; }
            public DbSet<Produto> Produto { get; set; }
            public DbSet<Cliente> Cliente { get; set; }
            public DbSet<Venda> Venda { get; set; }

            public MyDbContext()
            {
                Database.EnsureCreated(); // Força criacao banco de dados
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "IFSPStore";
                var username = "root";
                var password = "";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password};";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }
        }


        [TestMethod]
        public void TestUsuario()
        {
            using (var context = new MyDbContext())
            {
                var usuario = new Usuario
                {
                    Nome = "Leonardo Varges",
                    Login = "Leonardo",
                    Senha = "comsenha",
                    Email = "leonardovarges@gmail.com",
                    Ativo = true,
                    DataCadastro = DateTime.Now,
                    DataLogin = DateTime.Now
                };
                //Insere objeto no banco
                context.Usuario.Add(usuario);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestSelectUsuario()
        {
            using (var context = new MyDbContext())
            {
                foreach (var usuario in context.Usuario)
                {
                    Console.WriteLine(JsonSerializer.Serialize(usuario));
                }
            }
        }

        [TestMethod]
        public void TestCidade()
        {
            using (var context = new MyDbContext())
            {
                var cidade = new Cidade
                {
                    Nome = "Araçatuba",
                    Estado = "São Paulo"
                };
                //Insere objeto no banco
                context.Cidade.Add(cidade);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestSelectCidade()
        {
            using (var context = new MyDbContext())
            {
                foreach (var cidade in context.Cidade)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cidade));
                }
            }
        }


        [TestMethod]
        public void TestCliente()
        {
            using (var context = new MyDbContext())
            {
                var cidade = context.Cidade.First(c => c.Id == 1);
                var cliente = new Cliente
                {
                    Nome = "Araçatuba",
                    Endereco = "São Paulo",
                    Documento = "",
                    Bairro = "Centro",
                    Cidade = cidade
                };
                //Insere objeto no banco
                context.Cliente.Add(cliente);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestSelectCliente()
        {
            using (var context = new MyDbContext())
            {
                foreach (var cliente in context.Cliente)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cliente));
                }
            }
        }

        [TestMethod]
        public void TestGrupo()
        {
            using (var context = new MyDbContext())
            {
                var grupo = new Grupo
                {
                    Nome = "Grupo 1"
                };
                //Insere objeto no banco
                context.Grupo.Add(grupo);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestSelectGrupo()
        {
            using (var context = new MyDbContext())
            {
                foreach (var grupo in context.Grupo)
                {
                    Console.WriteLine(JsonSerializer.Serialize(grupo));
                }
            }
        }

        [TestMethod]
        public void TestProduto()
        {
            using (var context = new MyDbContext())
            {
                var grupo = context.Grupo.First(g => g.Id == 1);
                var produto = new Produto
                {
                    Nome = "Banana",
                    Preco = 12.99m,
                    Quantidade = 62,
                    Data = DateTime.Now,
                    UnidadeVenda = "3",
                    Grupo = grupo
                };
                context.Produto.Add(produto);
                produto = new Produto
                {
                    Nome = "Maça",
                    Preco = 11.12m,
                    Quantidade = 12,
                    Data = DateTime.Now,
                    UnidadeVenda = "PC",
                    Grupo = grupo
                };
                //Insere objeto no banco
                context.Produto.Add(produto);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestSelectProduto()
        {
            using (var context = new MyDbContext())
            {
                foreach (var produto in context.Produto)
                {
                    Console.WriteLine(JsonSerializer.Serialize(produto));
                }
            }
        }

        [TestMethod]
        public void TestVenda()
        {
            using (var context = new MyDbContext())
            {
                var usuario = context.Usuario.First(v => v.Id == 1);
                var cliente = context.Cliente.First(p => p.Id == 1);
                var produto = context.Produto.First(p => p.Id == 1);
                var venda = new Venda
                {
                    Data = DateTime.Now,
                    ValorTotal = 1200.99m,
                    Usuario = usuario,
                    Cliente = cliente,
                    Items = new List<VendaItem>
                    {
                        new VendaItem
                        {
                            //Venda = venda,
                            Produto = context.Produto.First(p => p.Id == 1),
                            Quantidade = 1,
                            ValorTotal = 1220.50m,
                            ValorUnitario = 12.99m
                        },
                        new VendaItem
                        {
                            //Venda = venda,
                            Produto = context.Produto.First(p => p.Id == 2),
                            Quantidade = 2,
                            ValorTotal = 22m,
                            ValorUnitario = 11m
                        }
                    }
                };

                //Insere objeto no banco
                context.Venda.Add(venda);
                context.SaveChanges();
            }
        }
        


        [TestMethod]
        public void TestSelectVenda()
        {
            using (var context = new MyDbContext())
            {
                foreach (var venda in context.Venda)
                {
                    Console.WriteLine(JsonSerializer.Serialize(venda));
                }
            }
        }

      
        [TestMethod]
        public void TestSelectVendaItem()
        {
            using (var context = new MyDbContext())
            {
                foreach (var vendaitem in context.Venda)
                {
                    Console.WriteLine(JsonSerializer.Serialize(vendaitem));
                }
            }
        }
    }
}