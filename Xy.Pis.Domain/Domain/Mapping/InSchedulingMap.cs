using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class InSchedulingMap : EntityTypeConfiguration<InScheduling>
    {
        public InSchedulingMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("InScheduling");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HappenTime).HasColumnName("HappenTime");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.Day1).HasColumnName("Day1");
            this.Property(t => t.Day2).HasColumnName("Day2");
            this.Property(t => t.Day3).HasColumnName("Day3");
            this.Property(t => t.Day4).HasColumnName("Day4");
            this.Property(t => t.Day5).HasColumnName("Day5");
            this.Property(t => t.Day6).HasColumnName("Day6");
            this.Property(t => t.Day7).HasColumnName("Day7");
            this.Property(t => t.Day8).HasColumnName("Day8");
            this.Property(t => t.Day9).HasColumnName("Day9");
            this.Property(t => t.Day10).HasColumnName("Day10");
            this.Property(t => t.Day11).HasColumnName("Day11");
            this.Property(t => t.Day12).HasColumnName("Day12");
            this.Property(t => t.Day13).HasColumnName("Day13");
            this.Property(t => t.Day14).HasColumnName("Day14");
            this.Property(t => t.Day15).HasColumnName("Day15");
            this.Property(t => t.Day16).HasColumnName("Day16");
            this.Property(t => t.Day17).HasColumnName("Day17");
            this.Property(t => t.Day18).HasColumnName("Day18");
            this.Property(t => t.Day19).HasColumnName("Day19");
            this.Property(t => t.Day20).HasColumnName("Day20");
            this.Property(t => t.Day21).HasColumnName("Day21");
            this.Property(t => t.Day22).HasColumnName("Day22");
            this.Property(t => t.Day23).HasColumnName("Day23");
            this.Property(t => t.Day24).HasColumnName("Day24");
            this.Property(t => t.Day25).HasColumnName("Day25");
            this.Property(t => t.Day26).HasColumnName("Day26");
            this.Property(t => t.Day27).HasColumnName("Day27");
            this.Property(t => t.Day28).HasColumnName("Day28");
            this.Property(t => t.Day29).HasColumnName("Day29");
            this.Property(t => t.Day30).HasColumnName("Day30");
            this.Property(t => t.Day31).HasColumnName("Day31");
        }
    }
}
