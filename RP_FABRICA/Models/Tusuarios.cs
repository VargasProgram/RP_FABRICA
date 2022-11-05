using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace RP_FABRICA
{
    #region Eop tusuarios

    enum EopTusuario
    {
        Sucesso,
        Erro,
        Outro
    }

    #endregion

    #region Tabela Tusuarios

    [Table("public.tusuarios")]
    public partial class tusuarios
    {

        [Key]
        public int id { get; set; }

        [Index(IsUnique = true)]
        [StringLength(200)]
        [Required(ErrorMessage = "O Login � obrigat�rio.")]
        public string login { get; set; }
        [Required(ErrorMessage = "A senha � obrigat�ria.")]
        public string senha { get; set; }

        [Index(IsUnique = true)]
        [StringLength(200)]
        [Required(ErrorMessage = "O nome � obrigat�rio.")]
        public string nome { get; set; }

        public bool sit { get; set; }

        [Index(IsUnique = true)]
        [StringLength(200)]
        [Required(ErrorMessage = "O email � obrigat�rio.")]
        public string email { get; set; }
    }
    #endregion

    #region Filtro TTusuario
    public class ttusuario
    {
        public tusuarios tusuarios;
    }

    #endregion

}
