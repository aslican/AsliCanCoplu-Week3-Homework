using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RepositoryPatternHW.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternHW.DataLayer.Configuration
{
    public class AnimationMovieConfiguration : IEntityTypeConfiguration<AnimationMovie>
    {
        public void Configure(EntityTypeBuilder<AnimationMovie> builder)
        {
            builder.Property(x => x.Director).IsRequired();
            builder.Property(x => x.Name).IsRequired();
            builder.HasKey(x => x.Id);
            builder.ToTable("AnimationMovies");
        }
    }
}
