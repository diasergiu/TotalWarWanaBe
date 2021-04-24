using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using TotalWarWanaBe.Domain.Entityes;

namespace TotalWarWanaBe.DAL
{
    public class TotalWarWanaBeDbContext : DbContext
    {
        public TotalWarWanaBeDbContext(DbContextOptions<TotalWarWanaBeDbContext> options) : base(options)
        {
        }

        public DbSet<Barding> Bardings { get; set; }
        public DbSet<Faction> Factions { get; set; }
        public DbSet<Horse> Horses { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<SoldierFormation> SoldierFormations { get; set; }
        public DbSet<SoldierModel> SoldierModels{ get; set; }
        public DbSet<Trait> Traits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Barding>().HasKey(ba => ba.IdBarding);
            modelBuilder.Entity<Barding>().Property(ba => ba.ArmorValue);
            modelBuilder.Entity<Barding>().Property(ba => ba.BardingName).HasMaxLength(255);

            modelBuilder.Entity<Barding>().HasMany<Horse>(b => b.Horses)
                .WithOne(h => h.Barding); 

            modelBuilder.Entity<Faction>().HasKey(f => f.IdFaction);
            modelBuilder.Entity<Faction>().Property(f => f.FactionName).HasMaxLength(255);
            modelBuilder.Entity<Faction>().Property(f => f.FactionDescription).HasMaxLength(255);

            modelBuilder.Entity<Faction>().HasMany(f => f.SoldierFormations).
                WithMany(sf => sf.Factions);

            modelBuilder.Entity<Horse>().HasKey(h => h.IdHorse);
            modelBuilder.Entity<Horse>().Property(h => h.AttackModifier);
            modelBuilder.Entity<Horse>().Property(h => h.BreedName).HasMaxLength(255);
            modelBuilder.Entity<Horse>().Property(h => h.DefenceModifiered);
            modelBuilder.Entity<Horse>().Property(h => h.HorseStamina);
            modelBuilder.Entity<Horse>().Property(h => h.HorseStrength);

            modelBuilder.Entity<Horse>().HasMany<SoldierFormation>(h => h.SoldierFormations)
                .WithOne(sf => sf.Horse);
            modelBuilder.Entity<Horse>().HasOne<Barding>(h => h.Barding).WithMany(b => b.Horses);

            modelBuilder.Entity<Item>().HasKey(i => i.IdItem);
            modelBuilder.Entity<Item>().Property(i => i.StaminaCost);
            modelBuilder.Entity<Item>().Property(i => i.SpeedCost);
            modelBuilder.Entity<Item>().Property(i => i.ItemName).HasMaxLength(255);

            modelBuilder.Entity<Item>().HasMany<SoldierFormation>(i => i.SoldierFormations)
                .WithMany(sf => sf.Items);

            modelBuilder.Entity<SoldierFormation>().HasKey(sf => sf.IdFormation);
            modelBuilder.Entity<SoldierFormation>().Property(sf => sf.NumberSoldiers);
            modelBuilder.Entity<SoldierFormation>().Property(sf => sf.StartingFormationValue);
            modelBuilder.Entity<SoldierFormation>().Property(sf => sf.FormationName).HasMaxLength(255);

            modelBuilder.Entity<SoldierFormation>().HasOne(sf => sf.SoldierModel)
                .WithMany(sm => sm.SoldierFormations);
            modelBuilder.Entity<SoldierFormation>().HasMany<Trait>(sf => sf.Traits)
                .WithMany(t => t.SoldierFormation);

            modelBuilder.Entity<SoldierModel>().HasKey(sm => sm.IdSoldier);
            modelBuilder.Entity<SoldierModel>().Property(sm => sm.AttackSkilll);
            modelBuilder.Entity<SoldierModel>().Property(sm => sm.DefenceSkill);
            modelBuilder.Entity<SoldierModel>().Property(sm => sm.Stamina);
            modelBuilder.Entity<SoldierModel>().Property(sm => sm.Speed);
            modelBuilder.Entity<SoldierModel>().Property(sm => sm.Acuracy);
            modelBuilder.Entity<SoldierModel>().Property(sm => sm.SoldierName).HasMaxLength(255);

            modelBuilder.Entity<Trait>().HasKey(t => t.IdTrait);
            modelBuilder.Entity<Trait>().Property(t => t.TraitDescription).HasMaxLength(255);
            modelBuilder.Entity<Trait>().Property(t => t.TraitName).HasMaxLength(255);
            


        }
    }
}
