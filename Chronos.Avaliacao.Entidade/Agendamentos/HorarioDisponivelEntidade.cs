﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Chronos.Avaliacao.Entidade.Agendamentos
{
    [Table("horariosdisponiveis")]
    public class HorarioDisponivelEntidade
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("idfuncionario")]
        public int IdFuncionario { get; set; }

        [Column("diadasemana")]
        public string? DiaDaSemana { get; set; }

        [Column("horadeinicio")]
        public TimeSpan HoraDeInicio { get; set; }

        [Column("horadetermino")]
        public TimeSpan HoraDeTermino { get; set; }

        [Column("disponibilidade")]
        public bool Disponibilidade { get; set; }
    }
}
