﻿using Contato.Dominio;
using System;
using System.Collections.Generic;

namespace Contato
{
    public class Contato
    {
        public Contato( string nome, List<Telefone> telefone, string endereco)
        {
            Nome = nome;
            Telefones = telefone;
            Endereco = endereco;
        }

        public Contato()
        {
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Telefone> Telefones { get; set; }
        public string Endereco { get; set; }

    }
}
