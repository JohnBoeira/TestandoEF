using Contato.Dominio;
using Contato.Infraestrutura;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Contato.ConsoleApp
{
    class Program
    {
        static TelefoneContatoContext telefoneContatoContext;
        static void Main(string[] args)
        {
            telefoneContatoContext = new TelefoneContatoContext();

            Contato contato = new Contato("Nome", new List<Telefone>(), "Rua sei la");
            ExcluirContato(5);

            telefoneContatoContext.SaveChanges();           
        }

        public static void InserirContato()
        {
            Contato contato = new Contato("Nome", new List<Telefone>(), "Rua abc");

            Telefone telefone = new Telefone(contato, 123123123, 123123);

            contato.Telefones.Add(telefone);

            telefoneContatoContext.Contatos.Add(contato);
            telefoneContatoContext.Telefones.Add(telefone);

        }
        public static List<Contato> SelecionarContatos()
        {
            return telefoneContatoContext.Contatos.ToList();          

        }
        public static Contato SelecionarContatoPorID(int id)
        {
            return telefoneContatoContext.Contatos.ToList().Find(x => x.Id ==id);

        }
        public static void EditarContato(Contato contatoNovo, int id)
        {         
            Contato contatoVeio = SelecionarContatoPorID(id);          
            contatoNovo.Id = id;
            
            telefoneContatoContext.Entry(contatoVeio).CurrentValues.SetValues(contatoNovo);

        }
        public static void ExcluirContato(int id)
        {
            Contato contato = SelecionarContatoPorID(id);

            telefoneContatoContext.Contatos.Remove(contato);                     

        }
    }
}
