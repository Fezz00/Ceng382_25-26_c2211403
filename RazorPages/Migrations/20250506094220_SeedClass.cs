using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorPages.Migrations
{
    /// <inheritdoc />
    public partial class SeedClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "ClassName", "Description", "StudentCount", "isActive" },
                values: new object[,]
                {
                    { 1, "Class 1", "Class 1 Description", 2, true },
                    { 2, "Class 2", "Class 2 Description", 4, true },
                    { 3, "Class 3", "Class 3 Description", 6, true },
                    { 4, "Class 4", "Class 4 Description", 8, true },
                    { 5, "Class 5", "Class 5 Description", 10, true },
                    { 6, "Class 6", "Class 6 Description", 12, true },
                    { 7, "Class 7", "Class 7 Description", 14, true },
                    { 8, "Class 8", "Class 8 Description", 16, true },
                    { 9, "Class 9", "Class 9 Description", 18, true },
                    { 10, "Class 10", "Class 10 Description", 20, true },
                    { 11, "Class 11", "Class 11 Description", 22, true },
                    { 12, "Class 12", "Class 12 Description", 24, true },
                    { 13, "Class 13", "Class 13 Description", 26, true },
                    { 14, "Class 14", "Class 14 Description", 28, true },
                    { 15, "Class 15", "Class 15 Description", 30, true },
                    { 16, "Class 16", "Class 16 Description", 32, true },
                    { 17, "Class 17", "Class 17 Description", 34, true },
                    { 18, "Class 18", "Class 18 Description", 36, true },
                    { 19, "Class 19", "Class 19 Description", 38, true },
                    { 20, "Class 20", "Class 20 Description", 40, true },
                    { 21, "Class 21", "Class 21 Description", 42, true },
                    { 22, "Class 22", "Class 22 Description", 44, true },
                    { 23, "Class 23", "Class 23 Description", 46, true },
                    { 24, "Class 24", "Class 24 Description", 48, true },
                    { 25, "Class 25", "Class 25 Description", 50, true },
                    { 26, "Class 26", "Class 26 Description", 52, true },
                    { 27, "Class 27", "Class 27 Description", 54, true },
                    { 28, "Class 28", "Class 28 Description", 56, true },
                    { 29, "Class 29", "Class 29 Description", 58, true },
                    { 30, "Class 30", "Class 30 Description", 60, true },
                    { 31, "Class 31", "Class 31 Description", 62, true },
                    { 32, "Class 32", "Class 32 Description", 64, true },
                    { 33, "Class 33", "Class 33 Description", 66, true },
                    { 34, "Class 34", "Class 34 Description", 68, true },
                    { 35, "Class 35", "Class 35 Description", 70, true },
                    { 36, "Class 36", "Class 36 Description", 72, true },
                    { 37, "Class 37", "Class 37 Description", 74, true },
                    { 38, "Class 38", "Class 38 Description", 76, true },
                    { 39, "Class 39", "Class 39 Description", 78, true },
                    { 40, "Class 40", "Class 40 Description", 80, true },
                    { 41, "Class 41", "Class 41 Description", 82, true },
                    { 42, "Class 42", "Class 42 Description", 84, true },
                    { 43, "Class 43", "Class 43 Description", 86, true },
                    { 44, "Class 44", "Class 44 Description", 88, true },
                    { 45, "Class 45", "Class 45 Description", 90, true },
                    { 46, "Class 46", "Class 46 Description", 92, true },
                    { 47, "Class 47", "Class 47 Description", 94, true },
                    { 48, "Class 48", "Class 48 Description", 96, true },
                    { 49, "Class 49", "Class 49 Description", 98, true },
                    { 50, "Class 50", "Class 50 Description", 100, true },
                    { 51, "Class 51", "Class 51 Description", 102, true },
                    { 52, "Class 52", "Class 52 Description", 104, true },
                    { 53, "Class 53", "Class 53 Description", 106, true },
                    { 54, "Class 54", "Class 54 Description", 108, true },
                    { 55, "Class 55", "Class 55 Description", 110, true },
                    { 56, "Class 56", "Class 56 Description", 112, true },
                    { 57, "Class 57", "Class 57 Description", 114, true },
                    { 58, "Class 58", "Class 58 Description", 116, true },
                    { 59, "Class 59", "Class 59 Description", 118, true },
                    { 60, "Class 60", "Class 60 Description", 120, true },
                    { 61, "Class 61", "Class 61 Description", 122, true },
                    { 62, "Class 62", "Class 62 Description", 124, true },
                    { 63, "Class 63", "Class 63 Description", 126, true },
                    { 64, "Class 64", "Class 64 Description", 128, true },
                    { 65, "Class 65", "Class 65 Description", 130, true },
                    { 66, "Class 66", "Class 66 Description", 132, true },
                    { 67, "Class 67", "Class 67 Description", 134, true },
                    { 68, "Class 68", "Class 68 Description", 136, true },
                    { 69, "Class 69", "Class 69 Description", 138, true },
                    { 70, "Class 70", "Class 70 Description", 140, true },
                    { 71, "Class 71", "Class 71 Description", 142, true },
                    { 72, "Class 72", "Class 72 Description", 144, true },
                    { 73, "Class 73", "Class 73 Description", 146, true },
                    { 74, "Class 74", "Class 74 Description", 148, true },
                    { 75, "Class 75", "Class 75 Description", 150, true },
                    { 76, "Class 76", "Class 76 Description", 152, true },
                    { 77, "Class 77", "Class 77 Description", 154, true },
                    { 78, "Class 78", "Class 78 Description", 156, true },
                    { 79, "Class 79", "Class 79 Description", 158, true },
                    { 80, "Class 80", "Class 80 Description", 160, true },
                    { 81, "Class 81", "Class 81 Description", 162, true },
                    { 82, "Class 82", "Class 82 Description", 164, true },
                    { 83, "Class 83", "Class 83 Description", 166, true },
                    { 84, "Class 84", "Class 84 Description", 168, true },
                    { 85, "Class 85", "Class 85 Description", 170, true },
                    { 86, "Class 86", "Class 86 Description", 172, true },
                    { 87, "Class 87", "Class 87 Description", 174, true },
                    { 88, "Class 88", "Class 88 Description", 176, true },
                    { 89, "Class 89", "Class 89 Description", 178, true },
                    { 90, "Class 90", "Class 90 Description", 180, true },
                    { 91, "Class 91", "Class 91 Description", 182, true },
                    { 92, "Class 92", "Class 92 Description", 184, true },
                    { 93, "Class 93", "Class 93 Description", 186, true },
                    { 94, "Class 94", "Class 94 Description", 188, true },
                    { 95, "Class 95", "Class 95 Description", 190, true },
                    { 96, "Class 96", "Class 96 Description", 192, true },
                    { 97, "Class 97", "Class 97 Description", 194, true },
                    { 98, "Class 98", "Class 98 Description", 196, true },
                    { 99, "Class 99", "Class 99 Description", 198, true },
                    { 100, "Class 100", "Class 100 Description", 200, true },
                    { 101, "Class 101", "Class 101 Description", 202, true },
                    { 102, "Class 102", "Class 102 Description", 204, true },
                    { 103, "Class 103", "Class 103 Description", 206, true },
                    { 104, "Class 104", "Class 104 Description", 208, true },
                    { 105, "Class 105", "Class 105 Description", 210, true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 105);
        }
    }
}
