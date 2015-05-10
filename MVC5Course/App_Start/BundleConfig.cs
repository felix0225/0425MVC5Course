﻿using System.Web;
using System.Web.Optimization;

namespace MVC5Course
{
    public class BundleConfig
    {
        // 如需「搭配」的詳細資訊，請瀏覽 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            bundles.IgnoreList.Ignore("*.intellisense.js");
            bundles.IgnoreList.Ignore("*-vsdoc.js");
            bundles.IgnoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);
            // bundles.IgnoreList.Ignore("*.min.js", OptimizationMode.WhenDisabled);
            // bundles.IgnoreList.Ignore("*.min.css", OptimizationMode.WhenDisabled);

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.unobtrusive-ajax.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好實際執行時，請使用 http://modernizr.com 上的建置工具，只選擇您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/metrojs").Include(
                        "~/js/jquery-1.9.1.min.js",
                        "~/js/jquery-migrate-1.0.0.min.js",
                        "~/js/jquery-ui-1.10.0.custom.min.js",
                        "~/js/jquery.ui.touch-punch.js",
                        "~/js/modernizr.js",
                        "~/js/bootstrap.min.js",
                        "~/js/jquery.cookie.js",
                        "~/js/fullcalendar.min.js",
                        "~/js/jquery.dataTables.min.js",
                        "~/js/excanvas.js",
                        "~/js/jquery.flot.js",
                        "~/js/jquery.flot.pie.js",
                        "~/js/jquery.flot.stack.js",
                        "~/js/jquery.flot.resize.min.js",
                        "~/js/jquery.chosen.min.js",
                        "~/js/jquery.uniform.min.js",
                        "~/js/jquery.cleditor.min.js",
                        "~/js/jquery.noty.js",
                        "~/js/jquery.elfinder.min.js",
                        "~/js/jquery.raty.min.js",
                        "~/js/jquery.iphone.toggle.js",
                        "~/js/jquery.uploadify-3.1.min.js",
                        "~/js/jquery.gritter.min.js",
                        "~/js/jquery.imagesloaded.js",
                        "~/js/jquery.masonry.min.js",
                        "~/js/jquery.knob.modified.js",
                        "~/js/jquery.sparkline.min.js",
                        "~/js/counter.js",
                        "~/js/retina.js",
                        "~/js/custom.js"));
        }
    }
}
