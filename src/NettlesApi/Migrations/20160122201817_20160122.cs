using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace NettlesApi.Migrations
{
    public partial class _20160122 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Url", table: "Show");
            migrationBuilder.DropColumn(name: "Url", table: "Caller");
            migrationBuilder.AddColumn<string>(
                name: "ShowUrl",
                table: "Show",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "CallerUrl",
                table: "Caller",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "ShowUrl", table: "Show");
            migrationBuilder.DropColumn(name: "CallerUrl", table: "Caller");
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Show",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Caller",
                nullable: true);
        }
    }
}
