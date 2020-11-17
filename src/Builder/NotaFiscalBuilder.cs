using System;
using System.Collections.Generic;
using System.Linq;

namespace Builder
{
    public class NotaFiscalBuilder
    {

        private string Cnpj { get; set; }
        private string RazaoSocial { get; set; }
        private DateTime DataDeEmissao { get; set; }
        private double ValorBruto { get; set; }
        private double Impostos { get; set; }
        private IList<ItemDaNota> Itens { get; set; }
        private string Observacoes { get; set; }

        public NotaFiscalBuilder()
        {
            Itens = new List<ItemDaNota>();
        }

        public NotaFiscalBuilder ParaEmpresa(string cnpj, string razaoSocial)
        {
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ParaDataAtual()
        {
            DataDeEmissao = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota itemDaNota)
        {
            Itens.Add(itemDaNota);
            ValorBruto = Itens.Sum(i => i.Valor);
            Impostos = ValorBruto * 0.18;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscal Build()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, DataDeEmissao, ValorBruto, Impostos, Itens, Observacoes);
        }
        

    }
}
