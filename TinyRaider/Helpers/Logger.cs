using Buddy.Overlay.Notifications;
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;

using Styx;
using Styx.Common;
using Styx.Helpers;


namespace TinyRaider.Helpers
{
	internal class Logger
	{
		public static void PrintLog(string message, params object[] args)
		{
			Write(LogLevel.Normal, Colors.DodgerBlue, message, args);
		}

		public static void DiagnosticLog(string message, params object[] args)
		{
			Write(LogLevel.Diagnostic, Colors.MediumPurple, message, args);
		}

		private static void Write(LogLevel level, Color specificcolor, string message, params object[] args)
		{
			Logging.Write(level, specificcolor, string.Format("[GGWP] {0}", message), args);
		}
	}
}