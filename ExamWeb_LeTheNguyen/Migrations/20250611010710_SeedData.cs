using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWeb_LeTheNguyen.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaNhacs",
                columns: new[] { "Id", "TuaCD", "TheLoai", "GiaBan", "SoLuong"},
                values: new object[,]
                {
                    { 1, "Hôn em thật lâu", true, 9000, "10" },
                    { 2, "Intentions", false, 900, "10" },
                    { 3, "Somebody Pleasure", default, 1000, "10" },
                    { 4, "LimBo", false, 2400, "10" },
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaNhac",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
