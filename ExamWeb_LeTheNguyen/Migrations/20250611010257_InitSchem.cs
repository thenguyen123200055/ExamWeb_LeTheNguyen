using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWeb_LeTheNguyen.Migrations
{
    public partial class InitSchem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiaNhacs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TuaCD = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    
                    TheLoai = table.Column<bool>(type: "bit", nullable: false),
                    GiaBan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuong = table.Column<double>(type: "float", nullable: false),
                   
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaNhacs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiaNhacs");
        }
    }
}
