using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_FABRICA
{
    #region Eop Tfuncao
    public enum EopTfuncao
    {
        Sucesso,
        Erro,
        Outro
    }
    #endregion

    #region Tabela Tfuncao
    public class tfuncao
    {
        public tfuncao()
        {
        }
      
        public int id { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "O valor para chave ultrapassa o permitido para uma variável integer")]
        public int codigo { get; set; }

        [Index(IsUnique = true)]
        [StringLength(200)]
        [Required(ErrorMessage = "A descrição deve ser única e é obrigatória")]
        public string descricao { get; set; }
        public int cbo { get; set; }

        [StringLength(100, ErrorMessage = "A observação deve ter no máximo 100 caracteres.")]
        public string obs { get; set; }
 
    }

    #endregion

    #region Filtro TTfuncao
    public class ttfuncao
    {
        public tfuncao tfuncao;

    }
    #endregion

}
