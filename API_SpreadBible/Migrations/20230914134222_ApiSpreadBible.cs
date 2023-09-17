using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_SpreadBible.Migrations
{
    /// <inheritdoc />
    public partial class ApiSpreadBible : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Churches",
                columns: table => new
                {
                    ChurchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChurchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChurchAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChurchCEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChurchUF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChurchTel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Churches", x => x.ChurchId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavChurch = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Churches");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
