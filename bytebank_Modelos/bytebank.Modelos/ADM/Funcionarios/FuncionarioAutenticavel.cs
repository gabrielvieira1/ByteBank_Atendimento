﻿using bytebank.Modelos.ADM.SistemaInterno;
using bytebank.Modelos.ADMs.Utilitario;

namespace bytebank.Modelos.ADM.Funcionarios
{
  public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
  {
    public string Senha { get; set; }
    private AutenticacaoUtil Autenticador = new AutenticacaoUtil();
    public FuncionarioAutenticavel(double salario, string cpf)
        : base(salario, cpf)
    {

    }

    public bool Autenticar(string senha)
    {
      return this.Autenticador.ValidarSenha(this.Senha,
          senha);
    }
  }
}
