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


namespace Pendu.Entities.Mappers
{
    using Pendu.Common.Entities;
    using Pendu.Entities.Models;

    // PenduUserClaims
    public class PenduUserClaimMap : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PenduUserClaim>
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
        }
    }

}
// </auto-generated>
