using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Persistence.Migrations
{
    public partial class InitCreate10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "34dd996b-d16b-41ab-82b9-77c24772efae" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "60cedba5-889c-4674-ba61-5fe2cc76c661" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34dd996b-d16b-41ab-82b9-77c24772efae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60cedba5-889c-4674-ba61-5fe2cc76c661");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "34dd996b-d16b-41ab-82b9-77c24772efae", 0, "f806c486-8039-4305-9eb3-099aad509a7e", null, null, "SiteUser", "tkornel23@gmail.com", true, "Toth", "Kornel", false, null, null, "TKORNEL23@GMAIL.COM", "AQAAAAEAACcQAAAAEKBQPo8vBUK3BhaQbbn1hjSqVCj/EQr2RFrGMoovUtmgTxvbioZ/icZ/r4oIaBsabA==", null, false, "b85ac158-4cd3-444c-8801-6b97b539a8db", false, "tkornel23@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "60cedba5-889c-4674-ba61-5fe2cc76c661", 0, "0ebf325d-9f2f-4681-a52d-9446c34db971", null, null, "SiteUser", "ttoraxon@gmail.com", true, "Toth", "Kornel", false, null, null, "TTORAXON@GMAIL.COM", "AQAAAAEAACcQAAAAEE5I+pQUlVtoZT3AvRNmRUXlNl/xzlcY84LVSzkRYuHqlGnGEoSBLRYGpUFQBHdUUA==", null, false, "6af79412-1203-47a0-8de7-54ba2568bcd9", false, "ttoraxon@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "34dd996b-d16b-41ab-82b9-77c24772efae" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "60cedba5-889c-4674-ba61-5fe2cc76c661" });
        }
    }
}
