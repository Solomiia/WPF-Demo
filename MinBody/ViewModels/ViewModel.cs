using System;
using DevExpress.Xpf.Docking;
using MinBody.ViewModels.Base;

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

        private string _image;

        public string Image
        {
            get { return _image; }
            set { SetProperty(ref _image, value, "Image"); }
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
