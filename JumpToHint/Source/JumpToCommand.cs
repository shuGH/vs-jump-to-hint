using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.TextManager.Interop;

namespace JumpToHint
{
    /// <summary>
    /// Command handler
    /// </summary>
    internal class JumpToCommand
    {
        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        protected readonly AsyncPackage package;

        /// <summary>
        /// Gets the service provider from the owner package.
        /// </summary>
        private Microsoft.VisualStudio.Shell.IAsyncServiceProvider ServiceProvider
        {
            get
            {
                return this.package;
            }
        }

        protected JumpToCommand(AsyncPackage package)
        {
            this.package = package ?? throw new ArgumentNullException(nameof(package));
        }


        public virtual void ShowHints(HintMode mode)
        {
            //_mode = mode;

            // @TODO: テスト
            //switch (_mode)
            //{
            //    case HintMode.Word:
            //        System.Diagnostics.Debug.WriteLine("Hint: Word.");
            //        break;
            //    case HintMode.Line:
            //        System.Diagnostics.Debug.WriteLine("Hint: Line.");
            //        break;
            //}
        }

        public virtual void ReceiveInput(char target)
        {
        }

        public virtual void Cancel()
        {
        }

        protected HintProperty GetOrCreateHintProperty(IWpfTextView textView)
        {
            return textView.Properties.GetOrCreateSingletonProperty(JumpToHintPackage.PackageGuidString, () => new HintProperty(textView));
        }
    }
}
