using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace NettlesApi.Migrations
{
    public partial class _20160107b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Venue",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Venue",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Venue",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Venue",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Venue",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Venue",
                nullable: true);
        }
    }
}
