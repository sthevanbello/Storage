using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Enumerators
{
    public enum ESituacao
    {
        VendaConfirmadaComPagamento = 100,
        VendaConfirmadaPagamentoPendente = 102,
        VendaCancelada = 135,
        VendaNaoFinalizada = 190,
        ErroNaoIdentificado = 999
    }
}
