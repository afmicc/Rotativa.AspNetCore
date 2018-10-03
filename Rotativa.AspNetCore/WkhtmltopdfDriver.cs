using System.Runtime.InteropServices;

namespace Rotativa.AspNetCore
{
    public class WkhtmltopdfDriver : WkhtmlDriver
    {
        private const string wkhtmlExe = "wkhtmltopdf.exe";
        private const string wkhtmlLinuxCommand = "wkhtmltopdf";

        /// <summary>
        /// Converts given HTML string to PDF.
        /// </summary>
        /// <param name="wkhtmltopdfPath">Path to wkthmltopdf.</param>
        /// <param name="switches">Switches that will be passed to wkhtmltopdf binary.</param>
        /// <param name="html">String containing HTML code that should be converted to PDF.</param>
        /// <returns>PDF as byte array.</returns>
        public static byte[] ConvertHtml(string wkhtmltopdfPath, string switches, string html)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return ConvertOnWindows(wkhtmltopdfPath, switches, html, wkhtmlExe);

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                return ConvertOnLinux(wkhtmltopdfPath, switches, html, wkhtmlLinuxCommand);

            throw new System.PlatformNotSupportedException();
        }

        /// <summary>
        /// Converts given URL to PDF.
        /// </summary>
        /// <param name="wkhtmltopdfPath">Path to wkthmltopdf.</param>
        /// <param name="switches">Switches that will be passed to wkhtmltopdf binary.</param>
        /// <returns>PDF as byte array.</returns>
        public static byte[] Convert(string wkhtmltopdfPath, string switches)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return ConvertOnWindows(wkhtmltopdfPath, switches, null, wkhtmlExe);

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                return ConvertOnLinux(wkhtmlLinuxCommand, switches, null, wkhtmlLinuxCommand);

            throw new System.PlatformNotSupportedException();
        }
    }
}
