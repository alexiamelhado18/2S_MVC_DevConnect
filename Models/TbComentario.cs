using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnectMoura.Models;

[Table("tb_comentario")]
public partial class TbComentario
{
    [Key]
    [Column("id_comentario")]
    public int IdComentario { get; set; }

    [Column("texto")]
    [StringLength(155)]
    public string Texto { get; set; } = null!;

    [Column("data_coment")]
    public DateOnly DataComent { get; set; }

    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Column("id_publicacao")]
    public int IdPublicacao { get; set; }

    [ForeignKey("IdPublicacao")]
    [InverseProperty("TbComentario")]
    public virtual TbPublicacao IdPublicacaoNavigation { get; set; } = null!;

    [ForeignKey("IdUsuario")]
    [InverseProperty("TbComentario")]
    public virtual TbUsuario IdUsuarioNavigation { get; set; } = null!;
}
