﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Persistence.Migrations
{
    public partial class InitCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Likes",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Likes",
                table: "Blogs");
        }
    }
}