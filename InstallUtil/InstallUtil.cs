using System;
using System.Configuration.Install;
using System.Reflection;

namespace InstallUtil
{
	public class InstallUtil {

		static int Main (string [] args)
		{
			Console.WriteLine($"InstallUtil - {Assembly.GetExecutingAssembly().GetName().Version}");
			try
			{
				ManagedInstallerClass.InstallHelper(args);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return -1;
			}
			return 0;
		}
	}
}