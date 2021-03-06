﻿

// ------------------------------------------------------------------------------------------------
// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.com/).
// Created by Simon Hughes (https://about.me/simon.hughes).
//
// Do not make changes directly to this file - edit the template instead.
//
// The following connection settings were used to generate this file:
//     Configuration file:     "Pendu\Web.config"
//     Connection String Name: "PenduConnection"
//     Connection String:      "Data Source=(LocalDb)\v11.0;AttachDbFilename=C:\Projects\SQL\penduSQL.mdf;Integrated Security=True"
// ------------------------------------------------------------------------------------------------
// Database Edition       : Express Edition (64-bit)
// Database Engine Edition: Express

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
    using Pendu.Entities.Models;
    using Pendu.Entities.Mappers;
    using System.Linq;

    #region Unit of work

    public partial interface IPenduDbContext : System.IDisposable
    {
        System.Data.Entity.DbSet<PenduRole> PenduRoles { get; set; } // PenduRoles
        System.Data.Entity.DbSet<PenduUser> PenduUsers { get; set; } // PenduUsers
        System.Data.Entity.DbSet<PenduUserClaim> PenduUserClaims { get; set; } // PenduUserClaims
        System.Data.Entity.DbSet<PenduUserLogin> PenduUserLogins { get; set; } // PenduUserLogins

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();

        // Stored Procedures
        System.Collections.Generic.List<UspGetUserInformationReturnModel> UspGetUserInformation();
        System.Collections.Generic.List<UspGetUserInformationReturnModel> UspGetUserInformation(out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetUserInformationReturnModel>> UspGetUserInformationAsync();

    }

    #endregion

    #region Database context

    public partial class PenduDbContext : System.Data.Entity.DbContext, IPenduDbContext
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
            InitializePartial();
        }

        public PenduDbContext(string connectionString)
            : base(connectionString)
        {
            InitializePartial();
        }

        public PenduDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
            InitializePartial();
        }

        public PenduDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
            InitializePartial();
        }

        public PenduDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
            InitializePartial();
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

            OnModelCreatingPartial(modelBuilder);
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new PenduRoleMap(schema));
            modelBuilder.Configurations.Add(new PenduUserMap(schema));
            modelBuilder.Configurations.Add(new PenduUserClaimMap(schema));
            modelBuilder.Configurations.Add(new PenduUserLoginMap(schema));
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void OnModelCreatingPartial(System.Data.Entity.DbModelBuilder modelBuilder);

        // Stored Procedures
        public System.Collections.Generic.List<UspGetUserInformationReturnModel> UspGetUserInformation()
        {
            int procResult;
            return UspGetUserInformation(out procResult);
        }

        public System.Collections.Generic.List<UspGetUserInformationReturnModel> UspGetUserInformation(out int procResult)
        {
            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<UspGetUserInformationReturnModel>("EXEC @procResult = [dbo].[usp_GetUserInformation] ", procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetUserInformationReturnModel>> UspGetUserInformationAsync()
        {
            var procResultData = await Database.SqlQuery<UspGetUserInformationReturnModel>("EXEC [dbo].[usp_GetUserInformation] ").ToListAsync();

            return procResultData;
        }

    }
    #endregion

    #region Database context factory

    public class PenduDbContextFactory : System.Data.Entity.Infrastructure.IDbContextFactory<PenduDbContext>
    {
        public PenduDbContext Create()
        {
            return new PenduDbContext();
        }
    }

    #endregion

    #region POCO classes
    /*
        // PenduRoles
        public partial class PenduRole
        {
            public string Id { get; set; } // Id (Primary key) (length: 128)
            public string Name { get; set; } // Name (length: 256)

            // Reverse navigation

            /// <summary>
            /// Child PenduUsers (Many-to-Many) mapped by table [PenduUserRoles]
            /// </summary>
            public virtual System.Collections.Generic.ICollection<PenduUser> PenduUsers { get; set; } // Many to many mapping

            public PenduRole()
            {
                PenduUsers = new System.Collections.Generic.List<PenduUser>();
                InitializePartial();
            }

            partial void InitializePartial();
        }

        // PenduUsers
        public partial class PenduUser
        {
            public string Id { get; set; } // Id (Primary key) (length: 128)
            public string Email { get; set; } // Email (length: 256)
            public bool EmailConfirmed { get; set; } // EmailConfirmed
            public string PasswordHash { get; set; } // PasswordHash
            public string SecurityStamp { get; set; } // SecurityStamp
            public string PhoneNumber { get; set; } // PhoneNumber
            public bool PhoneNumberConfirmed { get; set; } // PhoneNumberConfirmed
            public bool TwoFactorEnabled { get; set; } // TwoFactorEnabled
            public System.DateTime? LockoutEndDateUtc { get; set; } // LockoutEndDateUtc
            public bool LockoutEnabled { get; set; } // LockoutEnabled
            public int AccessFailedCount { get; set; } // AccessFailedCount
            public string UserName { get; set; } // UserName (length: 256)

            // Reverse navigation

            /// <summary>
            /// Child PenduRoles (Many-to-Many) mapped by table [PenduUserRoles]
            /// </summary>
            public virtual System.Collections.Generic.ICollection<PenduRole> PenduRoles { get; set; } // Many to many mapping
            /// <summary>
            /// Child PenduUserClaims where [PenduUserClaims].[UserId] point to this entity (FK_dbo.PenduUserClaims_dbo.PenduUsers_UserId)
            /// </summary>
            public virtual System.Collections.Generic.ICollection<PenduUserClaim> PenduUserClaims { get; set; } // PenduUserClaims.FK_dbo.PenduUserClaims_dbo.PenduUsers_UserId
            /// <summary>
            /// Child PenduUserLogins where [PenduUserLogins].[UserId] point to this entity (FK_dbo.PenduUserLogins_dbo.PenduUsers_UserId)
            /// </summary>
            public virtual System.Collections.Generic.ICollection<PenduUserLogin> PenduUserLogins { get; set; } // PenduUserLogins.FK_dbo.PenduUserLogins_dbo.PenduUsers_UserId

            public PenduUser()
            {
                PenduUserClaims = new System.Collections.Generic.List<PenduUserClaim>();
                PenduUserLogins = new System.Collections.Generic.List<PenduUserLogin>();
                PenduRoles = new System.Collections.Generic.List<PenduRole>();
                InitializePartial();
            }

            partial void InitializePartial();
        }

        // PenduUserClaims
        public partial class PenduUserClaim
        {
            public int Id { get; set; } // Id (Primary key)
            public string UserId { get; set; } // UserId (length: 128)
            public string ClaimType { get; set; } // ClaimType
            public string ClaimValue { get; set; } // ClaimValue

            // Foreign keys

            /// <summary>
            /// Parent PenduUser pointed by [PenduUserClaims].([UserId]) (FK_dbo.PenduUserClaims_dbo.PenduUsers_UserId)
            /// </summary>
            public virtual PenduUser PenduUser { get; set; } // FK_dbo.PenduUserClaims_dbo.PenduUsers_UserId

            public PenduUserClaim()
            {
                InitializePartial();
            }

            partial void InitializePartial();
        }

        // PenduUserLogins
        public partial class PenduUserLogin
        {
            public string LoginProvider { get; set; } // LoginProvider (Primary key) (length: 128)
            public string ProviderKey { get; set; } // ProviderKey (Primary key) (length: 128)
            public string UserId { get; set; } // UserId (Primary key) (length: 128)

            // Foreign keys

            /// <summary>
            /// Parent PenduUser pointed by [PenduUserLogins].([UserId]) (FK_dbo.PenduUserLogins_dbo.PenduUsers_UserId)
            /// </summary>
            public virtual PenduUser PenduUser { get; set; } // FK_dbo.PenduUserLogins_dbo.PenduUsers_UserId

            public PenduUserLogin()
            {
                InitializePartial();
            }

            partial void InitializePartial();
        }

        #endregion

        #region POCO Configuration

        // PenduRoles
        public partial class PenduRoleMap : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PenduRole>
        {
            public PenduRoleMap()
                : this("dbo")
            {
            }

            public PenduRoleMap(string schema)
            {
                ToTable("PenduRoles", schema);
                HasKey(x => x.Id);

                Property(x => x.Id).HasColumnName(@"Id").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
                Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(256);
                HasMany(t => t.PenduUsers).WithMany(t => t.PenduRoles).Map(m =>
                {
                    m.ToTable("PenduUserRoles", "dbo");
                    m.MapLeftKey("RoleId");
                    m.MapRightKey("UserId");
                });
                InitializePartial();
            }
            partial void InitializePartial();
        }

        // PenduUsers
        public partial class PenduUserMap : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PenduUser>
        {
            public PenduUserMap()
                : this("dbo")
            {
            }

            public PenduUserMap(string schema)
            {
                ToTable("PenduUsers", schema);
                HasKey(x => x.Id);

                Property(x => x.Id).HasColumnName(@"Id").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
                Property(x => x.Email).HasColumnName(@"Email").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
                Property(x => x.EmailConfirmed).HasColumnName(@"EmailConfirmed").HasColumnType("bit").IsRequired();
                Property(x => x.PasswordHash).HasColumnName(@"PasswordHash").HasColumnType("nvarchar(max)").IsOptional();
                Property(x => x.SecurityStamp).HasColumnName(@"SecurityStamp").HasColumnType("nvarchar(max)").IsOptional();
                Property(x => x.PhoneNumber).HasColumnName(@"PhoneNumber").HasColumnType("nvarchar(max)").IsOptional();
                Property(x => x.PhoneNumberConfirmed).HasColumnName(@"PhoneNumberConfirmed").HasColumnType("bit").IsRequired();
                Property(x => x.TwoFactorEnabled).HasColumnName(@"TwoFactorEnabled").HasColumnType("bit").IsRequired();
                Property(x => x.LockoutEndDateUtc).HasColumnName(@"LockoutEndDateUtc").HasColumnType("datetime").IsOptional();
                Property(x => x.LockoutEnabled).HasColumnName(@"LockoutEnabled").HasColumnType("bit").IsRequired();
                Property(x => x.AccessFailedCount).HasColumnName(@"AccessFailedCount").HasColumnType("int").IsRequired();
                Property(x => x.UserName).HasColumnName(@"UserName").HasColumnType("nvarchar").IsRequired().HasMaxLength(256);
                InitializePartial();
            }
            partial void InitializePartial();
        }

        // PenduUserClaims
        public partial class PenduUserClaimMap : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PenduUserClaim>
        {
            public PenduUserClaimMap()
                : this("dbo")
            {
            }

            public PenduUserClaimMap(string schema)
            {
                ToTable("PenduUserClaims", schema);
                HasKey(x => x.Id);

                Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
                Property(x => x.UserId).HasColumnName(@"UserId").HasColumnType("nvarchar").IsRequired().HasMaxLength(128);
                Property(x => x.ClaimType).HasColumnName(@"ClaimType").HasColumnType("nvarchar(max)").IsOptional();
                Property(x => x.ClaimValue).HasColumnName(@"ClaimValue").HasColumnType("nvarchar(max)").IsOptional();

                // Foreign keys
                HasRequired(a => a.PenduUser).WithMany(b => b.PenduUserClaims).HasForeignKey(c => c.UserId); // FK_dbo.PenduUserClaims_dbo.PenduUsers_UserId
                InitializePartial();
            }
            partial void InitializePartial();
        }

        // PenduUserLogins
        public partial class PenduUserLoginMap : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PenduUserLogin>
        {
            public PenduUserLoginMap()
                : this("dbo")
            {
            }

            public PenduUserLoginMap(string schema)
            {
                ToTable("PenduUserLogins", schema);
                HasKey(x => new { x.LoginProvider, x.ProviderKey, x.UserId });

                Property(x => x.LoginProvider).HasColumnName(@"LoginProvider").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
                Property(x => x.ProviderKey).HasColumnName(@"ProviderKey").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
                Property(x => x.UserId).HasColumnName(@"UserId").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

                // Foreign keys
                HasRequired(a => a.PenduUser).WithMany(b => b.PenduUserLogins).HasForeignKey(c => c.UserId); // FK_dbo.PenduUserLogins_dbo.PenduUsers_UserId
                InitializePartial();
            }
            partial void InitializePartial();
        }
        */
    #endregion

    #region Stored procedure return models

    public partial class UspGetUserInformationReturnModel
    {
        public System.String Id { get; set; }
        public System.String Email { get; set; }
        public System.Boolean EmailConfirmed { get; set; }
        public System.String PasswordHash { get; set; }
        public System.String SecurityStamp { get; set; }
        public System.String PhoneNumber { get; set; }
        public System.Boolean PhoneNumberConfirmed { get; set; }
        public System.Boolean TwoFactorEnabled { get; set; }
        public System.DateTime? LockoutEndDateUtc { get; set; }
        public System.Boolean LockoutEnabled { get; set; }
        public System.Int32 AccessFailedCount { get; set; }
        public System.String UserName { get; set; }
    }
    

    #endregion

}
// </auto-generated>

