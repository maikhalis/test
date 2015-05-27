using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBootStrap.Helpers.Static;

namespace WebBootStrap.Helpers.Extension
{
    public static class HtmlExtensionTypeHelper
    {
        /// <summary>
        /// Create a boot strap button providing HTML id, caption bootstrap style and size.
        /// </summary>
        /// <param name="id"> the button id. </param>
        /// <param name="caption"> the button caption. </param>
        /// <param name="style"> the button bootstrap style. </param>
        /// <param name="size"> the button bootstrap size. </param>
        /// <returns> a HMTL encoded button tag. </returns>
        public static MvcHtmlString ButtonHtmlExtension(this HtmlHelper helper,
            string id, string caption, Enums.ButtonStyle style, Enums.ButtonSize size)
        {
            return StaticTypeHelper.Button(id, caption, style, size);
        }

        /// <summary>
        /// Create a boot strap button providing HTML id, caption bootstrap style using defaut size.
        /// </summary>
        /// <param name="id"> the button id. </param>
        /// <param name="caption"> the button caption. </param>
        /// <param name="style"> the button bootstrap style. </param>
        /// <returns> a HMTL encoded button tag. </returns>
        public static MvcHtmlString ButtonHtmlExtension(this HtmlHelper helper,
            string id, string caption, Enums.ButtonStyle style)
        {
            return StaticTypeHelper.Button(id, caption, style);
        }
    }
}