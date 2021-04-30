namespace OOD_ProjectShells.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Components",
                c => new
                    {
                        Component = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Component);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Components");
        }
    }
}
