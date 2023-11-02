using Chronos.Avaliacao.DTO.Cadastros;

namespace Chronos.Genericos.Cadastros.Mapeamento
{
    public class MappearExercicioDto
    {
        public ExercicioDTO ObtenhaDadosAtualizadosDoExercicio(string id, bool editarExercicio, string exercicioEntrada, string intensidade, string grupoMuscular, byte[] imagemExercicio)
        {
            ExercicioDTO exercicio = new();
            if (editarExercicio)
                exercicio.Id = Convert.ToInt32(id);

            exercicio.Nome = exercicioEntrada;
            exercicio.GrupoMuscular = grupoMuscular;
            exercicio.Intensidade = intensidade;
            exercicio.ImagemExercicio = imagemExercicio;


            return exercicio;
        }
    }
}
