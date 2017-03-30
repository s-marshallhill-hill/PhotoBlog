using System;

namespace Photo_Service
{
	public class PhotoEntryService : IPhotoEntryService
	{
		private PhotoEntry[] PhotoEntries = new PhotoEntry[] {
				new PhotoEntry
				{
					Title =  "Burning Sundown Behind Trees",
					Description = "A view of the setting sun through trees",
					Photo = ("/Content/Images/Burning-sundown-behind-trees.jpg"),
				},
				new PhotoEntry
				{
					Title = "Water Lilies and Algas",
					Description = "Still water with floating lilies",
					Photo = ("/Content/Images/Water-lilies-and-algas.jpg"),
				},
				new PhotoEntry
				{
					Title = "German Steam Engine",
					Description = "Trains at the station",
					Photo = ("/Content/Images/German-steam-engine-No.4.jpg"),
				},
				new PhotoEntry
				{
					Title = "Red Sun Stripe at Horizon",
					Description = "Green fields and a glimpse of sunlight",
					Photo = ("/Content/Images/Red-sun-stripe-at-horizon.jpg"),
				},
				new PhotoEntry
				{
					Title = "Sundown Behind Fields",
					Description = "Clouds taking form at sun set",
					Photo = ("/Content/Images/Sundown-behind-fields.jpg"),
				}
			};

		public PhotoEntryService()
		{
		}

		public PhotoEntry[] GetAllPhotoEntries()
		{
			return this.PhotoEntries;

		}
	}
}
