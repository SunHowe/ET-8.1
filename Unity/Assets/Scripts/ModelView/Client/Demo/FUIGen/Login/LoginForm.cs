﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FairyGUI;

namespace ET.Client
{
    [ComponentOf(typeof(FUI))]
    public partial class LoginForm : Entity, IAwake, IDestroy
    {
        public const string URL = "ui://gb2fsa1xdrq90";

        #region [子节点]
     
        public FairyGUI.GButton BtnLogin { get; set; }
    
        public FairyGUI.GTextInput InputAccount { get; set; }
  
        public FairyGUI.GTextInput InputPassword { get; set; }
  
        public ET.Client.Login.DemoComponent ComDemo { get; set; }
  
        public ET.Client.Login.SpecialButton BtnSpecial { get; set; }
 
        #endregion

        #region [控制器]

        #endregion

        #region [动效]

        #endregion
        
        /// <summary>
        /// 界面持有的CancellationToken 它会在界面被关闭时设置为取消
        /// </summary>
        public ETCancellationToken CancellationToken => this.GetParent<FUI>()?.CancellationToken;
    }
}