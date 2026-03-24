using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
	public class PhotoArchiver
	{
		private readonly User r_LoggedInUser;
		public event Action<int, int> ProgressChanged;

		public PhotoArchiver(User i_LoggedInUser)
		{
			r_LoggedInUser = i_LoggedInUser;
		}

		public List<Photo> GetPhotosOlderThan(int i_YearsLimit)
		{
			List<Photo> oldPhotos = new List<Photo>();
			DateTime limitDate = DateTime.Now.AddYears(-i_YearsLimit);

			foreach (Album album in r_LoggedInUser.Albums)
			{
				foreach (Photo photo in album.Photos)
				{
					if (photo.CreatedTime != null && photo.CreatedTime < limitDate)
					{
						oldPhotos.Add(photo);
					}
				}
			}

			return oldPhotos;
		}

		public void DownloadPhotos(List<Photo> i_Photos, string i_DestinationPath)
		{
			int currentPhotoIndex = 0;
			int totalPhotos = i_Photos.Count;

			using (WebClient client = new WebClient())
			{
				foreach (Photo photo in i_Photos)
				{
					if (photo.CreatedTime != null && photo.PictureNormalURL != null)
					{
						string photoUrl = photo.PictureNormalURL;
						string fileName = string.Format("{0}_{1}.jpg", photo.Id, photo.CreatedTime.Value.ToString("yyyyMMdd_HHmmss"));
						string fullPath = Path.Combine(i_DestinationPath, fileName);

						try
						{
							client.DownloadFile(photoUrl, fullPath);
						}
						catch (Exception ex)
						{
							Console.WriteLine("Error downloading photo {0}: {1}", photo.Id, ex.Message);
						}

						currentPhotoIndex++;
						OnProgressChanged(currentPhotoIndex, totalPhotos);
					}
				}
			}
		}

		protected virtual void OnProgressChanged(int i_Current, int i_Total)
		{
			if (ProgressChanged != null)
			{
				ProgressChanged.Invoke(i_Current, i_Total);
			}
		}
	}
}