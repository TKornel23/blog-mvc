using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Persistence.Migrations
{
    public partial class InitCreate8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13fbbf8b-4aa4-4bd4-8fab-1ab24edcd62b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b82ab52-2048-4adb-86b6-b8b495ec2394");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b5b2c708-e3a9-45cd-b311-f5ba357f6ffa", 0, "14722dac-2001-4780-a9dd-1c5e23902391", null, null, "SiteUser", "tkornel23@gmail.com", true, "Toth", "Kornel", false, null, null, "TKORNEL23@GMAIL.COM", "AQAAAAEAACcQAAAAEFK6gaiX3FGidBBCU05FkAEks/uH+li1+UxDhuCFk1ucKoIeynnBEHf9htjkeVKPDg==", null, false, "f70b0349-d9f8-4590-96e6-e2c397bcd8f4", false, "tkornel23@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ef4b23a2-1647-49ec-8375-cd174cef0d4a", 0, "69297364-af82-4545-9304-0faa79da2b3d", null, null, "SiteUser", "ttoraxon@gmail.com", true, "Toth", "Kornel", false, null, null, "TTORAXON@GMAIL.COM", "AQAAAAEAACcQAAAAEOLV5VCckJJ669wP4uwTSFwqExVDh14BezxOm2LO69Aa2+CrK4n/cz9UjN5uT+8IaQ==", null, false, "d12fae50-e5a1-4b6d-85b5-a9a9d0af04c0", false, "ttoraxon@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "b5b2c708-e3a9-45cd-b311-f5ba357f6ffa" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "ef4b23a2-1647-49ec-8375-cd174cef0d4a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "b5b2c708-e3a9-45cd-b311-f5ba357f6ffa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "ef4b23a2-1647-49ec-8375-cd174cef0d4a" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5b2c708-e3a9-45cd-b311-f5ba357f6ffa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef4b23a2-1647-49ec-8375-cd174cef0d4a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "13fbbf8b-4aa4-4bd4-8fab-1ab24edcd62b", 0, "f82626e2-9ea5-40eb-b8a4-d8bcfa687da5", null, null, "SiteUser", "tkornel23@gmail.com", true, "Toth", "Kornel", false, null, null, "TKORNEL23@GMAIL.COM", "AQAAAAEAACcQAAAAENQT8NFZXqqR7TrspxjfNBz6kjqZzG2E5ujgWcl3Poz4TYQTr1SGrnNeKVfuHMpq4g==", null, false, "9d2b8d03-8719-45cb-ad84-cc2b61be2abe", false, "tkornel23@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4b82ab52-2048-4adb-86b6-b8b495ec2394", 0, "216ef246-b080-4afb-9d29-b3fec417cb98", null, null, "SiteUser", "ttoraxon@gmail.com", true, "Toth", "Kornel", false, null, null, "TTORAXON@GMAIL.COM", "AQAAAAEAACcQAAAAELlCnN4ZHPnQORagUwX5uvqKUUZXusYSuqEbYDnPIt7bp/r8VXPlMbTs/w7GIO7aow==", null, false, "61dc3bbe-3406-45a4-b0c5-075b09debaa7", false, "ttoraxon@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "13fbbf8b-4aa4-4bd4-8fab-1ab24edcd62b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "4b82ab52-2048-4adb-86b6-b8b495ec2394" });
        }
    }
}
