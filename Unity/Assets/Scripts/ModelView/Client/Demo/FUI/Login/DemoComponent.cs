﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Threading;

namespace ET.Client.Login
{
    [FUICustomComponentAttribute(URL)]
    public partial class DemoComponent : FairyGUI.GComponent
    {
        public const string URL = "ui://gb2fsa1xun9b2";

        #region [子节点]
   
        public FairyGUI.GTextField TxtLabel1;
  
        public FairyGUI.GTextField TxtLabel2;
 
        #endregion

        #region [控制器]

        #endregion

        #region [动效]

        #endregion
        
        public override void ConstructFromXML(FairyGUI.Utils.XML xml)
        {
            base.ConstructFromXML(xml);

            #region [子节点]
   
            TxtLabel1 = (FairyGUI.GTextField)GetChild("txtLabel1");
  
            TxtLabel2 = (FairyGUI.GTextField)GetChild("txtLabel2");
 
            #endregion

            #region [控制器]

            #endregion

            #region [动效]

            #endregion
        }
    }
}