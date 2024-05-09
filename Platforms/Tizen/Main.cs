using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace mauidotnet9pre3_collectionview;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
