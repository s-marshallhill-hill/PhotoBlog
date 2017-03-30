using System;
using System.Collections.Generic;

namespace PhotoBlog.Models
{
	public class PhotoEntry
	{
		static int currentID = 0;
		private int Id { get; set; }
		public string Title { get; set; }
		public string Photo { get; set; }
		public string Description { get; set; }
		public LinkedList<PhotoComment> Comments;

		public PhotoEntry()
		{
			this.Id = currentID++;

			Comments = new LinkedList<PhotoComment>();
		}

		public void AddComment(PhotoComment comment)
		{
			this.Comments.AddLast(comment);
		}
	}
}
