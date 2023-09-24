using Chronos.Avaliacao.Entidade.Anamnese;
using Chronos.Avaliacao.Entidade.Cadastros;
using Chronos.Avaliacao.Negocio.Interface.Anamnese;
using Chronos.Avaliacao.Repositorio.Inteface.Anamnesse;
using Chronos.Avaliacao.Repositorio.Inteface.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Avaliacao.Negocio.Anamnese
{
    internal class AvaliacaoFisicaNegocio : IAvaliacaoFisicaNegocio
    {
        private readonly IAvaliacaoFisicaRepositorio _avaliacaoRepositorio;
        private readonly IClienteRepositorio _clienteRepositorio;
        public AvaliacaoFisicaNegocio(IAvaliacaoFisicaRepositorio avaliacaorepositorio, IClienteRepositorio clienteRepositorio)
        {
            _avaliacaoRepositorio = avaliacaorepositorio;
            _clienteRepositorio = clienteRepositorio;
        }
        public IAvaliacaoFisicaRepositorio GetRepositorio() { return _avaliacaoRepositorio; }

        public void CriarAvaliacaoFisica(AvaliacaoFisicaEntidade avaliacao)
        {
            var cliente = _clienteRepositorio.RetornaClientePorIdParaAvaliacao(avaliacao.IdCliente);
            avaliacao.PorcentagemGordura = (decimal)CalculaGorduraCorporal(CalculaIdadeCliente(cliente), avaliacao);
            avaliacao.Imc = avaliacao.Peso / (avaliacao.Altura * avaliacao.Altura); // altura deve ser em metros
            avaliacao.PesoEmGordura = ((decimal)avaliacao.PorcentagemGordura / 100) * avaliacao.Peso;
            avaliacao.MassaMuscular = avaliacao.Peso - avaliacao.PesoEmGordura;
            _avaliacaoRepositorio.CriarAvaliacaoFisica(avaliacao);
        }
        private double CalculaGorduraCorporal(int idade, AvaliacaoFisicaEntidade avaliacao)
        {
            var CalculoGorduraCorporal = (0.29288 * ((double)avaliacao.CircunferenciaSuprailiaca +
                                                     (double)avaliacao.CircunferenciaTriceptal +
                                                     (double)avaliacao.CircunferenciaAbdomen))
                                       - (0.0005 * ((double)avaliacao.CircunferenciaSuprailiaca +
                                                     (double)avaliacao.CircunferenciaTriceptal +
                                                     (double)avaliacao.CircunferenciaAbdomen) * 2)
                                       + (0.15845 * idade) - 5.76377;

            return CalculoGorduraCorporal;
        }
        private int CalculaIdadeCliente(ClienteEntidade cliente)
        {
            DateTime dataDeNascimento = (DateTime)cliente.DataNascimento; // Substitua com a data de nascimento real
            DateTime dataAtual = DateTime.Today;

            int idade = dataAtual.Year - dataDeNascimento.Year;
            if (dataAtual < dataDeNascimento.AddYears(idade))
                idade--;

            return idade;
        }
    }
}
