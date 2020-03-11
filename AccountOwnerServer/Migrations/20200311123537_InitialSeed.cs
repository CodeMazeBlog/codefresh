using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountOwnerServer.Migrations
{
    public partial class InitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "owner",
                columns: table => new
                {
                    OwnerId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_owner", x => x.OwnerId);
                });

            migrationBuilder.CreateTable(
                name: "account",
                columns: table => new
                {
                    AccountId = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    AccountType = table.Column<string>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_account_owner_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "owner",
                        principalColumn: "OwnerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[] { new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906"), "61 Wellfield Road", new DateTime(1980, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Keen" });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[] { new Guid("261e1685-cf26-494c-b17c-3546e65f5620"), "27 Colored Row", new DateTime(1974, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna Bosh" });

            migrationBuilder.InsertData(
                table: "account",
                columns: new[] { "AccountId", "AccountType", "DateCreated", "OwnerId" },
                values: new object[] { new Guid("03e91478-5608-4132-a753-d494dafce00b"), "Domestic", new DateTime(2003, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906") });

            migrationBuilder.InsertData(
                table: "account",
                columns: new[] { "AccountId", "AccountType", "DateCreated", "OwnerId" },
                values: new object[] { new Guid("356a5a9b-64bf-4de0-bc84-5395a1fdc9c4"), "27 Colored Row", new DateTime(1974, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906") });

            migrationBuilder.CreateIndex(
                name: "IX_account_OwnerId",
                table: "account",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "account");

            migrationBuilder.DropTable(
                name: "owner");
        }
    }
}
