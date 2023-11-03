using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos
{
    public static class URL
    {
        public static string UrlCliente() { return "https://localhost:5001/api/Cliente"; }
        public static string UrlExercicio() { return "https://localhost:5001/api/Exercicio"; }
        public static string UrlFuncionario() { return "https://localhost:5001/api/Funcionario"; }
        public static string UrlUsuario() { return "https://localhost:5001/api/Usuario"; }
        public static string UrlAgendamento() { return "https://localhost:5001/api/Agendamento"; }
        public static string UrlAvaliacao() { return "https://localhost:5001/api/AvaliacaoFisica"; }
        public static string UrlPlanoTreino(int idCliente) { return $"https://localhost:5001/api/PlanoTreino/{idCliente}"; }
        public static string UrlPlanoTreinoPost() { return $"https://localhost:5001/api/PlanoTreino"; }

    }
}
