﻿using HospitalSystem.Infrastructure.Configurations;

namespace HospitalSystem.Infrastructure.Data
{
    public class ApplicationDbContext:IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Patient> Patients { set;get; }
        public DbSet<Appointment> Appointments { set;get; }
        public DbSet<Doctor> Doctors { set;get; }
        public DbSet<MedicalRecord> MedicalRecords { set;get; }
        public DbSet<Nurse> Nurses { set;get; }
        public DbSet<ApplicationUser> ApplicationUsers { set;get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AppointmentConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorConfiguration());
            modelBuilder.ApplyConfiguration(new MedicalRecordConfiguration());
            modelBuilder.ApplyConfiguration(new NurseConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
        }
    }
}
