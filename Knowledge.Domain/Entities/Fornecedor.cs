﻿using System;
using System.Collections.Generic;
using System.Text;
using Knowledge.Domain.Models;

namespace Knowledge.Domain.Entities
{
    public class Fornecedor : Entity
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string Cep { get; set; }
        public string Localidade { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }



    }
}
