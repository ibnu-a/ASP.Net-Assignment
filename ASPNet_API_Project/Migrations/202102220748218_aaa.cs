namespace ASPNet_API_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tb_M_Employees", "Address", c => c.String(nullable: false));
            DropColumn("dbo.Tb_M_Employees", "Addres");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tb_M_Employees", "Addres", c => c.String(nullable: false));
            DropColumn("dbo.Tb_M_Employees", "Address");
        }
    }
}
