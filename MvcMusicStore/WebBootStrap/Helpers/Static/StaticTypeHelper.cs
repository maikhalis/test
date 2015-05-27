using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebBootStrap.Helpers.Static
{
    public static class Enums
    {
        public enum ButtonStyle
        {
            Default,
            Primary,
            Success,
            Info,
            Warning,
            Danger,
            Link
        }

        public enum ButtonSize
        {
            ExtraSmall,
            Small,
            Normal,
            Large
        }

        public static string BootStrapSize(this Enums.ButtonSize size)
        {
            var bootstrapSize = string.Empty;
            switch (size)
            {
                case Enums.ButtonSize.ExtraSmall:
                    bootstrapSize = "xs";
                    break;
                case Enums.ButtonSize.Small:
                    bootstrapSize = "sm";
                    break;
                case Enums.ButtonSize.Large:
                    bootstrapSize = "lg";
                    break;
                case Enums.ButtonSize.Normal:
                default:
                    break;
            }
            return bootstrapSize;
        }

        public static string BootStrapStyle(this Enums.ButtonStyle style)
        {
            return style.ToString().ToLower();
        }
    }

    public class StaticTypeHelper
    {
        /// <summary>
        /// Create a boot strap button providing HTML id, caption bootstrap style and size.
        /// </summary>
        /// <param name="id"> the button id. </param>
        /// <param name="caption"> the button caption. </param>
        /// <param name="style"> the button bootstrap style. </param>
        /// <param name="size"> the button bootstrap size. </param>
        /// <returns> a HMTL encoded button tag. </returns>
        public static MvcHtmlString Button(string id, string caption, Enums.ButtonStyle style, Enums.ButtonSize size)
        {
            StringBuilder sb = new StringBuilder("<button type=\"button\" ");
            sb.AppendFormat("id=\"{0}\" ", id);

            if (Enums.ButtonSize.Normal != size)
                sb.AppendFormat("class=\"btn btn-{0} btn-{1}\">", style.BootStrapStyle(), size.BootStrapSize());
            else
                sb.AppendFormat("class=\"btn btn-{0}\">", style.BootStrapStyle());
            sb.AppendFormat("{0}</button>", caption);

            return new MvcHtmlString(sb.ToString());
        }

        /// <summary>
        /// Create a boot strap button providing HTML id, caption bootstrap style using defaut size.
        /// </summary>
        /// <param name="id"> the button id. </param>
        /// <param name="caption"> the button caption. </param>
        /// <param name="style"> the button bootstrap style. </param>
        /// <returns> a HMTL encoded button tag. </returns>
        public static MvcHtmlString Button(string id, string caption, Enums.ButtonStyle style)
        {
            return Button(id, caption, style, Enums.ButtonSize.Normal);
        }
    }
}