using Chronos.Avaliacao.DTO.Cadastros;

namespace Chronos.Genericos.Cadastros.Mapeamento
{
    public class MappearClienteDto
    {
        public ClienteDTO ObtenhaDadosAtualizadosDoCliente(string id, bool editarCliente, string nome, string email, string sobrenome, string telefone, string endereco, DateTime dataNascimento)
        {
            ClienteDTO cliente = new();
            if (editarCliente)
                cliente.Id = Convert.ToInt32(id);

            cliente.Nome = nome;
            cliente.Email = email;
            cliente.Sobrenome = sobrenome;
            cliente.NumeroTelefone = telefone;
            cliente.Endereco = endereco;
            cliente.DataNascimento = dataNascimento.ToUniversalTime();
            cliente.DataIngresso = DateTime.Now.ToUniversalTime();

            return cliente;
        }
    }
}
