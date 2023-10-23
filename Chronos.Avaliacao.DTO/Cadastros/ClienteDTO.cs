namespace Chronos.Avaliacao.DTO.Cadastros
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string? Endereco { get; set; }
        public string? NumeroTelefone { get; set; }
        public string? Email { get; set; }
        public DateTime? DataIngresso { get; set; }
    }
}
