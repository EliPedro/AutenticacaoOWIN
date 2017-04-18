using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace OwinAuthentication.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));


            bundles.Add(new ScriptBundle("~/js").Include(
                   "~/Scripts/helpers/mascara.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                       "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(                 
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //bundles.Add(new StyleBundle("~/awes").Include(
            //          "~/Content/awesome/font-awesome.cs",
            //          "~/Content/awesome/bootstrap-social.cs"));

            bundles.Add(new ScriptBundle("~/bundles/inputmask").Include(
            "~/Scripts/jquery.inputmask/inputmask.js",
            "~/Scripts/jquery.inputmask/jquery.inputmask.js",
            "~/Scripts/jquery.inputmask/inputmask.extensions.js",
            "~/Scripts/jquery.inputmask/inputmask.date.extensions.js",
            "~/Scripts/jquery.inputmask/inputmask.numeric.extensions.js"));

            // SignalR bundle
            bundles.Add(new ScriptBundle("~/bundles/SignalR").Include(
                        "~/Scripts/jquery.signalR-{version}.js"));


        }
    }
}