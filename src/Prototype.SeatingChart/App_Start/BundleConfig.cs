using System.Web;
using System.Web.Optimization;

namespace Prototype.SeatingChart
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/kendo")
                .Include(
                    "~/Scripts/kendo/2014.3.1119/jquery.min.js",
                    "~/Scripts/kendo/2014.3.1119/jszip.min.js",
                    "~/Scripts/kendo/2014.3.1119/kendo.all.min.js",
                    "~/Scripts/kendo/2014.3.1119/kendo.aspnetmvc.min.js",
                    "~/Scripts/kendo.modernizr.custom.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css")
                .Include(
                "~/Content/bootstrap.css",
                "~/Content/kendo/2014.3.1119/kendo.common.min.css",
                "~/Content/kendo/2014.3.1119/kendo.mobile.all.min.css",
                "~/Content/kendo/2014.3.1119/kendo.dataviz.min.css",
                "~/Content/kendo/2014.3.1119/kendo.dataviz.flat.min.css",
                "~/Content/kendo/2014.3.1119/kendo.flat.min.css",
                "~/Content/kendo/2014.3.1119/kendo.dataviz.flat.min.css",
                "~/Content/site.css"));
        }
    }
}
