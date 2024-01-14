﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infinite_dungeon.Data.Migrations
{
    /// <inheritdoc />
    public partial class hotfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Character_AspNetUsers_UserId",
                table: "Character");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Character",
                newName: "UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_Character_UserId",
                table: "Character",
                newName: "IX_Character_UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Character_AspNetUsers_UserId1",
                table: "Character",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Character_AspNetUsers_UserId1",
                table: "Character");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "Character",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Character_UserId1",
                table: "Character",
                newName: "IX_Character_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Character_AspNetUsers_UserId",
                table: "Character",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
