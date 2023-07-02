using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Persistence.Migrations
{
    public partial class InitCreate9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_AspNetUsers_OwnerId",
                table: "Blogs");

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

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Blogs",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_AspNetUsers_OwnerId",
                table: "Blogs",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_AspNetUsers_OwnerId",
                table: "Blogs");

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

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Blogs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_AspNetUsers_OwnerId",
                table: "Blogs",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
