using System.Diagnostics;
using System.Globalization;
using System.Reflection;

namespace AssemblyInfoHelper
{
    public class Helper
    {
        #region Singleton
        private Helper() { }
        public static Helper Instance { get; }
        static Helper()
        {
            Instance = new Helper();
        }
        #endregion

        #region Public Methods
        public string GetVersion()
        {
            Assembly _this = Assembly.GetExecutingAssembly();
            FileVersionInfo version = FileVersionInfo.GetVersionInfo(_this.Location);

            return string.Format(CultureInfo.InvariantCulture, "{0}.{1:D2}.{2:D2}",
                version.ProductMajorPart,
                version.ProductMinorPart,
                version.ProductBuildPart);
        }

        
        public string GetCompanyName()
        {
            Assembly _this = Assembly.GetExecutingAssembly();
            FileVersionInfo version = FileVersionInfo.GetVersionInfo(_this.Location);

            return version.CompanyName;
        }

        public string GetProductName()
        {
            Assembly _this = Assembly.GetExecutingAssembly();
            FileVersionInfo version = FileVersionInfo.GetVersionInfo(_this.Location);

            return version.ProductName;
        }

        public string GetCopyright()
        {
            Assembly _this = Assembly.GetExecutingAssembly();
            FileVersionInfo version = FileVersionInfo.GetVersionInfo(_this.Location);

            return version.LegalCopyright;
        }
        #endregion

    }
}
