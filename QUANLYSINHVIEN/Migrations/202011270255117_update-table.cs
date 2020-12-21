namespace QUANLYSINHVIEN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DiemThis", "TenSv", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DiemThis", "TenSv");
        }
    }
}
