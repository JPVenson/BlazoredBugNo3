using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.Video;
using Blazored.Video.Support;
using Microsoft.AspNetCore.Components;

namespace BlazoredBugNo3.Pages
{
	public class IndexBase : ComponentBase
	{
		public IndexBase()
		{
			
		}

		public BlazoredVideo BlazoredVideo { get; set; }

		public void OnPlayerPlayed(VideoState obj)
		{
			Console.WriteLine("State is " + (obj?.ToString() ?? "NULL"));
		}
	}
}
