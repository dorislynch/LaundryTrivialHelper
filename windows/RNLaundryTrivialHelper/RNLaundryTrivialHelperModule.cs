using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Laundry.Trivial.Helper.RNLaundryTrivialHelper
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNLaundryTrivialHelperModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNLaundryTrivialHelperModule"/>.
        /// </summary>
        internal RNLaundryTrivialHelperModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNLaundryTrivialHelper";
            }
        }
    }
}
