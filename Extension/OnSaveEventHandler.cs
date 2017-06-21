using System.Linq;
using EnvDTE;
using Microsoft.VisualStudio.Shell;

namespace ReSharper.CleanupCodeOnSave.Extension
{
    public class OnSaveEventHandler
    {
        private const string Command = "Resharper.Resharper_SilentCleanupCode";

        private RunningDocumentTable RunningDocumentTable { get; }

        private DTE Dte { get; }

        public OnSaveEventHandler(RunningDocumentTable runningDocumentTable, DTE dte)
        {
            RunningDocumentTable = runningDocumentTable;
            Dte = dte;
        }

        public void Execute(uint docCookie)
        {
            var document = FindDocument(docCookie);
            if (document == null) return;

            var currentDoc = Dte.ActiveDocument;

            if (currentDoc != document) document.Activate();

            if (Dte.ActiveWindow.Kind == "Document")
            {
                Dte.ExecuteCommand(Command, string.Empty);
            }

            if (currentDoc != document) currentDoc.Activate();
        }

        private Document FindDocument(uint docCookie)
        {
            var documentPath = RunningDocumentTable.GetDocumentInfo(docCookie).Moniker;
            return Dte.Documents.Cast<Document>().FirstOrDefault(doc => doc.FullName == documentPath);
        }
    }
}