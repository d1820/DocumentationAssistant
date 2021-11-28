using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.Threading;

namespace DocumentationAssistant.Settings
{
    public class VsixOptions
    {
        /// <summary>
        ///   DocumentationAssistant.Vsix2022Package GUID string.
        /// </summary>
        public const string PackageGuidString = "035e2407-4313-4089-bde4-3b1200091825";

        public const string Version = "2.1";

    }

    public class BridgedOptions
    {
        private static BridgedOptions _options;

        public BridgedOptions(bool isEnabledForPublishMembersOnly, bool useNaturalLanguageForReturnNode)
        {
            IsEnabledForPublishMembersOnly = isEnabledForPublishMembersOnly;
            UseNaturalLanguageForReturnNode = useNaturalLanguageForReturnNode;
        }
        public bool IsEnabledForPublishMembersOnly { get; set; }

        public bool UseNaturalLanguageForReturnNode { get; set; }

        public static Func<BridgedOptions> RegisterOptionLoaderCallback {get;set;}

        public static BridgedOptions Options
        {
            get
            {
                return RegisterOptionLoaderCallback?.Invoke();
            }
            set
            {
                _options = value;
            }
        }
    }

   
}
