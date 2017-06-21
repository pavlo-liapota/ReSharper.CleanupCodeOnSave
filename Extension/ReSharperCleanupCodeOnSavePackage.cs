using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using EnvDTE;
using Microsoft.VisualStudio.Shell;

namespace ReSharper.CleanupCodeOnSave.Extension
{
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    [Guid(ReSharperCleanupCodeOnSavePackage.PackageGuidString)]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly",
        Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
    public sealed class ReSharperCleanupCodeOnSavePackage : Package
    {
        public const string PackageGuidString = "f3461b28-c812-4da7-b6b4-1f0f7ac380ac";

        protected override void Initialize()
        {
            var dte = (DTE) GetService(typeof(DTE));
            var runningDocumentTable = new RunningDocumentTable(this);
            var onSaveEventHandler = new OnSaveEventHandler(runningDocumentTable, dte);
            var plugin = new VsRunningDocTableEventHandler(onSaveEventHandler);
            runningDocumentTable.Advise(plugin);

            base.Initialize();
        }
    }
}