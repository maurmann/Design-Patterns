using System;

namespace Memento
{
    class Contrato
    {
        public DateTime Data { get; set; }
        public string Cliente { get; set; }
        public TipoContrato Tipo { get; set; }

        public Contrato(DateTime data, string cliente, TipoContrato tipo)
        {
            Data = data;
            Cliente = cliente;
            Tipo = tipo;
        }

        public void Avanca()
        {
            switch (Tipo)
            {
                case TipoContrato.Novo:
                    Tipo = TipoContrato.EmAndamento;
                    break;
                case TipoContrato.EmAndamento:
                    Tipo = TipoContrato.Concluido;
                    break;
                case TipoContrato.Concluido:
                    throw new ArgumentOutOfRangeException("Estado não pode avançar");
            }
        }

        public Estado SalvarEstado()
        {
            return new Estado(new Contrato(this.Data, this.Cliente, this.Tipo));
        }


    }
}
