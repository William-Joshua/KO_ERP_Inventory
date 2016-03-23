﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace KO_ERP_INVENTORY.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ErpInventoryEntities : DbContext
    {
        public ErpInventoryEntities()
            : base("name=ErpInventoryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<batchinformation> batchinformations { get; set; }
        public virtual DbSet<componentinformation> componentinformations { get; set; }
        public virtual DbSet<incomeinformation> incomeinformations { get; set; }
        public virtual DbSet<inspectinformation> inspectinformations { get; set; }
        public virtual DbSet<inspectreport> inspectreports { get; set; }
        public virtual DbSet<ordercontract> ordercontracts { get; set; }
        public virtual DbSet<pickingtable> pickingtables { get; set; }
        public virtual DbSet<pickstockinformation> pickstockinformations { get; set; }
        public virtual DbSet<plancomponentlist> plancomponentlists { get; set; }
        public virtual DbSet<purchasecontract> purchasecontracts { get; set; }
        public virtual DbSet<rightmanagement> rightmanagements { get; set; }
        public virtual DbSet<rolemanagement> rolemanagements { get; set; }
        public virtual DbSet<stockerrorinformation> stockerrorinformations { get; set; }
        public virtual DbSet<stockinformation> stockinformations { get; set; }
        public virtual DbSet<usermanagement> usermanagements { get; set; }
        public virtual DbSet<userrole> userroles { get; set; }
        public virtual DbSet<t_inspectreport> t_inspectreport { get; set; }
        public virtual DbSet<t_picktable> t_picktable { get; set; }
        public virtual DbSet<t_plancomponentlist> t_plancomponentlist { get; set; }
        public virtual DbSet<vendorinformation> vendorinformations { get; set; }
    }
}