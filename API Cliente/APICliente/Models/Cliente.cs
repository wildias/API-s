namespace APICliente.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Int32 CPF { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
