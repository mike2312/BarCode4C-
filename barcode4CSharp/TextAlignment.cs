using System;

namespace MKS.barcode4CS
{
    public class TextAlignment
    {
        /// <summary>
        /// The human-readable part is left-aligned.
        /// </summary>
        public static readonly TextAlignment TA_LEFT = new TextAlignment("left");
        /// <summary>
        /// the human-readable part is centered.
        /// </summary>
        public static readonly TextAlignment TA_CENTER = new TextAlignment("center");
        /// <summary>
        /// the human-readable part is right-aligned.
        /// </summary>
        public static readonly TextAlignment TA_RIGHT = new TextAlignment("right");
        /// <summary>
        /// the human-readable part is justified.
        /// </summary>
        public static readonly TextAlignment TA_JUSTIFY = new TextAlignment("justify");

        private String name;

        /// <summary>
        /// Creates a new TextAlignment instance.
        /// </summary>
        /// <param name="name">the name for the instance</param>
        internal TextAlignment(String name)
        {
            this.name = name;
        }

        /// <returns>the name of the instance</returns>
        public String getName()
        {
            return this.name;
        }

        public static TextAlignment byName(String name)
        {
            if (name.Equals(TextAlignment.TA_LEFT.getName(), StringComparison.CurrentCultureIgnoreCase))
            {
                return TextAlignment.TA_LEFT;
            }
            else if (name.Equals(TextAlignment.TA_CENTER.getName(), StringComparison.CurrentCultureIgnoreCase))
            {
                return TextAlignment.TA_CENTER;
            }
            else if (name.Equals(TextAlignment.TA_RIGHT.getName(), StringComparison.CurrentCultureIgnoreCase))
            {
                return TextAlignment.TA_RIGHT;
            }
            else if (name.Equals(TextAlignment.TA_JUSTIFY.getName(), StringComparison.CurrentCultureIgnoreCase))
            {
                return TextAlignment.TA_JUSTIFY;
            }
            else
            {
                throw new ArgumentException(
                    "Invalid TextAlignment: " + name);
            }
        }

    }
}
