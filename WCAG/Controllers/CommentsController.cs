using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace WCAG.Controllers
{
	public class CommentsController : Controller
	{
		public static IEnumerable<Comment> _comments = new List<Comment>()
		{
			new Comment("Hello world...", "Peter"),
			new Comment("Titta jag kommenterar.", "John"),
			new Comment("Bara en kommentar till...", "Frida"),
			new Comment("Sluta kommentera. Börja jobba!", "Chefen"),
			new Comment("Att kommentera är roligt!", "Peter"),
			new Comment("Ja, det var roligt...", "Chefen"),
		};

		public ActionResult Index(int skip = 0, int take = 2)
		{
			ViewBag.Skip = skip;
			ViewBag.Take = take;
			var comments = _comments.Skip(skip).Take(take).ToArray();
			return View(comments);
		}

		public ActionResult More(int skip, int take)
		{
			ViewBag.Skip = skip;
			ViewBag.Take = take;
			var comments = _comments.Skip(skip).Take(take).ToArray();
			return PartialView("_Comment", comments);
		}
	}

	public class Comment
	{
		public Comment(string content, string name)
		{
			Content = content;
			Name = name;
		}

		public string Content { get; set; }
		public string Name { get; set; }

	}
}