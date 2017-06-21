using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;

namespace ReSharper.CleanupCodeOnSave.Extension
{
    public class VsRunningDocTableEventHandler : IVsRunningDocTableEvents3
    {
        private OnSaveEventHandler OnSaveEventHandler { get; }

        public VsRunningDocTableEventHandler(OnSaveEventHandler onSaveEventHandler)
        {
            OnSaveEventHandler = onSaveEventHandler;
        }

        public int OnBeforeSave(uint docCookie)
        {
            OnSaveEventHandler.Execute(docCookie);
            return VSConstants.S_OK;
        }
 
        int IVsRunningDocTableEvents.OnAfterFirstDocumentLock(uint docCookie, uint dwRDTLockType,
            uint dwReadLocksRemaining, uint dwEditLocksRemaining)
        {
            return VSConstants.S_OK;
        }

        int IVsRunningDocTableEvents.OnBeforeLastDocumentUnlock(uint docCookie, uint dwRDTLockType,
            uint dwReadLocksRemaining,
            uint dwEditLocksRemaining)
        {
            return VSConstants.S_OK;
        }

        int IVsRunningDocTableEvents.OnAfterSave(uint docCookie)
        {
            return VSConstants.S_OK;
        }

        int IVsRunningDocTableEvents.OnAfterAttributeChange(uint docCookie, uint grfAttribs)
        {
            return VSConstants.S_OK;
        }

        int IVsRunningDocTableEvents.OnBeforeDocumentWindowShow(uint docCookie, int fFirstShow, IVsWindowFrame pFrame)
        {
            return VSConstants.S_OK;
        }

        int IVsRunningDocTableEvents.OnAfterDocumentWindowHide(uint docCookie, IVsWindowFrame pFrame)
        {
            return VSConstants.S_OK;
        }

        int IVsRunningDocTableEvents2.OnAfterFirstDocumentLock(uint docCookie, uint dwRDTLockType,
            uint dwReadLocksRemaining, uint dwEditLocksRemaining)
        {
            return VSConstants.S_OK;
        }

        int IVsRunningDocTableEvents2.OnBeforeLastDocumentUnlock(uint docCookie, uint dwRDTLockType,
            uint dwReadLocksRemaining,
            uint dwEditLocksRemaining)
        {
            return VSConstants.S_OK;
        }

        int IVsRunningDocTableEvents2.OnAfterSave(uint docCookie)
        {
            return VSConstants.S_OK;
        }

        int IVsRunningDocTableEvents2.OnAfterAttributeChange(uint docCookie, uint grfAttribs)
        {
            return VSConstants.S_OK;
        }

        int IVsRunningDocTableEvents2.OnBeforeDocumentWindowShow(uint docCookie, int fFirstShow, IVsWindowFrame pFrame)
        {
            return VSConstants.S_OK;
        }

        int IVsRunningDocTableEvents2.OnAfterDocumentWindowHide(uint docCookie, IVsWindowFrame pFrame)
        {
            return VSConstants.S_OK;
        }

        int IVsRunningDocTableEvents2.OnAfterAttributeChangeEx(uint docCookie, uint grfAttribs, IVsHierarchy pHierOld,
            uint itemidOld,
            string pszMkDocumentOld, IVsHierarchy pHierNew, uint itemidNew, string pszMkDocumentNew)
        {
            return VSConstants.S_OK;
        }

        int IVsRunningDocTableEvents3.OnAfterFirstDocumentLock(uint docCookie, uint dwRDTLockType,
            uint dwReadLocksRemaining, uint dwEditLocksRemaining)
        {
            return VSConstants.S_OK;
        }

        int IVsRunningDocTableEvents3.OnBeforeLastDocumentUnlock(uint docCookie, uint dwRDTLockType,
            uint dwReadLocksRemaining,
            uint dwEditLocksRemaining)
        {
            return VSConstants.S_OK;
        }

        int IVsRunningDocTableEvents3.OnAfterSave(uint docCookie)
        {
            return VSConstants.S_OK;
        }

        int IVsRunningDocTableEvents3.OnAfterAttributeChange(uint docCookie, uint grfAttribs)
        {
            return VSConstants.S_OK;
        }

        int IVsRunningDocTableEvents3.OnBeforeDocumentWindowShow(uint docCookie, int fFirstShow, IVsWindowFrame pFrame)
        {
            return VSConstants.S_OK;
        }

        int IVsRunningDocTableEvents3.OnAfterDocumentWindowHide(uint docCookie, IVsWindowFrame pFrame)
        {
            return VSConstants.S_OK;
        }

        int IVsRunningDocTableEvents3.OnAfterAttributeChangeEx(uint docCookie, uint grfAttribs, IVsHierarchy pHierOld,
            uint itemidOld,
            string pszMkDocumentOld, IVsHierarchy pHierNew, uint itemidNew, string pszMkDocumentNew)
        {
            return VSConstants.S_OK;
        }
    }
}