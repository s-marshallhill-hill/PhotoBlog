using System;
namespace Photo_Service
{
	public interface IPhotoEntryService
	{
		PhotoEntry[] GetAllPhotoEntries();
	}
}
