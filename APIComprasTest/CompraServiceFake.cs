using APICompras.Models;
using APICompras.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APIComprasTest
{
    class CompraServiceFake : ICompraService
    {
        public readonly List<CompraItem> _compra; //Convenção MS: "variáveis globais devem começar com '_'"

        #region Construtor

        public CompraServiceFake()
        {
            _compra = new List<CompraItem>() {

                new CompraItem()
                {
                    Id = 1,
                    Nome = "Moto One Action",
                    Fabricante = "Motorola",
                    Preco = 150.00M
                },

                new CompraItem()
                {
                    Id = 2,
                    Nome = "Iphone 11",
                    Fabricante = "Apple",
                    Preco = 600.00M
                },

                new CompraItem()
                {
                    Id = 3,
                    Nome = "Notebook Lenovo 13",
                    Fabricante = "Lenovo",
                    Preco = 1350.00M
                },

                new CompraItem()
                {
                    Id = 4,
                    Nome = "Monitor LG 23",
                    Fabricante = "LG",
                    Preco = 879.00M
                },

                new CompraItem()
                {
                    Id = 5,
                    Nome = "HD SSD Asus 1",
                    Fabricante = "Asus",
                    Preco = 600.00M
                }
            };
        }

        #endregion Construtor

        public CompraItem Add(CompraItem novoItem)
        {
            novoItem.Id = GeraId();
            _compra.Add(novoItem);
            return novoItem;
        }

        public IEnumerable<CompraItem> GetAllItens()
        {
            return _compra;
        }

        public CompraItem GetById(int id)
        {
            return _compra.Where(a => a.Id == id).FirstOrDefault();
        }

        public void Remove(int id)
        {
            var item = _compra.First(a => a.Id == id);
            _compra.Remove(item);
        }

        private int GeraId()
        {
            Random random = new Random();
            return random.Next(1, 100);
        }
    }
}
