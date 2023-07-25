using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVC_CRUD_SQLServer_ASPNET.Models;

public partial class MvccrudContext : DbContext
{
    public MvccrudContext()
    {
    }

    public MvccrudContext(DbContextOptions<MvccrudContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
		//Esta es una de las líneas que hay que agregar y modificar para las conexiones ATENCIÓN!!!! Comentarlas y coger información

		//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
		//        => optionsBuilder.UseSqlServer("server=DESKTOP-QHVV51P\\SQLEXPRESS; database=MVCCRUD; integrated security=true; TrustServerCertificate=true;");
	}


	protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuarios__3214EC078BC57C7D");

            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ciudad).HasMaxLength(50) //añado esta línea para Ciudad
                .IsUnicode(false); // y esta le continúa
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
