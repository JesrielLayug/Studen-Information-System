namespace StudenInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveGradeTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Grades");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnrollmentId = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
