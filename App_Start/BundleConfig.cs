using System.Web;
using System.Web.Optimization;

namespace ProjectDotNet
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js").Include(
                        "~/Scripts/BacToTop.js",
                        "~/Scripts/bstable.js",
                        "~/Scripts/CartAtHover.js",
                        "~/Scripts/click-filter.js",
                        "~/Scripts/clickAddCart.js",
                        "~/Scripts/hover-product.js",
                        "~/Scripts/nav-responsive.js",
                        "~/Scripts/product-bestseller.js",
                        "~/Scripts/register.js",
                        "~/Scripts/ripple-button.js",
                        "~/Scripts/Scroll-Indicator.js",
                        "~/Scripts/slick-all-product.js",
                        "~/Scripts/slider.js",
                        "~/Scripts/tabs-table.js",
                        "~/Scripts/tab.js",
                        "~/Scripts/view-image-product.js",
                        "~/Scripts/visibleCart.js"
                        ));

            bundles.Add(new StyleBundle("~/css").Include(
                      "~/Content/style.css",
                      "~/Content/about.css",
                      "~/Content/admin.css",
                      "~/Content/cart.css",
                      "~/Content/cartResponsive.css",
                      "~/Content/reponsiveProduct.css",
                      "~/Content/responsiveIndex.css",
                      "~/Content/style-product.css",
                      "~/Content/style-tutorial.css"
                      ));
        }
    }
}
