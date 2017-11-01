using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EFCore2Demo.Migrations
{
    public partial class ownedentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SecretIdentity_First",
                table: "Samurais",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecretIdentity_Last",
                table: "Samurais",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SecretIdentity_First",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "SecretIdentity_Last",
                table: "Samurais");
        }
    }
}
