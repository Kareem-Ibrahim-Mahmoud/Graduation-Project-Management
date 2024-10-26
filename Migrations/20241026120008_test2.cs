using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Your_Graduation.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idhead",
                table: "groups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_groups_idhead",
                table: "groups",
                column: "idhead");

            migrationBuilder.AddForeignKey(
                name: "FK_groups_Students_idhead",
                table: "groups",
                column: "idhead",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_groups_Students_idhead",
                table: "groups");

            migrationBuilder.DropIndex(
                name: "IX_groups_idhead",
                table: "groups");

            migrationBuilder.DropColumn(
                name: "idhead",
                table: "groups");
        }
    }
}
