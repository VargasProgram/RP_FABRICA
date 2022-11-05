namespace RP_FABRICA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.tfuncionarios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cod = c.String(maxLength: 50),
                        nome = c.String(maxLength: 100),
                        sit = c.Boolean(nullable: false),
                        tusuarios_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("public.tusuarios", t => t.tusuarios_id, name: "Fk_tus_id")
                .Index(t => t.cod, unique: true)
                .Index(t => t.nome, unique: true)
                .Index(t => t.tusuarios_id);
            
            CreateTable(
                "public.tusuarios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        login = c.String(nullable: false, maxLength: 200),
                        senha = c.String(nullable: false),
                        nome = c.String(nullable: false, maxLength: 200),
                        sit = c.Boolean(nullable: false),
                        email = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.id)
                .Index(t => t.login, unique: true)
                .Index(t => t.nome, unique: true)
                .Index(t => t.email, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.tfuncionarios", "Fk_tus_id", "public.tusuarios");
            DropIndex("public.tusuarios", new[] { "email" });
            DropIndex("public.tusuarios", new[] { "nome" });
            DropIndex("public.tusuarios", new[] { "login" });
            DropIndex("public.tfuncionarios", new[] { "Fk_tus_id" });
            DropIndex("public.tfuncionarios", new[] { "nome" });
            DropIndex("public.tfuncionarios", new[] { "cod" });
            DropTable("public.tusuarios");
            DropTable("public.tfuncionarios");
        }
    }
}
