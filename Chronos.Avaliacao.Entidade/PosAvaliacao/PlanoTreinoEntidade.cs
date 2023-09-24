﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Chronos.Avaliacao.Entidade.PosAvaliacao
{
    [Table("planodetreino")]
    public class PlanoTreinoEntidade
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("exercicioid")]
        public int ExercicioId { get; set; }

        [Column("clienteid")]
        public int ClienteId { get; set; }

        [Column("series")]
        public int? Series { get; set; }

        [Column("duracaoemminutos")]
        public int? DuracaoEmMinutos { get; set; }

        [Column("intervaloemsegundos")]
        public int? IntervaloEmSegundos { get; set; }
    }
}
