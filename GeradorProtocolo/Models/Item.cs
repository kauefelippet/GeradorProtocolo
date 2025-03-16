﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorProtocolo.Models
{
    public class Item
    {
        public string Requerente { get; set; }
        public string CpfCnpj { get; set; }
        public string TipoRegistro { get; set; }
        public string NomeParte { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public double? ValorApostila { get; set; }
        public Boolean ProtocoloLivro { get; set; }

        public double Total => Valor * Quantidade;
    }
}
