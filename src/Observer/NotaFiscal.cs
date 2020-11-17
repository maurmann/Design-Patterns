using System;
using System.Collections.Generic;

namespace Observer
{
    public class NotaFiscal
    {
        public string Cnpj { get; }
        public string RazaoSocial { get; }
        public DateTime DataDeEmissao { get; }
        public double ValorBruto { get; }
        public double Impostos { get; }
        public IList<ItemDaNota> Itens { get; }
        public string Observacoes { get; }

        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataDeEmissao,
                      double valorBruto, double impostos, IList<ItemDaNota> itens,
                      String observacoes)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.DataDeEmissao = dataDeEmissao;
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
            this.Itens = itens;
            this.Observacoes = observacoes;
        }
    }
}
