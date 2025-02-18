namespace SistemaGerenciamentoTarefasAPI.Model
{
    public class Tarefa
    {
        public int TarefaID { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDeCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public DateTime? DataConclusao { get; set; }
        public int Status { get; set; }

        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }
    }
}