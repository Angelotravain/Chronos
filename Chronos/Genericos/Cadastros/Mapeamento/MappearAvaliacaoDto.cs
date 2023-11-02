using Chronos.Avaliacao.DTO.Anamnese;
using Chronos.Avaliacao.DTO.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Genericos.Cadastros.Mapeamento
{
    public class MappearAvaliacaoDto
    {
        public AvaliacaoFisicaDTO ObtenhaDadosAtualizadosAvaliacao(string idCliente, decimal peso, decimal altura, decimal abdominal, decimal iliaca, decimal triceps, string objetivos, decimal pesoGordura = 0, decimal massaMuscular = 0, decimal imc = 0)
        {
            AvaliacaoFisicaDTO avaliacao = new();
            avaliacao.IdCliente = Convert.ToInt32(idCliente);
            avaliacao.Peso = peso;
            avaliacao.Altura = altura;
            avaliacao.CircunferenciaAbdomen = abdominal;
            avaliacao.CircunferenciaSuprailiaca = iliaca;
            avaliacao.CircunferenciaTriceptal = triceps;
            avaliacao.DataAvaliacao = DateTime.Now.ToUniversalTime();
            avaliacao.Objetivos = objetivos;
            avaliacao.PesoEmGordura = pesoGordura;
            avaliacao.MassaMuscular = massaMuscular;
            avaliacao.Imc = imc;

            return avaliacao;
        }
    }
}
