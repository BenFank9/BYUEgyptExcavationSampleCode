﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable


//this is the ContextDb for the Burials database, and allows us to display the information.
namespace BYUEgyptExcavation.Models
{
    public partial class BYUEgyptExcavationsFagelGamousContext : DbContext
    {
        public BYUEgyptExcavationsFagelGamousContext()
        {
        }

        public BYUEgyptExcavationsFagelGamousContext(DbContextOptions<BYUEgyptExcavationsFagelGamousContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Burial> Burial { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=byuegyptexcavations.cojcf6npt8v9.us-west-1.rds.amazonaws.com;Initial Catalog=BYU Egypt Excavations Fag el-Gamous;User ID=admin;Password=Admin321!;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Burial>(entity =>
            {
                entity.HasKey(e => e.MummyId);

                entity.Property(e => e.MummyId).HasColumnName("MummyID");

                entity.Property(e => e.AgeMethod)
                    .HasColumnName("age_method")
                    .HasMaxLength(255);

                entity.Property(e => e.ArtifactFound).HasColumnName("artifact_found");

                entity.Property(e => e.ArtifactsTakenNotes)
                    .HasColumnName("artifacts_taken_notes")
                    .HasMaxLength(255);

                entity.Property(e => e.BasilarSuture)
                    .HasColumnName("basilar_suture")
                    .HasMaxLength(255);

                entity.Property(e => e.BasionBregmaHeight).HasColumnName("basion_bregma_height");

                entity.Property(e => e.BasionNasion).HasColumnName("basion_nasion");

                entity.Property(e => e.BasionProsthionLength).HasColumnName("basion_prosthion_length");

                entity.Property(e => e.BizygomaticDiameter).HasColumnName("bizygomatic_diameter");

                entity.Property(e => e.BoneTaken).HasColumnName("bone_taken");

                entity.Property(e => e.BurialDepth).HasColumnName("burial_depth");

                entity.Property(e => e.BurialId)
                    .IsRequired()
                    .HasColumnName("BurialID")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialLocationEw)
                    .IsRequired()
                    .HasColumnName("burial_location_EW")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialLocationNs)
                    .IsRequired()
                    .HasColumnName("burial_location_NS")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialNumber).HasColumnName("burial_number");

                entity.Property(e => e.BurialSituationNotes).HasColumnName("burial_situation_notes");

                entity.Property(e => e.BurialSubplot)
                    .IsRequired()
                    .HasColumnName("burial_subplot")
                    .HasMaxLength(255);

                entity.Property(e => e.CranialSuture)
                    .HasColumnName("cranial_suture")
                    .HasMaxLength(255);

                entity.Property(e => e.DayFound)
                    .IsRequired()
                    .HasColumnName("day_found")
                    .HasMaxLength(255);

                entity.Property(e => e.DorsalPitting).HasColumnName("dorsal_pitting");

                entity.Property(e => e.EastToFeet).HasColumnName("east_to_feet");

                entity.Property(e => e.EastToHead).HasColumnName("east_to_head");

                entity.Property(e => e.EpiphysealUnion)
                    .HasColumnName("epiphyseal_union")
                    .HasMaxLength(255);

                entity.Property(e => e.EstimateAge).HasColumnName("estimate_age");

                entity.Property(e => e.EstimateLivingStature).HasColumnName("estimate_living_stature");

                entity.Property(e => e.FemurHead).HasColumnName("femur_head");

                entity.Property(e => e.FemurLength).HasColumnName("femur_length");

                entity.Property(e => e.ForemanMagnum).HasColumnName("foreman_magnum");

                entity.Property(e => e.GeFunctionTotal).HasColumnName("GE_function_total");

                entity.Property(e => e.GenderBodyCol)
                    .HasColumnName("gender_body_col")
                    .HasMaxLength(255);

                entity.Property(e => e.GenderGe)
                    .HasColumnName("gender_GE")
                    .HasMaxLength(255);

                entity.Property(e => e.GenderMethod)
                    .HasColumnName("gender_method")
                    .HasMaxLength(255);

                entity.Property(e => e.Gonian).HasColumnName("gonian");

                entity.Property(e => e.HairColor)
                    .HasColumnName("hair_color")
                    .HasMaxLength(255);

                entity.Property(e => e.HairTaken).HasColumnName("hair_taken");

                entity.Property(e => e.HeadDirection)
                    .IsRequired()
                    .HasColumnName("head_direction")
                    .HasMaxLength(255);

                entity.Property(e => e.HighPairEw).HasColumnName("high_pair_EW");

                entity.Property(e => e.HighPairNs).HasColumnName("high_pair_NS");

                entity.Property(e => e.HumerusHead).HasColumnName("humerus_head");

                entity.Property(e => e.HumerusLength).HasColumnName("humerus_length");

                entity.Property(e => e.InterorbitalBreadth).HasColumnName("interorbital_breadth");

                entity.Property(e => e.LengthOfRemains).HasColumnName("length_of_remains");

                entity.Property(e => e.LowPairEw).HasColumnName("low_pair_EW");

                entity.Property(e => e.LowPairNs).HasColumnName("low_pair_NS");

                entity.Property(e => e.MaximumCranialBreadth).HasColumnName("maximum_cranial_breadth");

                entity.Property(e => e.MaximumCranialLength).HasColumnName("maximum_cranial_length");

                entity.Property(e => e.MaximumNasalBreadth).HasColumnName("maximum_nasal_breadth");

                entity.Property(e => e.MedialIpRamus).HasColumnName("medial_IP_ramus");

                entity.Property(e => e.MonthFound)
                    .IsRequired()
                    .HasColumnName("month_found")
                    .HasMaxLength(255);

                entity.Property(e => e.NasionProsthion).HasColumnName("nasion_prosthion");

                entity.Property(e => e.NuchalCrest).HasColumnName("nuchal_crest");

                entity.Property(e => e.OrbitEdge).HasColumnName("orbit_edge");

                entity.Property(e => e.Osteophytosis)
                    .HasColumnName("osteophytosis")
                    .HasMaxLength(255);

                entity.Property(e => e.ParietalBossing).HasColumnName("parietal_bossing");

                entity.Property(e => e.PathologyAnomalies)
                    .HasColumnName("pathology_anomalies")
                    .HasMaxLength(255);

                entity.Property(e => e.PreaurSulcus).HasColumnName("preaur_sulcus");

                entity.Property(e => e.PreservationIndex)
                    .IsRequired()
                    .HasColumnName("preservation_index")
                    .HasMaxLength(255);

                entity.Property(e => e.PubicBone).HasColumnName("pubic_bone");

                entity.Property(e => e.PubicSymphysis)
                    .HasColumnName("pubic_symphysis")
                    .HasMaxLength(255);

                entity.Property(e => e.Robust).HasColumnName("robust");

                entity.Property(e => e.SampleNumber).HasColumnName("sample_number");

                entity.Property(e => e.SampleTakenNotes)
                    .HasColumnName("sample_taken_notes")
                    .HasMaxLength(255);

                entity.Property(e => e.SciaticNotch).HasColumnName("sciatic_notch");

                entity.Property(e => e.SoftTissueTaken).HasColumnName("soft_tissue_taken");

                entity.Property(e => e.SouthToFeet).HasColumnName("south_to_feet");

                entity.Property(e => e.SouthToHead).HasColumnName("south_to_head");

                entity.Property(e => e.SubpubicAngle).HasColumnName("subpubic_angle");

                entity.Property(e => e.SupraorbitalRidges).HasColumnName("supraorbital_ridges");

                entity.Property(e => e.TextileTaken).HasColumnName("textile_taken");

                entity.Property(e => e.TibiaLength).HasColumnName("tibia_length");

                entity.Property(e => e.ToothAttrition)
                    .HasColumnName("tooth_attrition")
                    .HasMaxLength(255);

                entity.Property(e => e.ToothEruption)
                    .HasColumnName("tooth_eruption")
                    .HasMaxLength(255);

                entity.Property(e => e.ToothTaken).HasColumnName("tooth_taken");

                entity.Property(e => e.UserInitials)
                    .IsRequired()
                    .HasColumnName("user_initials")
                    .HasMaxLength(255);

                entity.Property(e => e.VentralArc).HasColumnName("ventral_arc");

                entity.Property(e => e.Wrapped).HasColumnName("wrapped");

                entity.Property(e => e.YearFound)
                    .IsRequired()
                    .HasColumnName("year_found")
                    .HasMaxLength(255);

                entity.Property(e => e.ZygomaticCrest).HasColumnName("zygomatic_crest");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
