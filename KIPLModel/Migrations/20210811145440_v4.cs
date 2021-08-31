using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KIPLModel.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kines_Cabinets_CabinetId",
                table: "Kines");

            migrationBuilder.AlterColumn<int>(
                name: "CabinetId",
                table: "Kines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "HeureOuverture",
                table: "Cabinets",
                type: "time",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "HeureFermeture",
                table: "Cabinets",
                type: "time",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AddForeignKey(
                name: "FK_Kines_Cabinets_CabinetId",
                table: "Kines",
                column: "CabinetId",
                principalTable: "Cabinets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kines_Cabinets_CabinetId",
                table: "Kines");

            migrationBuilder.AlterColumn<int>(
                name: "CabinetId",
                table: "Kines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "HeureOuverture",
                table: "Cabinets",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(TimeSpan),
                oldType: "time",
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "HeureFermeture",
                table: "Cabinets",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(TimeSpan),
                oldType: "time",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Kines_Cabinets_CabinetId",
                table: "Kines",
                column: "CabinetId",
                principalTable: "Cabinets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
