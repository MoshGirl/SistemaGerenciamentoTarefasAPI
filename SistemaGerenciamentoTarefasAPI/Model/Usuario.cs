﻿namespace SistemaGerenciamentoTarefasAPI.Model
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Nome { get; set; }
        public string Email{ get; set;}
        public string Senha { get; set; }

        public ICollection<Tarefa> Tarefas { get; set; }
    }
}