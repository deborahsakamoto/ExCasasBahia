using ExCasasBahia.Entities;
using ExCasasBahia.Services;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCasasBahia.Services
{
    internal class ServicoDeCompra
    {

        private IServicoDePagamento _servicoDePagamento;

        public ServicoDeCompra(IServicoDePagamento servicoDePagamento)
        {
            _servicoDePagamento = servicoDePagamento;
        }

        public void GerarCompra(Compra compra, int meses)
        {
            double basicQuota = compra.ValorTotal / meses;
            for (int i = 1; i <= meses; i++)
            {
                DateTime date = compra.DataCompra.AddMonths(i);
                double updatedQuota = basicQuota + _servicoDePagamento.JurosParcela(basicQuota, i);
                double fullQuota = updatedQuota + _servicoDePagamento.TaxaDePagamento(updatedQuota);
                compra.AddFinanciamento(new Financiamento(date, fullQuota));
            }
        }

    }
}
