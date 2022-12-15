using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCasasBahia.Services
{
    class ServicoPayPal : IServicoDePagamento
    {

        private const double taxaPorcentagem = 0.02;
        private const double jurosMensais = 0.01;

        public double JurosDaParcela(double valor, int meses)
        {
            return valor * jurosMensais * meses;
        }

        public double TaxaDePagamento(double valor)
        {
            return valor * taxaPorcentagem;
        }


    }
}
