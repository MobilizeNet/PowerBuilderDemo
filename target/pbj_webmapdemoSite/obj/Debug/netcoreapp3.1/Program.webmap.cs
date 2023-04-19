#pragma warning disable
#line 1 "Program.cs"
#pragma warning disable
#line 1 "Program.cs"

namespace pbj_webmapdemoSite
{
    using System;

    [Mobilize.WebMap.Common.Attributes.Observable]
    static partial class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            (Mobilize.Web.Application.CurrentApplication as pbj_webmapdemo.Application).DoWmInit();
			(Mobilize.Web.Application.CurrentApplication as pbj_webmapdemo.Application).Create();
            if (args != null)
            {
                (Mobilize.Web.Application.CurrentApplication as pbj_webmapdemo.Application).OpenWindow(string.Join(" ", args));
            }
            else
            {
                (Mobilize.Web.Application.CurrentApplication as pbj_webmapdemo.Application).OpenWindow(string.Empty);
            }
        }
    }
}


#pragma warning restore
