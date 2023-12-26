using Microsoft.Extensions.Logging;

namespace DTI_Generative_AI_Academic_Yearly_Report;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("OpenSans-Bold.ttf", "OpenSansBold");
				fonts.AddFont("OpenSans-Light.ttf", "OpenSansLight");
				fonts.AddFont("OpenSans-ExtraBold.ttf", "OpenSansExtraBold");
				fonts.AddFont("OpenSans-Italic.ttf", "OpenSansItalic");
				fonts.AddFont("OpenSans-LightItalic.ttf", "OpenSansLightItalic");
				fonts.AddFont("OpenSans-SemiboldItalic.ttf", "OpenSansSemiboldItalic");
				fonts.AddFont("OpenSans-BoldItalic.ttf", "OpenSansBoldItalic");
				fonts.AddFont("OpenSans-ExtraBoldItalic.ttf", "OpenSansExtraBoldItalic");
				fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
				fonts.AddFont("Roboto-Medium.ttf", "RobotoMedium");
				fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
				fonts.AddFont("Roboto-Light.ttf", "RobotoLight");
				fonts.AddFont("Roboto-Thin.ttf", "RobotoThin");
				fonts.AddFont("Roboto-Italic.ttf", "RobotoItalic");
				fonts.AddFont("Roboto-MediumItalic.ttf", "RobotoMediumItalic");
				fonts.AddFont("Roboto-BoldItalic.ttf", "RobotoBoldItalic");
				fonts.AddFont("Roboto-LightItalic.ttf", "RobotoLightItalic");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
