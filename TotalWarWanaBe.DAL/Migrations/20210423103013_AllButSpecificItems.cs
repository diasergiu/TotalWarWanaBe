using Microsoft.EntityFrameworkCore.Migrations;

namespace TotalWarWanaBe.DAL.Migrations
{
    public partial class AllButSpecificItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bardings",
                columns: table => new
                {
                    IdBarding = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArmorValue = table.Column<int>(type: "int", nullable: false),
                    BardingName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bardings", x => x.IdBarding);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    IdItem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaminaCost = table.Column<int>(type: "int", nullable: false),
                    SpeedCost = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.IdItem);
                });

            migrationBuilder.CreateTable(
                name: "SoldierModels",
                columns: table => new
                {
                    IdSoldier = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttackSkilll = table.Column<int>(type: "int", nullable: false),
                    DefenceSkill = table.Column<int>(type: "int", nullable: false),
                    Stamina = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    Acuracy = table.Column<int>(type: "int", nullable: false),
                    SoldierName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoldierModels", x => x.IdSoldier);
                });

            migrationBuilder.CreateTable(
                name: "Traits",
                columns: table => new
                {
                    IdTrait = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TraitDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TraitName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traits", x => x.IdTrait);
                });

            migrationBuilder.CreateTable(
                name: "Horses",
                columns: table => new
                {
                    IdHorse = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttackModifier = table.Column<int>(type: "int", nullable: false),
                    BreedName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DefenceModifiered = table.Column<int>(type: "int", nullable: false),
                    HorseStamina = table.Column<int>(type: "int", nullable: false),
                    HorseStrength = table.Column<int>(type: "int", nullable: false),
                    BardingIdBarding = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horses", x => x.IdHorse);
                    table.ForeignKey(
                        name: "FK_Horses_Bardings_BardingIdBarding",
                        column: x => x.BardingIdBarding,
                        principalTable: "Bardings",
                        principalColumn: "IdBarding",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SoldierFormations",
                columns: table => new
                {
                    IdFormation = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberSoldiers = table.Column<int>(type: "int", nullable: false),
                    StartingFormationValue = table.Column<int>(type: "int", nullable: false),
                    FormationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SoldierModelIdSoldier = table.Column<int>(type: "int", nullable: true),
                    HorseIdHorse = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoldierFormations", x => x.IdFormation);
                    table.ForeignKey(
                        name: "FK_SoldierFormations_Horses_HorseIdHorse",
                        column: x => x.HorseIdHorse,
                        principalTable: "Horses",
                        principalColumn: "IdHorse",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SoldierFormations_SoldierModels_SoldierModelIdSoldier",
                        column: x => x.SoldierModelIdSoldier,
                        principalTable: "SoldierModels",
                        principalColumn: "IdSoldier",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FactionSoldierFormation",
                columns: table => new
                {
                    FactionsIdFaction = table.Column<int>(type: "int", nullable: false),
                    SoldierFormationsIdFormation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactionSoldierFormation", x => new { x.FactionsIdFaction, x.SoldierFormationsIdFormation });
                    table.ForeignKey(
                        name: "FK_FactionSoldierFormation_Factions_FactionsIdFaction",
                        column: x => x.FactionsIdFaction,
                        principalTable: "Factions",
                        principalColumn: "IdFaction",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FactionSoldierFormation_SoldierFormations_SoldierFormationsIdFormation",
                        column: x => x.SoldierFormationsIdFormation,
                        principalTable: "SoldierFormations",
                        principalColumn: "IdFormation",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemSoldierFormation",
                columns: table => new
                {
                    ItemsIdItem = table.Column<int>(type: "int", nullable: false),
                    SoldierFormationsIdFormation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSoldierFormation", x => new { x.ItemsIdItem, x.SoldierFormationsIdFormation });
                    table.ForeignKey(
                        name: "FK_ItemSoldierFormation_Items_ItemsIdItem",
                        column: x => x.ItemsIdItem,
                        principalTable: "Items",
                        principalColumn: "IdItem",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemSoldierFormation_SoldierFormations_SoldierFormationsIdFormation",
                        column: x => x.SoldierFormationsIdFormation,
                        principalTable: "SoldierFormations",
                        principalColumn: "IdFormation",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SoldierFormationTrait",
                columns: table => new
                {
                    SoldierFormationIdFormation = table.Column<int>(type: "int", nullable: false),
                    TraitsIdTrait = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoldierFormationTrait", x => new { x.SoldierFormationIdFormation, x.TraitsIdTrait });
                    table.ForeignKey(
                        name: "FK_SoldierFormationTrait_SoldierFormations_SoldierFormationIdFormation",
                        column: x => x.SoldierFormationIdFormation,
                        principalTable: "SoldierFormations",
                        principalColumn: "IdFormation",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SoldierFormationTrait_Traits_TraitsIdTrait",
                        column: x => x.TraitsIdTrait,
                        principalTable: "Traits",
                        principalColumn: "IdTrait",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FactionSoldierFormation_SoldierFormationsIdFormation",
                table: "FactionSoldierFormation",
                column: "SoldierFormationsIdFormation");

            migrationBuilder.CreateIndex(
                name: "IX_Horses_BardingIdBarding",
                table: "Horses",
                column: "BardingIdBarding");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSoldierFormation_SoldierFormationsIdFormation",
                table: "ItemSoldierFormation",
                column: "SoldierFormationsIdFormation");

            migrationBuilder.CreateIndex(
                name: "IX_SoldierFormations_HorseIdHorse",
                table: "SoldierFormations",
                column: "HorseIdHorse");

            migrationBuilder.CreateIndex(
                name: "IX_SoldierFormations_SoldierModelIdSoldier",
                table: "SoldierFormations",
                column: "SoldierModelIdSoldier");

            migrationBuilder.CreateIndex(
                name: "IX_SoldierFormationTrait_TraitsIdTrait",
                table: "SoldierFormationTrait",
                column: "TraitsIdTrait");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FactionSoldierFormation");

            migrationBuilder.DropTable(
                name: "ItemSoldierFormation");

            migrationBuilder.DropTable(
                name: "SoldierFormationTrait");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "SoldierFormations");

            migrationBuilder.DropTable(
                name: "Traits");

            migrationBuilder.DropTable(
                name: "Horses");

            migrationBuilder.DropTable(
                name: "SoldierModels");

            migrationBuilder.DropTable(
                name: "Bardings");
        }
    }
}
