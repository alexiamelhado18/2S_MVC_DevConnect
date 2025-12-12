using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnectMoura.Models;

[Table("tb_curtida")]
[Index("IdUsuario", "IdPublicacao", Name = "UQ__tb_curti__F0961F6FA135975D", IsUnique = true)]
public partial class TbCurtida
{
    [Key]
    [Column("id_curtida")]
    public int IdCurtida { get; set; }

    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Column("id_publicacao")]
    public int IdPublicacao { get; set; }

    [ForeignKey("IdPublicacao")]
    [InverseProperty("TbCurtida")]
    public virtual TbPublicacao IdPublicacaoNavigation { get; set; } = null!;

    [ForeignKey("IdUsuario")]
    [InverseProperty("TbCurtida")]
    public virtual TbUsuario IdUsuarioNavigation { get; set; } = null!;
}
