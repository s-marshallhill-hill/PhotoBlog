using System;
using PhotoBlog.Models;
namespace PhotoBlog.Services
{
	public interface IPhotoEntryService
	{
		PhotoEntry[] GetAllPhotoEntries();
	}
}
