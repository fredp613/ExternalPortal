﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InternalPortal.Models.Portal;
using InternalPortal.Models.Portal.Program;
using InternalPortal.Models;

namespace InternalPortal.Models
{
    public class PortalContext : DbContext
    {
        public PortalContext (DbContextOptions<PortalContext> options)
            : base(options)
        {
        }

        public PortalContext()
        {
        }

        public DbSet<InternalPortal.Models.Project> Project { get; set; }
        public DbSet<InternalPortal.Models.User> User { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(p => p.CreatedBy)
                .WithMany()
                .HasForeignKey(b => b.CreatedByUserId);
            modelBuilder.Entity<User>()
                .HasOne(p => p.UpdatedBy)
                .WithMany()
                .HasForeignKey(b => b.UpdatedByUserId);

            modelBuilder.Entity<InternalUser>()
               .HasOne(p => p.CreatedBy)
               .WithMany()
               .HasForeignKey(b => b.CreatedByInternalUserId);
            modelBuilder.Entity<InternalUser>()
                .HasOne(p => p.UpdatedBy)
                .WithMany()
                .HasForeignKey(b => b.UpdatedByInternalUserId);

            
        }

  

        public DbSet<InternalPortal.Models.Portal.FundingOpportunity> FundingOpportunity { get; set; }

        public DbSet<InternalPortal.Models.Portal.Program.EligibilityCriteria> EligibilityCriteria { get; set; }

        public DbSet<InternalPortal.Models.Portal.Program.FundingOpportunityEligibilityCriteria> FundingOpportunityEligibilityCriteria { get; set; }

        public DbSet<InternalPortal.Models.Portal.Program.FundingOpportunityExpectedResult> FundingOpportunityExpectedResult { get; set; }

        public DbSet<InternalPortal.Models.Portal.Program.FundingOpportunityObjective> FundingOpportunityObjective { get; set; }

        public DbSet<InternalPortal.Models.Portal.Program.EligibleClientType> EligibleClientType { get; set; }

        public DbSet<InternalPortal.Models.Account> Account { get; set; }

        public DbSet<InternalPortal.Models.Contact> Contact { get; set; }

        public DbSet<InternalPortal.Models.Portal.Program.ExpectedResult> ExpectedResult { get; set; }

        public DbSet<InternalPortal.Models.Portal.Program.Objective> Objective { get; set; }

        public DbSet<InternalPortal.Models.Portal.Program.CostCategory> CostCategory { get; set; }
        public DbSet<InternalPortal.Models.Portal.Program.EligibleCostCategory> EligibleCostCategory { get; set; }
        public DbSet<InternalPortal.Models.InternalUser> InternalUser { get; set; }
    }
}
