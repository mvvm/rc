using BundleTransformer.Core.Transformers;
using System.Web;
using System.Web.Optimization;

namespace Rc.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            var baseAngular = new ScriptBundle("~/bundles/angularjs")
                .Include("~/Scripts/angular.js")
                .Include("~/Scripts/i18n/angular-locale_ru-ru.js") //Need this to correctly format | date : 'short' and such for RU format dd.MM.yyyy
                .Include("~/Scripts/angular-route.min.js")
                .Include("~/Scripts/ng-infinite-scroll.min.js")
                .Include("~/Scripts/angular-sanitize.js")
                .Include("~/Scripts/angular-filter.min.js");
            baseAngular.Transforms.Add(new ScriptTransformer());


            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(baseAngular);
        }
    }
}
