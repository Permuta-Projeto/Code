using Permuta.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permuta.Dominio.Repositorio
{
    public class ClienteRepositorio
    {
        private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Cliente> Clientes
        {
            get { return _context.Clientes; }
        }




        public void Salvar(Cliente cliente)
        {
            if (cliente.ClienteID == 0)
            {
                //Salvado
                _context.Clientes.Add(cliente);
            }
            else
            {
                //Alteração
                Cliente prod = _context.Clientes.Find(cliente.ClienteID);

                if (prod != null)
                {
                    prod.Nome = cliente.Nome;
                    prod.CPF = cliente.CPF;
                    prod.Endereco = cliente.Endereco;
                    prod.Estado = cliente.Estado;
                    prod.Bairro = cliente.Bairro;
                    prod.Email = cliente.Email;
                    prod.Celular = cliente.Celular;
                    prod.Telefone = cliente.Telefone;
                    prod.Senha = cliente.Senha;
                }

            }

            _context.SaveChanges();
        }


        //Excluir

        public Cliente Excluir(int ClienteID)
        {

            Cliente clien = _context.Clientes.Find(ClienteID);

            if (clien != null)
            {
                _context.Clientes.Remove(clien);
                // _context.SaveChanges();
            }

            return clien;
        }
    }
}
