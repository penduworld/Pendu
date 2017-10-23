// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace Pendu.Persistence.Data
{
    using Pendu.Common.Entities;


    public class PenduDbContext : System.Data.Entity.DbContext, IPenduDbContext
    {
        public System.Data.Entity.DbSet<PenduRole> PenduRoles { get; set; } // PenduRoles
        public System.Data.Entity.DbSet<PenduUser> PenduUsers { get; set; } // PenduUsers
        public System.Data.Entity.DbSet<PenduUserClaim> PenduUserClaims { get; set; } // PenduUserClaims
        public System.Data.Entity.DbSet<PenduUserLogin> PenduUserLogins { get; set; } // PenduUserLogins

        static PenduDbContext()
        {
            System.Data.Entity.Database.SetInitializer<PenduDbContext>(null);
        }

        public PenduDbContext()
            : base("Name=PenduConnection")
        {
        }

        public PenduDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public PenduDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public PenduDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public PenduDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new PenduRoleMap());
            modelBuilder.Configurations.Add(new PenduUserMap());
            modelBuilder.Configurations.Add(new PenduUserClaimMap());
            modelBuilder.Configurations.Add(new PenduUserLoginMap());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new PenduRoleMap(schema));
            modelBuilder.Configurations.Add(new PenduUserMap(schema));
            modelBuilder.Configurations.Add(new PenduUserClaimMap(schema));
            modelBuilder.Configurations.Add(new PenduUserLoginMap(schema));
            return modelBuilder;
        }
    }
}
// </auto-generated>
