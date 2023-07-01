namespace Blog.Persistence;

internal class BlogModelConfiguration : IEntityTypeConfiguration<Blog>
{
    public void Configure(EntityTypeBuilder<Blog> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasMany(x =>x.Comments)
            .WithOne(x => x.Blog)
            .HasForeignKey(x =>x.BlogId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(x => x.Tags)
            .WithOne(x => x.Blog)
            .HasForeignKey(x => x.BlogId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
