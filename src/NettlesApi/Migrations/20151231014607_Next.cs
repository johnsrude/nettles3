using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace NettlesApi.Migrations
{
    public partial class Next : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "VenueId",
                table: "Show",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "VenueId",
                table: "Show",
                nullable: false);
        }
    }
}
