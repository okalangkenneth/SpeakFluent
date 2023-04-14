using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeakFluent.Data.Migrations
{
    public partial class SubscriptionPlans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubscriptionPlanId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SubscriptionPlan",
                columns: table => new
                {
                    SubscriptionPlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionPlan", x => x.SubscriptionPlanId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SubscriptionPlanId",
                table: "AspNetUsers",
                column: "SubscriptionPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SubscriptionPlan_SubscriptionPlanId",
                table: "AspNetUsers",
                column: "SubscriptionPlanId",
                principalTable: "SubscriptionPlan",
                principalColumn: "SubscriptionPlanId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_SubscriptionPlan_SubscriptionPlanId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SubscriptionPlan");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SubscriptionPlanId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SubscriptionPlanId",
                table: "AspNetUsers");
        }
    }
}
