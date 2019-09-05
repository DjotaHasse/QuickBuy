using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DatePedio { get; set; }
        public int UsuarioID { get; set; }
        public DateTime DataPrevisãoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string NumeroEndereco  { get; set; }
        public int FomarPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        public ICollection<ItemPedido> ItensPedido { get; set; }
    }
}
