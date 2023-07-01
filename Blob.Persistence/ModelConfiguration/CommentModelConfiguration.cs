namespace Blog.Persistence;

internal class CommentModelConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Owner)
            .WithMany(x => x.Comments)
            .HasForeignKey(x => x.OwnerId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
