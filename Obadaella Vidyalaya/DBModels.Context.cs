//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Obadaella_Vidyalaya
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Obadaella_VidyalayaEntities : DbContext
    {
        public Obadaella_VidyalayaEntities()
            : base("name=Obadaella_VidyalayaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee_Tasks> Employee_Tasks { get; set; }
        public virtual DbSet<EmployeeSalaryDetail> EmployeeSalaryDetails { get; set; }
        public virtual DbSet<StudentPayment> StudentPayments { get; set; }
        public virtual DbSet<Users_Table> Users_Table { get; set; }
        public virtual DbSet<Employee_Register> Employee_Register { get; set; }
        public virtual DbSet<Employee_Attendance> Employee_Attendance { get; set; }
    }
}
