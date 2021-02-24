namespace ASPNet_API_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tb_M_Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tb_M_Employees", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Tb_M_Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        EmailAddres = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Addres = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tb_M_Accounts", "Id", "dbo.Tb_M_Employees");
            DropIndex("dbo.Tb_M_Accounts", new[] { "Id" });
            DropTable("dbo.Tb_M_Employees");
            DropTable("dbo.Tb_M_Accounts");
        }
    }
}
