using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentAspNetCore.Service.Migrations
{
    public partial class AddNewdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Students_StudentId",
                table: "Contact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.RenameTable(
                name: "Contact",
                newName: "Contacts");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_StudentId",
                table: "Contacts",
                newName: "IX_Contacts_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "PhoneNumber", "StudentId", "Url" },
                values: new object[] { 1L, "094289194", 1, null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "PhoneNumber", "StudentId", "Url" },
                values: new object[] { 2L, "093258233", 2, null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "PhoneNumber", "StudentId", "Url" },
                values: new object[] { 3L, "038129492", 3, null });

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Students_StudentId",
                table: "Contacts",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Students_StudentId",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Contact");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_StudentId",
                table: "Contact",
                newName: "IX_Contact_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Students_StudentId",
                table: "Contact",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
