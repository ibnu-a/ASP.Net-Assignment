namespace ASPNet_API_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaaa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tb_M_Employees", "EmailAddress", c => c.String(nullable: false));
            DropColumn("dbo.Tb_M_Employees", "EmailAddres");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tb_M_Employees", "EmailAddres", c => c.String(nullable: false));
            DropColumn("dbo.Tb_M_Employees", "EmailAddress");
        }
    }
}
