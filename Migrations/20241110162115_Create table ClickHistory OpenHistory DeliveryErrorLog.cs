using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Duck_Mail.Migrations
{
    /// <inheritdoc />
    public partial class CreatetableClickHistoryOpenHistoryDeliveryErrorLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClickHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrowserType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeviceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClickCount = table.Column<int>(type: "int", nullable: false),
                    FirstOpenedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastOpenedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecipientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClickHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClickHistories_Recipients_RecipientId",
                        column: x => x.RecipientId,
                        principalTable: "Recipients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryErrorLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecipientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryErrorLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryErrorLogs_Recipients_RecipientId",
                        column: x => x.RecipientId,
                        principalTable: "Recipients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OpenHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OpenedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecipientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpenHistories_Recipients_RecipientId",
                        column: x => x.RecipientId,
                        principalTable: "Recipients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClickHistories_RecipientId",
                table: "ClickHistories",
                column: "RecipientId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryErrorLogs_RecipientId",
                table: "DeliveryErrorLogs",
                column: "RecipientId");

            migrationBuilder.CreateIndex(
                name: "IX_OpenHistories_RecipientId",
                table: "OpenHistories",
                column: "RecipientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClickHistories");

            migrationBuilder.DropTable(
                name: "DeliveryErrorLogs");

            migrationBuilder.DropTable(
                name: "OpenHistories");
        }
    }
}
