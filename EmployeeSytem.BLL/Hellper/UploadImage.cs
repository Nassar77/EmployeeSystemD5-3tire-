﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSytem.BLL.Hellper
{
	public static class UploadImage
	{

		public static string UploadFile(string FolderName, IFormFile File)
		{

			try
			{
				//catch the folder Path and the file name in server
				// 1 ) Get Directory
				string FolderPath = Directory.GetCurrentDirectory() + "/wwwroot/Image/" + FolderName;


				//2) Get File Name
				string FileName = Guid.NewGuid() + Path.GetFileName(File.FileName);
				//Guid => Word contain from 36 character

				// 3) Merge Path with File Name
				string FinalPath = Path.Combine(FolderPath, FileName);
				//combine put /

				//4) Save File As Streams "Data Overtime"
				using (var Stream = new FileStream(FinalPath, FileMode.Create))
				{
					File.CopyTo(Stream);
				}

				return FileName;
			}
			catch (Exception ex)
			{
				return ex.Message;
			}

		}

	}
}
