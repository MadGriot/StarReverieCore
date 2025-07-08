using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarReverieCore.Models;
using StarReverieCore.Mechanics;

namespace StarReverieCore.Configurations
{
    class SkillConfiguration : IEntityTypeConfiguration<SkillModel>
    {
        public void Configure(EntityTypeBuilder<SkillModel> builder)
        {

        }
    }
}
