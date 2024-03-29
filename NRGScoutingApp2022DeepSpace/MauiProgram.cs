﻿using Microsoft.Extensions.Logging;
using NRGScoutingApp2022DeeoSpace.Lib.Data;
using NRGScoutingApp2022DeepSpace.Helpers;
using NRGScoutingApp2022DeepSpace.Views;

namespace NRGScoutingApp2022DeepSpace;

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
				fonts.AddFont("fa_solid.ttf", "FontAwesome");
			})
            .RegisterServices();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
