using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repos.Migrations
{
    public partial class Modify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DeptNo",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Works_on_Employee_EmpNo",
                table: "Works_on");

            migrationBuilder.DropForeignKey(
                name: "FK_Works_on_Project_ProjectNo",
                table: "Works_on");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Works_on",
                table: "Works_on");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.RenameTable(
                name: "Works_on",
                newName: "Works_Ons");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameIndex(
                name: "IX_Works_on_EmpNo",
                table: "Works_Ons",
                newName: "IX_Works_Ons_EmpNo");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_DeptNo",
                table: "Employees",
                newName: "IX_Employees_DeptNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Works_Ons",
                table: "Works_Ons",
                columns: new[] { "ProjectNo", "EmpNo" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "ProjectNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmpNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "DeptNo");

            migrationBuilder.UpdateData(
                table: "Works_Ons",
                keyColumns: new[] { "EmpNo", "ProjectNo" },
                keyValues: new object[] { 1, 1 },
                column: "Enter_Date",
                value: new DateTime(2021, 6, 1, 14, 51, 15, 442, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "Works_Ons",
                keyColumns: new[] { "EmpNo", "ProjectNo" },
                keyValues: new object[] { 2, 1 },
                column: "Enter_Date",
                value: new DateTime(2021, 6, 1, 14, 51, 15, 443, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "Works_Ons",
                keyColumns: new[] { "EmpNo", "ProjectNo" },
                keyValues: new object[] { 3, 1 },
                column: "Enter_Date",
                value: new DateTime(2021, 6, 1, 14, 51, 15, 443, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Works_Ons",
                keyColumns: new[] { "EmpNo", "ProjectNo" },
                keyValues: new object[] { 4, 2 },
                column: "Enter_Date",
                value: new DateTime(2021, 6, 1, 14, 51, 15, 443, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Works_Ons",
                keyColumns: new[] { "EmpNo", "ProjectNo" },
                keyValues: new object[] { 5, 2 },
                column: "Enter_Date",
                value: new DateTime(2021, 6, 1, 14, 51, 15, 443, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DeptNo",
                table: "Employees",
                column: "DeptNo",
                principalTable: "Departments",
                principalColumn: "DeptNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Ons_Employees_EmpNo",
                table: "Works_Ons",
                column: "EmpNo",
                principalTable: "Employees",
                principalColumn: "EmpNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Ons_Projects_ProjectNo",
                table: "Works_Ons",
                column: "ProjectNo",
                principalTable: "Projects",
                principalColumn: "ProjectNo",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DeptNo",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Works_Ons_Employees_EmpNo",
                table: "Works_Ons");

            migrationBuilder.DropForeignKey(
                name: "FK_Works_Ons_Projects_ProjectNo",
                table: "Works_Ons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Works_Ons",
                table: "Works_Ons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Works_Ons",
                newName: "Works_on");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameIndex(
                name: "IX_Works_Ons_EmpNo",
                table: "Works_on",
                newName: "IX_Works_on_EmpNo");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DeptNo",
                table: "Employee",
                newName: "IX_Employee_DeptNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Works_on",
                table: "Works_on",
                columns: new[] { "ProjectNo", "EmpNo" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "ProjectNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "EmpNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "DeptNo");

            migrationBuilder.UpdateData(
                table: "Works_on",
                keyColumns: new[] { "EmpNo", "ProjectNo" },
                keyValues: new object[] { 1, 1 },
                column: "Enter_Date",
                value: new DateTime(2021, 6, 1, 12, 53, 53, 293, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Works_on",
                keyColumns: new[] { "EmpNo", "ProjectNo" },
                keyValues: new object[] { 2, 1 },
                column: "Enter_Date",
                value: new DateTime(2021, 6, 1, 12, 53, 53, 297, DateTimeKind.Local).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "Works_on",
                keyColumns: new[] { "EmpNo", "ProjectNo" },
                keyValues: new object[] { 3, 1 },
                column: "Enter_Date",
                value: new DateTime(2021, 6, 1, 12, 53, 53, 297, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Works_on",
                keyColumns: new[] { "EmpNo", "ProjectNo" },
                keyValues: new object[] { 4, 2 },
                column: "Enter_Date",
                value: new DateTime(2021, 6, 1, 12, 53, 53, 297, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Works_on",
                keyColumns: new[] { "EmpNo", "ProjectNo" },
                keyValues: new object[] { 5, 2 },
                column: "Enter_Date",
                value: new DateTime(2021, 6, 1, 12, 53, 53, 297, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DeptNo",
                table: "Employee",
                column: "DeptNo",
                principalTable: "Department",
                principalColumn: "DeptNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Works_on_Employee_EmpNo",
                table: "Works_on",
                column: "EmpNo",
                principalTable: "Employee",
                principalColumn: "EmpNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Works_on_Project_ProjectNo",
                table: "Works_on",
                column: "ProjectNo",
                principalTable: "Project",
                principalColumn: "ProjectNo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
