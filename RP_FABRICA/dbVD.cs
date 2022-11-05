using RP_FABRICA.Migrations;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.IO;


namespace RP_FABRICA
{
    public partial class DbVD : DbContext
    {
     
        public DbVD() : base("name=dbVD")
        {
            this.Configuration.LazyLoadingEnabled = false;
     
            
        }

        public DbVD(bool flag) : base("name=dbVD")
        {
            if (!flag)
            {
                try
                {
                    Database.SetInitializer(new MigrateDatabaseToLatestVersion<DbVD, Configuration>());
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(@"Não foi possível aplicar os pacotes de atualização. Contate o suporte. \n\n ** Um log está disponível para consulta no C:\Temp ** ", "Atenção", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                   // Valida.GravarLog(ex.InnerException.Message);
                }

            }
            else
            {
                this.Configuration.LazyLoadingEnabled = true;
            }

        }


        public virtual DbSet<tusuarios> tusuarios { get; set; }

       public virtual DbSet<tfuncionarios> tfuncionarios { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Tplanoconta>(entity =>
            //{
            //    entity.HasKey(e => e.Id).HasName("HBADI_PK");
            //    entity.HasIndex(e => e.CategoryId).HasName("HBADI_01");
            //    entity.HasOne(e => e.Category).WithMany().HasForeignKey(x => x.CategoryId).HasConstraintName("HBAFR_HBAD1").OnDelete(DeleteBehavior.Restrict);

            //});


            //modelBuilder.Entity<tconta>()
            //    .HasIndex(e => e.tplanoconta_id).HasName("fk_plan_id");


            //    modelBuilder.Entity<tconta>()
            //.HasOne(p => p.Blog)
            //.WithMany(b => b.tplanoconta);

       //     modelBuilder.Entity<tconta>()
       //.HasOne(p => p.Blog)
       //.WithMany(b => b.Posts)
       //.HasForeignKey(p => p.BlogId)
       //.HasConstraintName("ForeignKey_Post_Blog");



            //    modelBuilder.Entity<tplanoconta>()
            //        .HasMany(e => e.tconta)
            //        .WithRequired(e => e.tplanoconta)
            //        .HasForeignKey(e => e.tplanoconta_id)
            //        .WillCascadeOnDelete(false);

        }
    }

}
