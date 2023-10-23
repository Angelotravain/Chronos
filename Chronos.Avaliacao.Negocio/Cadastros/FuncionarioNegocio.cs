using Chronos.Avaliacao.Entidade.Cadastros;
using Chronos.Avaliacao.Negocio.Interface.Cadastros;
using Chronos.Avaliacao.Repositorio.Inteface.Cadastros;
using Chronos.Avaliacao.Repositorio.Inteface.Generico;

namespace Chronos.Avaliacao.Negocio.Cadastros
{
    internal class FuncionarioNegocio : IFuncionarioNegocio
    {
        private readonly IFuncionarioRepositorio _funcionarioRepositorio;
        private readonly IGenerico _classeGenerica;
        public FuncionarioNegocio(IFuncionarioRepositorio funcionarioRepositorio, IGenerico classeGenerica)
        {
            _funcionarioRepositorio = funcionarioRepositorio;
            _classeGenerica = classeGenerica;
        }
        public void SalvarFuncionario(FuncionarioEntidade funcionario)
        {
            _classeGenerica.Salvar<FuncionarioEntidade>(funcionario);
        }
        public void EditarFuncionario(FuncionarioEntidade funcionario)
        {
            _classeGenerica.Editar<FuncionarioEntidade>(funcionario, funcionario.Id);
        }
        public void ExcluirFuncionario(int idFuncionario)
        {
            _classeGenerica.Excluir<FuncionarioEntidade>(idFuncionario);
        }
        public IEnumerable<FuncionarioEntidade> BuscarTodosOsFuncionarios()
        {
            return _funcionarioRepositorio.BuscarTodosOsFuncionarios();
        }
        public IEnumerable<FuncionarioEntidade> BuscarFuncionarioPeloNome(string nome)
        {
            return _funcionarioRepositorio.BuscarFuncionarioPeloNome(nome);
        }
        public FuncionarioEntidade BuscarFuncionarioPorId(int id)
        {
            return _funcionarioRepositorio.BuscarFuncionarioPorId(id);
        }
    }
}
