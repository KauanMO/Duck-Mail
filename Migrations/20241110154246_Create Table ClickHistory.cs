using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Duck_Mail.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableClickHistory : Migration
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
                    CampaignEmailTemplateId = table.Column<int>(type: "int", nullable: false),
                    RecipientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClickHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClickHistories_CampaignEmailTemplates_CampaignEmailTemplateId",
                        column: x => x.CampaignEmailTemplateId,
                        principalTable: "CampaignEmailTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClickHistories_Recipients_RecipientId",
                        column: x => x.RecipientId,
                        principalTable: "Recipients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClickHistories_CampaignEmailTemplateId",
                table: "ClickHistories",
                column: "CampaignEmailTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_ClickHistories_RecipientId",
                table: "ClickHistories",
                column: "RecipientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClickHistories");
        }
    }
}
