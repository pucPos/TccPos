using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMedForms.Models
{
    [Table("Solicitacao")]
    public class Solicitacao
    {

        [Display(Name ="Código")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome Médico Solicitante")]
        [Column("nome_medico")]
        public string NomeMedicoSolicitante { get; set; }

        [Display(Name = "CRM")]
        [Column("crm")]
        public string CrmMedicoSolicitante { get; set; }

        [Display(Name = "Chave Autenticação")]
        [Column("chave_autenticacao")]
        public string ChaveAutenticacao { get; set; }

        [Display(Name = "Nome Paciente")]
        [Column("nome_paciente")]
        public string NomePaciente { get; set; }

        [Display(Name = "CPF")]
        [Column("cpf")]
        public string CPF { get; set; }

        [Display(Name = "RG")]
        [Column("rg")]
        public string RG { get; set; }

        [Display(Name = "Cad. Único Saúde")]
        [Column("cad_unico_saude")]
        public string CadUnicoSaude { get; set; }

        [Display(Name = "Telefone")]
        [Column("telefone")]
        public string Telefone { get; set; }

        [Display(Name = "Celular")]
        [Column("celular")]
        public string Celular { get; set; }

        [Display(Name = "Email")]
        [Column("email")]
        public string Email { get; set; }

        [Display(Name = "Endereço")]
        [Column("endereco")]
        public string Endereco { get; set; }

        [Display(Name = "Complemento")]
        [Column("complemento")]
        public string Complemento { get; set; }

        [Display(Name = "Cidade")]
        [Column("cidade")]
        public string Cidade { get; set; }

        [Display(Name = "Estado")]
        [Column("estado")]
        public string Estado { get; set; }

        [Display(Name = "Cep")]
        [Column("cep")]
        public string CEP { get; set; }

        [Display(Name = "CID")]
        [Column("cid")]
        public string CID { get; set; }

        [Display(Name = "Indicação Médica")]
        [Column("indicacao_medica")]
        public string IndicacaoMedica { get; set; }

        [Display(Name = "Indicação Tratamento")]
        [Column("indicacao_tratamento")]
        public int IndicacaoTratamento { get; set; }

    }
}
