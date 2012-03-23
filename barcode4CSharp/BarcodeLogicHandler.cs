using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MKS.barcode4CS
{
    /// <summary>
    /// This is the basic interface for logic handlers. This interface usually gets 
    /// implemented by classes that want to render a barcode in a specific output
    /// format. Due to different barcode types (1D, 2D) there are different 
    /// descendants of this interface that define the specifics. See this 
    /// interface's descendants for more information.
    ///
    /// The purpose of this interface is to enable the separatation of barcode logic
    /// and painting/rendering logic.
    /// </summary>
    public interface BarcodeLogicHandler
    {
        /// <summary>
        /// This is always the first method call. It is called to inform the
        /// logic handler that a new barcode is about to be painted.
        /// </summary>
        /// <param name="msg">full message to be encoded</param>
        /// <param name="formattedMsg">message as it is to be presented to the 
        /// human-readable part</param>
        void startBarcode(String msg, String formattedMsg);

        /// <summary>
        /// This is always the last method called. It is called to inform the 
        /// logic handler that the generation of barcode logic has stopped.
        /// </summary>
        void endBarcode();

    }
}
