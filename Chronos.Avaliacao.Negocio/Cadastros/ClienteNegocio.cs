using Chronos.Avaliacao.Negocio.Interface.Cadastros;
using Chronos.Avaliacao.Repositorio.Inteface.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Avaliacao.Negocio.Cadastros
{
    internal class ClienteNegocio : IClienteNegocio
    {
        private readonly IClienteRepositorio _repositorio;
        public ClienteNegocio(IClienteRepositorio clienterepositorio)
        {
            _repositorio = clienterepositorio;
        }
        public IClienteRepositorio GetRepositorio() { return _repositorio; }
    }
}
