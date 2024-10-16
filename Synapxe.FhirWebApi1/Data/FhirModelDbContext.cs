// -------------------------------------------------------------------------------------------------
// Copyright (c) Integrated Health Information Systems Pte Ltd. All rights reserved.
// -------------------------------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Synapxe.FhirWebApi1.Data
{
    public class FhirModelDbContext : DbContext
    {
        public FhirModelDbContext(DbContextOptions<FhirModelDbContext> options)
            : base(options)
        {
        }

        public DbSet<AppointmentModel> Appointments => Set<AppointmentModel>();

        public DbSet<EducationModel> Education => Set<EducationModel>();

        public DbSet<InventoryModel> Inventory => Set<InventoryModel>();

        public DbSet<StudentModel> Student => Set<StudentModel>();

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<StudentModel>().HasKey(nameof(StudentModel.Id), nameof(StudentModel.VersionId));
        //}
    }
}
