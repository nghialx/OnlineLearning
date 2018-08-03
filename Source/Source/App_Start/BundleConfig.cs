using System.Web;
using System.Web.Optimization;

namespace Source
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            ///////////////////////////// Script /////////////////////////////////
            bundles.Add(new ScriptBundle("~/bundles/vendor").Include(
                        //jQuery
                        "~/Content/vendors/jquery/dist/jquery.min.js",
                        //Bootstrap
                        "~/Content/vendors/bootstrap/dist/js/bootstrap.min.js",
                        //FastClick
                        "~/Content/vendors/fastclick/lib/fastclick.js",
                        //NProgress
                        "~/Content/vendors/nprogress/nprogress.js",
                        //Chart.js
                        "~/Content/vendors/Chart.js/dist/Chart.min.js",
                        //gauge.js
                        "~/Content/vendors/gauge.js/dist/gauge.min.js",
                        //bootstrap_progressbar
                        "~/Content/vendors/bootstrap-progressbar/bootstrap-progressbar.min.js",
                        //iCheck
                        "~/Content/vendors/iCheck/icheck.min.js",
                        //Skycons
                        "~/Content/vendors/skycons/skycons.js",
                        //Flot
                        "~/Content/vendors/Flot/jquery.flot.js",
                        "~/Content/vendors/Flot/jquery.flot.pie.js",
                        "~/Content/vendors/Flot/jquery.flot.time.js",
                        "~/Content/vendors/Flot/jquery.flot.stack.js",
                        "~/Content/vendors/Flot/jquery.flot.resize.js",
                        //Flot plugins
                        "~/Content/vendors/flot.orderbars/js/jquery.flot.orderBars.js",
                        "~/Content/vendors/flot-spline/js/jquery.flot.spline.min.js",
                        "~/Content/vendors/flot.curvedlines/curvedLines.js",
                        //DateJS
                        "~/Content/vendors/DateJS/build/date.js",
                        //JQVMap
                        "~/Content/vendors/jqvmap/dist/jquery.vmap.js",
                        "~/Content/vendors/jqvmap/dist/maps/jquery.vmap.world.js",
                        "~/Content/vendors/jqvmap/examples/js/jquery.vmap.sampledata.js",
                        //Bootstrap datetimepicker
                        "~/Content/vendors/moment/min/moment.min.js",
                        "~/Content/vendors/bootstrap-daterangepicker/daterangepicker.js",
                        //bootstrap-wysiwyg
                        "~/Content/vendors/bootstrap-wysiwyg/js/bootstrap-wysiwyg.min.js",
                        "~/Content/vendors/jquery.hotkeys/jquery.hotkeys.js",
                        "~/Content/vendors/google-code-prettify/src/prettify.js",
                        //jQuery Tags Input
                        "~/Content/vendors/jquery.tagsinput/src/jquery.tagsinput.js",
                        //switcher
                        "~/Content/vendors/switchery/dist/switchery.min.js",
                        //Select2
                        "~/Content/vendors/select2/dist/js/select2.full.min.js",
                        //Parsley
                        "~/Content/vendors/parsleyjs/dist/parsley.min.js",
                        //Autosize
                        "~/Content/vendors/autosize/dist/autosize.min.js",
                        //Jquery Auto complete
                        "~/Content/vendors/devbridge-autocomplete/dist/jquery.autocomplete.min.js",
                        //Starrr
                        "~/Content/vendors/starrr/dist/starrr.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/Script-custom-editor").Include(
                       "~/Scripts/script-custom-editor.js"));

            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                        //jQuery
                        "~/Content/build/js/custom.min.js"));


            ///////////////////////////// Styles /////////////////////////////////
            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css/vendor").Include(
                "~/Content/vendors/bootstrap/dist/css/bootstrap.min.css",
                "~/Content/vendors/font-awesome/css/font-awesome.min.css",
                "~/Content/vendors/nprogress/nprogress.css",
                "~/Content/vendors/iCheck/skins/flat/green.css",
                "~/Content/vendors/bootstrap-progressbar/css/bootstrap-progressbar-3.3.4.min.css",
                "~/Content/vendors/jqvmap/dist/jqvmap.min.css",
                "~/Content/vendors/bootstrap-daterangepicker/daterangepicker.css",
                "~/Content/vendors/select2/dist/css/select2.min.css",
                "~/Content/vendors/switchery/dist/switchery.min.css",
                "~/Content/vendors/starrr/dist/starrr.css"

                ));

            bundles.Add(new StyleBundle("~/Content/css/custom").Include(
                "~/Content/build/css/custom.min.css"
                ));

            //BundleTable.EnableOptimizations = true;
        }
    }
}