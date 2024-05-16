﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Dtos.Request
{
    public record CupomCadastraRequest
    {
        [Required(ErrorMessage = "Favor informar o codigo")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "Favor informar a descrição")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Favor informar o valor do desconto")]
        public decimal ValorDesconto { get; set; }
        [Required(ErrorMessage = "Favor informar o tipo de desconto")]
        public string TipoDesconto { get; set; }
        [Required(ErrorMessage = "Favor informar a data de validade")]
        public DateTime DataValidade { get; set; }
        [Required(ErrorMessage = "Favor informar a quantidade que vai ser liberado")]
        public int QuantidadeLiberado { get; set; }
        [Required(ErrorMessage = "Favor informar o Status")]
        public string Status { get; set; }
    }
}
}