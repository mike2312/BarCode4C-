using System;


namespace MKS.barcode4CS
{
    /// <summary>
    /// Enumeration for the alignment of bars when the heights are not uniform
    /// </summary>
    /// <exception cref="System.ArgumentException">Thrown when an invalid BaselineAlignment Enumeration.</exception>
    public class BaselineAlignment
    {
        public static readonly BaselineAlignment ALIGN_TOP = new BaselineAlignment("top");
        public static readonly BaselineAlignment ALIGN_BOTTOM = new BaselineAlignment("bottom");

        private String name;

        /// <summary>
        /// Creates a new BaselineAlignment instance
        /// </summary>
        /// <param name="name">the name for the instance</param>
        protected BaselineAlignment(String name)
        {
            this.name = name;
        }

        /// <returns>the name of the instance</returns>
        public String getName()
        {
            return this.name;
        }

        public static BaselineAlignment byName(String name)
        {
            if (name.Equals(BaselineAlignment.ALIGN_TOP.getName(), StringComparison.CurrentCultureIgnoreCase))
            {
                return BaselineAlignment.ALIGN_TOP;
            }
            else if (name.Equals(BaselineAlignment.ALIGN_BOTTOM.getName(), StringComparison.CurrentCultureIgnoreCase))
            {
                return BaselineAlignment.ALIGN_BOTTOM;
            }
            else
            {
                throw new ArgumentException(
                    "Invalid BaselineAlignment: " + name);
            }
        }
    }
}
