using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeakFluent.Data.Migrations
{
    public partial class SubscriptionPlansUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_SubscriptionPlan_SubscriptionPlanId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "SubscriptionPlanId",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SubscriptionPlan_SubscriptionPlanId",
                table: "AspNetUsers",
                column: "SubscriptionPlanId",
                principalTable: "SubscriptionPlan",
                principalColumn: "SubscriptionPlanId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_SubscriptionPlan_SubscriptionPlanId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "SubscriptionPlanId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SubscriptionPlan_SubscriptionPlanId",
                table: "AspNetUsers",
                column: "SubscriptionPlanId",
                principalTable: "SubscriptionPlan",
                principalColumn: "SubscriptionPlanId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
