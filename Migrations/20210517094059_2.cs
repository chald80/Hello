using Microsoft.EntityFrameworkCore.Migrations;

namespace Hello.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_(Info_Profile_ProfileId",
                table: "(Info");

            migrationBuilder.DropPrimaryKey(
                name: "PK_(Info",
                table: "(Info");

            migrationBuilder.RenameTable(
                name: "(Info",
                newName: "Info");

            migrationBuilder.RenameIndex(
                name: "IX_(Info_ProfileId",
                table: "Info",
                newName: "IX_Info_ProfileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Info",
                table: "Info",
                column: "InfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Info_Profile_ProfileId",
                table: "Info",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Info_Profile_ProfileId",
                table: "Info");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Info",
                table: "Info");

            migrationBuilder.RenameTable(
                name: "Info",
                newName: "(Info");

            migrationBuilder.RenameIndex(
                name: "IX_Info_ProfileId",
                table: "(Info",
                newName: "IX_(Info_ProfileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_(Info",
                table: "(Info",
                column: "InfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_(Info_Profile_ProfileId",
                table: "(Info",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
