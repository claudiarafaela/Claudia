using System.Web;
using System.Web.Optimization;

namespace ProyectoBase
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Assets/js/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Assets/js/modernizr-*"));


            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        
                       ));

            bundles.Add(new StyleBundle("~/Content/voler").Include(
                     "~/Assets/css/bootstrap-voler.css",
                     "~/Assets/vendors/chartjs/Chart.min.css",
                      "~/Assets/vendors/perfect-scrollbar/perfect-scrollbar.css",
                     "~/Assets/css/app.css",
                     "~/Content/PagedList.css"
                    ));

            bundles.Add(new ScriptBundle("~/Scripts/voler").Include(
                "~/Assets/js/jquery-3.4.1.js",
                         "~/Assets/js/bootstrap.js",
                        "~/Assets/js/spinner.js",
                        "~/Assets/js/pagination.js",
                    "~/Assets/js/feather-icons/feather.min.js",
                    "~/Assets/vendors/perfect-scrollbar/perfect-scrollbar.min.js",
                    "~/Assets/js/app.js",
                    "~/Assets/vendors/chartjs/Chart.min.js",
                    "~/Assets/vendors/apexcharts/apexcharts.min.js",
                    "~/Assets/js/pages/dashboard.js",
                    "~/Assets/js/main.js"
                    ));
        }
    }
}
