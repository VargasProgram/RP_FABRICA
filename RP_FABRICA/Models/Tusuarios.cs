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
        [Required(ErrorMessage = "O Login é obrigatório.")]
        public string login { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória.")]
        public string senha { get; set; }

        [Index(IsUnique = true)]
        [StringLength(200)]
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string nome { get; set; }

        public bool sit { get; set; }

        [Index(IsUnique = true)]
        [StringLength(200)]
        [Required(ErrorMessage = "O email é obrigatório.")]
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
