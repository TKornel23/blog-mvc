using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Persistence.Migrations
{
    public partial class IniCreate12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "979bc9b9-2f2a-4002-b591-140055ad5adb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "e62f37e6-a8a3-4392-9c48-49641f57577c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "979bc9b9-2f2a-4002-b591-140055ad5adb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e62f37e6-a8a3-4392-9c48-49641f57577c");

            migrationBuilder.AddColumn<string>(
                name: "BlobUrl",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0069bf3a-4990-4143-8ed5-dcd96c38cc31", 0, "9f11da66-03de-4c87-a695-42ce3c3cdc65", null, null, "SiteUser", "tkornel23@gmail.com", true, "Toth", "Kornel", false, null, null, "TKORNEL23@GMAIL.COM", "AQAAAAEAACcQAAAAENPGhbk5eV2zTfD7nFgrFgyXwHt2miKxS+0f7R08y0zpQf1d5AbrTogougDU8zf26Q==", null, false, "9de3a6f0-bc9f-4466-9edd-7da822b15cf7", false, "tkornel23@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f7d5acd0-bd77-4ad4-b59a-2f369f669329", 0, "11f315b6-c2c6-41c9-acba-f5cb110eab80", null, null, "SiteUser", "ttoraxon@gmail.com", true, "Toth", "Kornel", false, null, null, "TTORAXON@GMAIL.COM", "AQAAAAEAACcQAAAAEOi13ztcbLc9YmAJRmA74NbkPKbu05zsv1CPq/WSPVbQ21mMMMQxIat/8BzJof+cKg==", null, false, "101ba5bd-876f-4234-9114-6efe0c55085a", false, "ttoraxon@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "0069bf3a-4990-4143-8ed5-dcd96c38cc31" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "f7d5acd0-bd77-4ad4-b59a-2f369f669329" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "0069bf3a-4990-4143-8ed5-dcd96c38cc31" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "f7d5acd0-bd77-4ad4-b59a-2f369f669329" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0069bf3a-4990-4143-8ed5-dcd96c38cc31");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7d5acd0-bd77-4ad4-b59a-2f369f669329");

            migrationBuilder.DropColumn(
                name: "BlobUrl",
                table: "Blogs");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "979bc9b9-2f2a-4002-b591-140055ad5adb", 0, "ec6611fc-e6bd-476b-816d-3da01bdbdf1c", null, null, "SiteUser", "tkornel23@gmail.com", true, "Toth", "Kornel", false, null, null, "TKORNEL23@GMAIL.COM", "AQAAAAEAACcQAAAAELtPx905zf/4qvL5BW48uIfWRKj/rynrKgpxpNnuoUx1KSX+idki+mIDQ6axg12pfg==", null, false, "82b65221-672e-4848-8e0f-b6d3b4efbe20", false, "tkornel23@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e62f37e6-a8a3-4392-9c48-49641f57577c", 0, "d3135f8b-384e-4d69-bf7c-0301b88e3670", null, null, "SiteUser", "ttoraxon@gmail.com", true, "Toth", "Kornel", false, null, null, "TTORAXON@GMAIL.COM", "AQAAAAEAACcQAAAAECZkQaAFuGEhHuaEABMO8MHKk2ycLRb0Ql7vQFJattkBf+LbsxeGzp9n6vz6Vlgv1Q==", null, false, "4ff7e926-e240-42de-8314-d24226c84410", false, "ttoraxon@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "979bc9b9-2f2a-4002-b591-140055ad5adb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "e62f37e6-a8a3-4392-9c48-49641f57577c" });
        }
    }
}
