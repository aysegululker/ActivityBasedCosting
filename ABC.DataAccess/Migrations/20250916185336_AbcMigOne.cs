using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABC.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AbcMigOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CashCenterGroups",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CashCenterGroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashCenterGroups", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerCode = table.Column<short>(type: "smallint", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DistributionKeys",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DistributionKeyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistributionKeyRatio = table.Column<float>(type: "real", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionKeys", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KmTimes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KmTimeValue = table.Column<float>(type: "real", nullable: false),
                    InnerCityConsumption = table.Column<float>(type: "real", nullable: false),
                    OuterCityConsumption = table.Column<float>(type: "real", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KmTimes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ReflectionOfTheMainCosts",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReflectionOfTheMainCostRatio = table.Column<float>(type: "real", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReflectionOfTheMainCosts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ServiceClasses",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceClassName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceClasses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TheCostElementUsedTheEvaluations",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TheNameoftheCostElement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheCostElementUsedTheEvaluations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CashCenters",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CashCenterCode = table.Column<short>(type: "smallint", nullable: false),
                    CashCenterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CashCenterGroupID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashCenters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CashCenters_CashCenterGroups_CashCenterGroupID",
                        column: x => x.CashCenterGroupID,
                        principalTable: "CashCenterGroups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CostItems",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CostItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPCostClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CITCostClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KmMultiplierEffect = table.Column<bool>(type: "bit", nullable: false),
                    ByProduct = table.Column<bool>(type: "bit", nullable: false),
                    DistributionKeyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CostItems_DistributionKeys_DistributionKeyID",
                        column: x => x.DistributionKeyID,
                        principalTable: "DistributionKeys",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActivityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberofPersonnel = table.Column<short>(type: "smallint", nullable: false),
                    ActivityTime = table.Column<short>(type: "smallint", nullable: false),
                    TotalPersonnelTime = table.Column<short>(type: "smallint", nullable: false),
                    TotalVehicleTime = table.Column<short>(type: "smallint", nullable: false),
                    ServiceClassID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TheCostElementUsedTheEvaluationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Activities_ServiceClasses_ServiceClassID",
                        column: x => x.ServiceClassID,
                        principalTable: "ServiceClasses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Activities_TheCostElementUsedTheEvaluations_TheCostElementUsedTheEvaluationID",
                        column: x => x.TheCostElementUsedTheEvaluationID,
                        principalTable: "TheCostElementUsedTheEvaluations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KmValues",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InnerCityKm = table.Column<float>(type: "real", nullable: false),
                    OuterCityKm = table.Column<float>(type: "real", nullable: false),
                    CashCenterID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KmValues", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KmValues_CashCenters_CashCenterID",
                        column: x => x.CashCenterID,
                        principalTable: "CashCenters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BudgetValues",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BudgetPeriod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BudgetCost = table.Column<float>(type: "real", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CostItemID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CashCenterID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetValues", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BudgetValues_CashCenters_CashCenterID",
                        column: x => x.CashCenterID,
                        principalTable: "CashCenters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BudgetValues_CostItems_CostItemID",
                        column: x => x.CostItemID,
                        principalTable: "CostItems",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_ServiceClassID",
                table: "Activities",
                column: "ServiceClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_TheCostElementUsedTheEvaluationID",
                table: "Activities",
                column: "TheCostElementUsedTheEvaluationID");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetValues_CashCenterID",
                table: "BudgetValues",
                column: "CashCenterID");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetValues_CostItemID",
                table: "BudgetValues",
                column: "CostItemID");

            migrationBuilder.CreateIndex(
                name: "IX_CashCenters_CashCenterGroupID",
                table: "CashCenters",
                column: "CashCenterGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_CostItems_DistributionKeyID",
                table: "CostItems",
                column: "DistributionKeyID");

            migrationBuilder.CreateIndex(
                name: "IX_KmValues_CashCenterID",
                table: "KmValues",
                column: "CashCenterID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "BudgetValues");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "KmTimes");

            migrationBuilder.DropTable(
                name: "KmValues");

            migrationBuilder.DropTable(
                name: "ReflectionOfTheMainCosts");

            migrationBuilder.DropTable(
                name: "ServiceClasses");

            migrationBuilder.DropTable(
                name: "TheCostElementUsedTheEvaluations");

            migrationBuilder.DropTable(
                name: "CostItems");

            migrationBuilder.DropTable(
                name: "CashCenters");

            migrationBuilder.DropTable(
                name: "DistributionKeys");

            migrationBuilder.DropTable(
                name: "CashCenterGroups");
        }
    }
}
