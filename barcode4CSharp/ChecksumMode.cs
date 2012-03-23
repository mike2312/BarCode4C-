using System;


namespace MKS.barcode4CS
{
    /// <summary>
    /// Enumeration type for checksum policy.
    /// </summary>
    /// <exception cref="System.ArgumentException">Thrown on Invalid checksum values</exception>
    public class ChecksumMode
    {
        /// <summary>
        /// "auto" chooses the barcode's default checksum behaviour
        /// </summary>
        public static readonly ChecksumMode CP_AUTO = new ChecksumMode("auto");
        /// <summary>
        /// "ignore" doesn't check nor add a checksum
        /// </summary>
        public static readonly ChecksumMode CP_IGNORE = new ChecksumMode("ignore");
        /// <summary>
        /// "add" adds the necessary checksum to the message to be encoded
        /// </summary>
        public static readonly ChecksumMode CP_ADD = new ChecksumMode("add");
        /// <summary>
        /// "check" requires the check character to be present in the message. It will be checked.
        /// </summary>
        public static readonly ChecksumMode CP_CHECK = new ChecksumMode("check");

        private String name;


        /// <summary>
        /// Creates a new ChecksumMode instance.
        /// </summary>
        /// <param name="name">the name of the ChecksumMode</param>
        protected ChecksumMode(String name)
        {
            this.name = name;
        }

        /// <returns>The name of the isntance</returns>
        public String getName()
        {
            return this.name;
        }

        /// <summary>
        /// Returns a ChecksumMode instance by name.
        /// </summary>
        /// <param name="name">the name of the ChecksumMode</param>
        /// <returns>the requested instance</returns>
        public static ChecksumMode byName(String name)
        {
            if (name.Equals(ChecksumMode.CP_AUTO.getName(), StringComparison.CurrentCultureIgnoreCase))
            {
                return ChecksumMode.CP_AUTO;
            }
            else if (name.Equals(ChecksumMode.CP_IGNORE.getName(), StringComparison.CurrentCultureIgnoreCase))
            {
                return ChecksumMode.CP_IGNORE;
            }
            else if (name.Equals(ChecksumMode.CP_ADD.getName(), StringComparison.CurrentCultureIgnoreCase))
            {
                return ChecksumMode.CP_ADD;
            }
            else if (name.Equals(ChecksumMode.CP_CHECK.getName(), StringComparison.CurrentCultureIgnoreCase))
            {
                return ChecksumMode.CP_CHECK;
            }
            else
            {
                throw new ArgumentException("Invalid ChecksumMode: " + name);
            }
        }

    }

}
