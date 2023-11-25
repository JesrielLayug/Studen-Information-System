namespace StudenInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditCourseTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "StudentId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "StudentId");
        }
    }
}
