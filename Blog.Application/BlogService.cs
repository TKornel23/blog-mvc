using Blog.Persistence;

namespace Blogs;

public class BlogService : IBlogService
{
	private readonly IUnitOfWork _unitOfWork;

	public BlogService(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;
	}

	public IEnumerable<Blog.Persistence.Blog> GetBlogsForMainPage()
	{
		var blogs = this._unitOfWork.BlogRepository.Get(orderBy: o => o.OrderByDescending(x => x.Created), includeProperties: "Comments,Tags").ToList();

		blogs.ForEach(x =>
		{
			x.Comments = x.Comments?.Take(5).ToList();
			x.Tags = x.Tags?.Take(5).ToList();

			if(x.BlogText.Length >= 100)
			{
				x.BlogText = x.BlogText.Substring(0, 100);
			}
		});

		return blogs;
	}
}
