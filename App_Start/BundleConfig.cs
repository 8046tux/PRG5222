using System.Web;
using System.Web.Optimization;

namespace WebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            #region Template Design

            bundles.Add(new ScriptBundle("~/template/js").Include(
                        "~/Scripts/jquery-3.4.1.js",
                        "~/Scripts/active.js",
                        "~/Scripts/magnific-popup.min.js",
                        "~/Scripts/easing.js",
                        "~/Scripts/owl-carousel.min.js",
                        "~/Scripts/slicknav.min.js",
                        "~/Scripts/cubeportfolio.min.js",
                        "~/Scripts/jquery-fancybox.min.js",
                        "~/Scripts/scrollup.js",
                        "~/Scripts/modernizr-2.8.3.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/popper.min.js"));

            bundles.Add(new StyleBundle("~/template/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/animate.min.css",
                      "~/Content/cubeportfolio.min.css",
                      "~/Content/font-awesome.css",
                      "~/Content/jquery.fancybox.min.css",
                      "~/Content/magnific-popup.min.css",
                      "~/Content/owl-carousel.min.css",
                      "~/Content/reset.css",
                      "~/Content/responsive.css",
                      "~/Content/slicknav.min.css",
                      "~/Content/style.css"));

            #endregion
        }
    }
}
