using System;
using DevExpress.Xpf.Docking;

namespace MinBody.ViewModels
{
   public class ViewModel:ViewModelBase, IMVVMDockingProperties
    {
        private string _displayName;

        public string DisplayName
        {
            get { return _displayName; }
            set { SetProperty(ref _displayName, value, "DisplayName"); }
        }
        protected virtual string GetTargetName()
        {
            return "panelHost";
        }
        #region IMVVMDockingProperties Members

        string IMVVMDockingProperties.TargetName
        {
            get { return GetTargetName(); }
            set { throw new NotImplementedException(); }
        }

        #endregion
    }
}
