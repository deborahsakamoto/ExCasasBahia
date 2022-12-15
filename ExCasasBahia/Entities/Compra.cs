using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCasasBahia.Entities
{
    internal class Compra
    {
        public int NumCompra { get; set; }
        public DateTime DataCompra { get; set; }
        public double ValorTotal { get; set; }
        public List<Financiamento> Financiamentos { get; set; }

        public Compra()
        {

        }
        
        public Compra(int numCompra, DateTime dataCompra, double valorTotal)
        {
            NumCompra = numCompra;
            DataCompra = dataCompra;
            ValorTotal = valorTotal;
            Financiamentos = new List<Financiamento>();
        }



        public void AddFinanciamento(Financiamento financiamento)
        {
            Financiamentos.Add(financiamento);
        }

    }
}
