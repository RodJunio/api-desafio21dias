using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_desafio21dias.Models
{
    [Table("tb_fornecedor")]
    public partial class Fornecedor
    {
        [Key]
        [Column("cod_cfo")]
        public int Id { get; set; }

        [Column("nome_fantasia")]
        public string NomeFantasia { get; set; }

        [Column("razao")]
        public string RazaoSocial { get; set; }

        [Column("cpf_cnpj")]
        public string Cpf_Cnpj { get; set; }

        [NotMapped]
        public string Cnpj { get { return this.Cpf_Cnpj; } set { this.Cpf_Cnpj = value; } }
        
        [NotMapped]
        public string Cpf { get { return this.Cpf_Cnpj; } set { this.Cpf_Cnpj = value; } }

        [Column("endereco")]
        public string Endereco { get; set; }
    }
}
