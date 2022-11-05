
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_FABRICA
{
    #region Eop Tfuncionarios
    public enum EopTfuncionarios
    {
        Sucesso,
        Erro,
        Outro
    }

    #endregion

    #region Tabela Tfuncionarios

    [Table("public.tfuncionarios")]
    public class tfuncionarios
    {
        [Key]
        public int id { get; set; }

        [Index(IsUnique = true)]
        [StringLength(50)]
        public string cod { get; set; }

        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        [Index(IsUnique = true)]
        public string nome { get; set; }
        public bool sit { get; set; }

        [ForeignKey("tusuarios")]
        public int? tusuarios_id { get; set; }
        public virtual tusuarios tusuarios { get; set; }

    }

    #endregion

    #region ttfuncionarios

    public class ttfuncionarios
    {
        public tfuncionarios tfuncionarios;
    }

    #endregion

}
