using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCasasBahia.Services
{
    interface IServicoDePagamento
    {
        double TaxaDePagamento(double valor);
        double JurosParcela(double valor, int meses);
    }
}
