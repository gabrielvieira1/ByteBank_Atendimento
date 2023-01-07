using bytebank.Modelos.ADM.Funcionarios;
using bytebank.Modelos.ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Modelos.ADMs.Utilitario
{
  internal class AutenticacaoUtil
  {
    public bool ValidarSenha(string senhaverdadeira, string senhatentativa)
    {
      return senhaverdadeira.Equals(senhatentativa);
    }
  }
}
