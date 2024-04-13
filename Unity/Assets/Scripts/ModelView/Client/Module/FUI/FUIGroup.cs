﻿using System.Collections.Generic;
using FairyGUI;

namespace ET.Client
{
    /// <summary>
    /// FUI组 用于管理同组的FUI
    /// </summary>
    [ChildOf(typeof(FUIComponent))]
    public sealed class FUIGroup : Entity, IAwake<FUIGroupId>
    {
        public GComponent ContentPane { get; set; }
        public FUIGroupId GroupId { get; set; }
        public LinkedList<FUIInfo> UIs = new();
        public LinkedListNode<FUIInfo> CacheNode;
    }

    [EnableClass]
    public sealed class FUIInfo : IPool
    {
        public bool IsFromPool { get; set; }
        
        public EntityRef<FUI> UI { get; set; }
        public bool Paused { get; set; }
        public bool Covered { get; set; }
    }
}