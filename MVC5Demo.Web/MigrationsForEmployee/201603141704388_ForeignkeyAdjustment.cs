namespace MVC5Demo.Web.MigrationsForEmployee
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignkeyAdjustment : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("office.Employees", "Department_Id", "office.Departments");
            DropIndex("office.Employees", new[] { "Department_Id" });
            RenameColumn(table: "office.Employees", name: "Department_Id", newName: "DepartmentId");
            AlterColumn("office.Employees", "DepartmentId", c => c.Int(nullable: false));
            CreateIndex("office.Employees", "DepartmentId");
            AddForeignKey("office.Employees", "DepartmentId", "office.Departments", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("office.Employees", "DepartmentId", "office.Departments");
            DropIndex("office.Employees", new[] { "DepartmentId" });
            AlterColumn("office.Employees", "DepartmentId", c => c.Int());
            RenameColumn(table: "office.Employees", name: "DepartmentId", newName: "Department_Id");
            CreateIndex("office.Employees", "Department_Id");
            AddForeignKey("office.Employees", "Department_Id", "office.Departments", "Id");
        }
    }
}
