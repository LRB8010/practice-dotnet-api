using API.Data;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class _0_1_0_Users_Data_Seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var assemblyFullPath = System.Reflection.Assembly.GetAssembly(typeof(DataContext)).Location;
            var assemblyPath = System.IO.Path.GetDirectoryName(assemblyFullPath);

            var sqlFile = System.IO.Path.Combine(assemblyPath, "DataSeeding\\0_1_0_Users.sql");
            migrationBuilder.Sql(System.IO.File.ReadAllText(sqlFile));

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
