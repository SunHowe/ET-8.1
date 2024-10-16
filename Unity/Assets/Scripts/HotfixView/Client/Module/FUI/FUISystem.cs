using FairyGUI;

namespace ET.Client
{
    [EntitySystemOf(typeof(FUI))]
    [FriendOf(typeof(FUI))]
    public static partial class FUISystem
    {
        [EntitySystem]
        private static void Awake(this FUI self, FUIViewId viewId, FUIForm contentPane, IFUIEventHandler eventHandler)
        {
            contentPane.EntityRef = self;
            
            self.ViewId = viewId;
            self.ContentPane = contentPane;
            self.EventHandler = eventHandler;
            self.AddComponent(eventHandler.ComponentType);
            self.AddComponent<ResourcesLoaderComponent>(); // 组件的加载器
        }

        [EntitySystem]
        private static void Destroy(this FUI self)
        {
            self.ContentPane.Dispose();
        }

        /// <summary>
        /// 关闭当前界面
        /// </summary>
        public static void CloseForm(this FUI self)
        {
            self.Root().CloseUI(self.ViewId).Coroutine();
        }

        /// <summary>
        /// 设置深度
        /// </summary>
        public static void SetDepth(this FUI self, int depth)
        {
            self.Depth = depth;
            self.ContentPane.sortingOrder = (self.Depth << 1) + 1;
        }

        /// <summary>
        /// 界面打开时调用
        /// </summary>
        public static void OnOpen(this FUI self, object userData)
        {
            self.EventHandler.OnOpen(self, userData);
        }

        /// <summary>
        /// 界面关闭时调用
        /// </summary>
        public static void OnClose(this FUI self)
        {
            self.EventHandler.OnClose(self);
        }

        /// <summary>
        /// 界面暂停
        /// </summary>
        public static void OnPause(this FUI self)
        {
            self.EventHandler.OnPause(self);
        }

        /// <summary>
        /// 界面恢复
        /// </summary>
        public static void OnResume(this FUI self)
        {
            self.EventHandler.OnResume(self);
        }

        /// <summary>
        /// 界面遮挡
        /// </summary>
        public static void OnCover(this FUI self)
        {
            self.EventHandler.OnCover(self);
        }

        /// <summary>
        /// 界面遮挡恢复
        /// </summary>
        public static void OnReveal(this FUI self)
        {
            self.EventHandler.OnReveal(self);
        }

        /// <summary>
        /// 界面激活
        /// </summary>
        public static void OnRefocus(this FUI self, object userdata)
        {
            self.EventHandler.OnRefocus(self, userdata);
        }

        /// <summary>
        /// 界面所属的遮罩层被点击
        /// </summary>
        public static void OnMaskLayerClicked(this FUI self)
        {
            self.EventHandler.OnMaskLayerClicked(self);
        }
    }
}