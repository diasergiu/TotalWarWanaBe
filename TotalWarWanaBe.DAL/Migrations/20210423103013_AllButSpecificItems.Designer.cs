// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TotalWarWanaBe.DAL;

namespace TotalWarWanaBe.DAL.Migrations
{
    [DbContext(typeof(TotalWarWanaBeDbContext))]
    [Migration("20210423103013_AllButSpecificItems")]
    partial class AllButSpecificItems
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FactionSoldierFormation", b =>
                {
                    b.Property<int>("FactionsIdFaction")
                        .HasColumnType("int");

                    b.Property<int>("SoldierFormationsIdFormation")
                        .HasColumnType("int");

                    b.HasKey("FactionsIdFaction", "SoldierFormationsIdFormation");

                    b.HasIndex("SoldierFormationsIdFormation");

                    b.ToTable("FactionSoldierFormation");
                });

            modelBuilder.Entity("ItemSoldierFormation", b =>
                {
                    b.Property<int>("ItemsIdItem")
                        .HasColumnType("int");

                    b.Property<int>("SoldierFormationsIdFormation")
                        .HasColumnType("int");

                    b.HasKey("ItemsIdItem", "SoldierFormationsIdFormation");

                    b.HasIndex("SoldierFormationsIdFormation");

                    b.ToTable("ItemSoldierFormation");
                });

            modelBuilder.Entity("SoldierFormationTrait", b =>
                {
                    b.Property<int>("SoldierFormationIdFormation")
                        .HasColumnType("int");

                    b.Property<int>("TraitsIdTrait")
                        .HasColumnType("int");

                    b.HasKey("SoldierFormationIdFormation", "TraitsIdTrait");

                    b.HasIndex("TraitsIdTrait");

                    b.ToTable("SoldierFormationTrait");
                });

            modelBuilder.Entity("TotalWarWanaBe.Domain.Entityes.Barding", b =>
                {
                    b.Property<int>("IdBarding")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArmorValue")
                        .HasColumnType("int");

                    b.Property<string>("BardingName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("IdBarding");

                    b.ToTable("Bardings");
                });

            modelBuilder.Entity("TotalWarWanaBe.Domain.Entityes.Faction", b =>
                {
                    b.Property<int>("IdFaction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FactionDescription")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FactionName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("IdFaction");

                    b.ToTable("Factions");
                });

            modelBuilder.Entity("TotalWarWanaBe.Domain.Entityes.Horse", b =>
                {
                    b.Property<int>("IdHorse")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AttackModifier")
                        .HasColumnType("int");

                    b.Property<int?>("BardingIdBarding")
                        .HasColumnType("int");

                    b.Property<string>("BreedName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("DefenceModifiered")
                        .HasColumnType("int");

                    b.Property<int>("HorseStamina")
                        .HasColumnType("int");

                    b.Property<int>("HorseStrength")
                        .HasColumnType("int");

                    b.HasKey("IdHorse");

                    b.HasIndex("BardingIdBarding");

                    b.ToTable("Horses");
                });

            modelBuilder.Entity("TotalWarWanaBe.Domain.Entityes.Item", b =>
                {
                    b.Property<int>("IdItem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("SpeedCost")
                        .HasColumnType("int");

                    b.Property<int>("StaminaCost")
                        .HasColumnType("int");

                    b.HasKey("IdItem");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("TotalWarWanaBe.Domain.Entityes.SoldierFormation", b =>
                {
                    b.Property<int>("IdFormation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FormationName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("HorseIdHorse")
                        .HasColumnType("int");

                    b.Property<int>("NumberSoldiers")
                        .HasColumnType("int");

                    b.Property<int?>("SoldierModelIdSoldier")
                        .HasColumnType("int");

                    b.Property<int>("StartingFormationValue")
                        .HasColumnType("int");

                    b.HasKey("IdFormation");

                    b.HasIndex("HorseIdHorse");

                    b.HasIndex("SoldierModelIdSoldier");

                    b.ToTable("SoldierFormations");
                });

            modelBuilder.Entity("TotalWarWanaBe.Domain.Entityes.SoldierModel", b =>
                {
                    b.Property<int>("IdSoldier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Acuracy")
                        .HasColumnType("int");

                    b.Property<int>("AttackSkilll")
                        .HasColumnType("int");

                    b.Property<int>("DefenceSkill")
                        .HasColumnType("int");

                    b.Property<string>("SoldierName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<int>("Stamina")
                        .HasColumnType("int");

                    b.HasKey("IdSoldier");

                    b.ToTable("SoldierModels");
                });

            modelBuilder.Entity("TotalWarWanaBe.Domain.Entityes.Trait", b =>
                {
                    b.Property<int>("IdTrait")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TraitDescription")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("TraitName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("IdTrait");

                    b.ToTable("Traits");
                });

            modelBuilder.Entity("FactionSoldierFormation", b =>
                {
                    b.HasOne("TotalWarWanaBe.Domain.Entityes.Faction", null)
                        .WithMany()
                        .HasForeignKey("FactionsIdFaction")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TotalWarWanaBe.Domain.Entityes.SoldierFormation", null)
                        .WithMany()
                        .HasForeignKey("SoldierFormationsIdFormation")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ItemSoldierFormation", b =>
                {
                    b.HasOne("TotalWarWanaBe.Domain.Entityes.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsIdItem")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TotalWarWanaBe.Domain.Entityes.SoldierFormation", null)
                        .WithMany()
                        .HasForeignKey("SoldierFormationsIdFormation")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SoldierFormationTrait", b =>
                {
                    b.HasOne("TotalWarWanaBe.Domain.Entityes.SoldierFormation", null)
                        .WithMany()
                        .HasForeignKey("SoldierFormationIdFormation")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TotalWarWanaBe.Domain.Entityes.Trait", null)
                        .WithMany()
                        .HasForeignKey("TraitsIdTrait")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TotalWarWanaBe.Domain.Entityes.Horse", b =>
                {
                    b.HasOne("TotalWarWanaBe.Domain.Entityes.Barding", "Barding")
                        .WithMany("Horses")
                        .HasForeignKey("BardingIdBarding");

                    b.Navigation("Barding");
                });

            modelBuilder.Entity("TotalWarWanaBe.Domain.Entityes.SoldierFormation", b =>
                {
                    b.HasOne("TotalWarWanaBe.Domain.Entityes.Horse", "Horse")
                        .WithMany("SoldierFormations")
                        .HasForeignKey("HorseIdHorse");

                    b.HasOne("TotalWarWanaBe.Domain.Entityes.SoldierModel", "SoldierModel")
                        .WithMany("SoldierFormations")
                        .HasForeignKey("SoldierModelIdSoldier");

                    b.Navigation("Horse");

                    b.Navigation("SoldierModel");
                });

            modelBuilder.Entity("TotalWarWanaBe.Domain.Entityes.Barding", b =>
                {
                    b.Navigation("Horses");
                });

            modelBuilder.Entity("TotalWarWanaBe.Domain.Entityes.Horse", b =>
                {
                    b.Navigation("SoldierFormations");
                });

            modelBuilder.Entity("TotalWarWanaBe.Domain.Entityes.SoldierModel", b =>
                {
                    b.Navigation("SoldierFormations");
                });
#pragma warning restore 612, 618
        }
    }
}
