using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repos.Migrations
{
    public partial class insertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DeptNo", "DeptName", "Location" },
                values: new object[,]
                {
                    { 1, "Smart Village Branch", 0 },
                    { 2, "Alex Branch", 1 },
                    { 3, "Suez Branch", 2 }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectNo", "Budget", "ProjectName" },
                values: new object[,]
                {
                    { 1, 1000000m, "Recycle Project" },
                    { 2, 20000000m, "Developing Project" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmpNo", "DeptNo", "Fname", "Lname", "Salary" },
                values: new object[,]
                {
                    { 1, 1, "Ahmed", "Mahmoud", 10000m },
                    { 2, 1, "Ahmed", "Mostafa", 8000m },
                    { 3, 1, "Belal", "Anan", 8000m },
                    { 4, 2, "Mohamed", "Moslem", 11000m },
                    { 5, 3, "Mona", "Hafez", 12000m }
                });

            migrationBuilder.InsertData(
                table: "Works_on",
                columns: new[] { "EmpNo", "ProjectNo", "Enter_Date", "Job" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 6, 1, 12, 53, 53, 293, DateTimeKind.Local).AddTicks(6582), "Build the project" },
                    { 2, 1, new DateTime(2021, 6, 1, 12, 53, 53, 297, DateTimeKind.Local).AddTicks(3775), "Build the plan" },
                    { 3, 1, new DateTime(2021, 6, 1, 12, 53, 53, 297, DateTimeKind.Local).AddTicks(3803), "Start the project" },
                    { 4, 2, new DateTime(2021, 6, 1, 12, 53, 53, 297, DateTimeKind.Local).AddTicks(3806), "Build the project" },
                    { 5, 2, new DateTime(2021, 6, 1, 12, 53, 53, 297, DateTimeKind.Local).AddTicks(3808), "Build the project" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Works_on",
                keyColumns: new[] { "EmpNo", "ProjectNo" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Works_on",
                keyColumns: new[] { "EmpNo", "ProjectNo" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Works_on",
                keyColumns: new[] { "EmpNo", "ProjectNo" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Works_on",
                keyColumns: new[] { "EmpNo", "ProjectNo" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "Works_on",
                keyColumns: new[] { "EmpNo", "ProjectNo" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmpNo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmpNo",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmpNo",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmpNo",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmpNo",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectNo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectNo",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DeptNo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DeptNo",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DeptNo",
                keyValue: 3);
        }
    }
}
