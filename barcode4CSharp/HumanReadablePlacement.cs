using System;


namespace MKS.barcode4CS
{
    public class HumanReadablePlacement
    {
        /// <summary>
        /// The human-readable part is suppressed
        /// </summary>
        public static readonly HumanReadablePlacement HRP_NONE =
            new HumanReadablePlacement("none");
        /// <summary>
        /// The human-readable part is placed at the top of the barcode
        /// </summary>
        public static readonly HumanReadablePlacement HRP_TOP =
            new HumanReadablePlacement("top");
        /// <summary>
        /// The human-readable part is placed at the bottom of the barcode
        /// </summary>
        public static readonly HumanReadablePlacement HRP_BOTTOM =
            new HumanReadablePlacement("bottom");

        private String name;

        /// <summary>
        /// Creates a new HumanReadablePlacement instance.
        /// </summary>
        /// <param name="name">name the name for the instance</param>
        internal HumanReadablePlacement(String name)
        {
            this.name = name;
        }

        /// <returns>the name of the instance</returns>
        public String getName()
        {
            return this.name;
        }

        /// <summary>
        /// Returns a HumanReadablePlacement instance by name.
        /// </summary>
        /// <param name="name">the name of the instance</param>
        /// <returns>the requested instance</returns>
        public static HumanReadablePlacement byName(String name)
        {
            if (name.Equals(HumanReadablePlacement.HRP_NONE.getName(), StringComparison.CurrentCultureIgnoreCase))
            {
                return HumanReadablePlacement.HRP_NONE;
            }
            else if (name.Equals(HumanReadablePlacement.HRP_TOP.getName(), StringComparison.CurrentCultureIgnoreCase))
            {
                return HumanReadablePlacement.HRP_TOP;
            }
            else if (name.Equals(HumanReadablePlacement.HRP_BOTTOM.getName(), StringComparison.CurrentCultureIgnoreCase))
            {
                return HumanReadablePlacement.HRP_BOTTOM;
            }
            else
            {
                throw new ArgumentException("Invalid HumanReadablePlacement: " + name);
            }
        }
    }
}
