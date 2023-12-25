using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace DTI_Generative_AI_Academic_Yearly_Report;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
