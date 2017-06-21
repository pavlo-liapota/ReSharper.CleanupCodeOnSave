using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace ReSharper.CleanupCodeOnSave
{
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    [Guid(ReSharperCleanupCodeOnSavePackage.PackageGuidString)]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly",
        Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
    public sealed class ReSharperCleanupCodeOnSavePackage : Package
    {
        public const string PackageGuidString = "f3461b28-c812-4da7-b6b4-1f0f7ac380ac";

        public ReSharperCleanupCodeOnSavePackage()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
        }
    }
}
