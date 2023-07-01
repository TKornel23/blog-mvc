using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Persistence.Migrations
{
    public partial class InitCreate7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "User", "USER" },
                    { "2", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "13fbbf8b-4aa4-4bd4-8fab-1ab24edcd62b", 0, "f82626e2-9ea5-40eb-b8a4-d8bcfa687da5", null, null, "SiteUser", "tkornel23@gmail.com", true, "Toth", "Kornel", false, null, null, "TKORNEL23@GMAIL.COM", "AQAAAAEAACcQAAAAENQT8NFZXqqR7TrspxjfNBz6kjqZzG2E5ujgWcl3Poz4TYQTr1SGrnNeKVfuHMpq4g==", null, false, "9d2b8d03-8719-45cb-ad84-cc2b61be2abe", false, "tkornel23@gmail.com" },
                    { "4b82ab52-2048-4adb-86b6-b8b495ec2394", 0, "216ef246-b080-4afb-9d29-b3fec417cb98", null, null, "SiteUser", "ttoraxon@gmail.com", true, "Toth", "Kornel", false, null, null, "TTORAXON@GMAIL.COM", "AQAAAAEAACcQAAAAELlCnN4ZHPnQORagUwX5uvqKUUZXusYSuqEbYDnPIt7bp/r8VXPlMbTs/w7GIO7aow==", null, false, "61dc3bbe-3406-45a4-b0c5-075b09debaa7", false, "ttoraxon@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "13fbbf8b-4aa4-4bd4-8fab-1ab24edcd62b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "4b82ab52-2048-4adb-86b6-b8b495ec2394" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "13fbbf8b-4aa4-4bd4-8fab-1ab24edcd62b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "4b82ab52-2048-4adb-86b6-b8b495ec2394" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13fbbf8b-4aa4-4bd4-8fab-1ab24edcd62b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b82ab52-2048-4adb-86b6-b8b495ec2394");
        }
    }
}
