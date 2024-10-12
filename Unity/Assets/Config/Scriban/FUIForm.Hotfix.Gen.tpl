//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FairyGUI;

namespace ET.Client
{
    [EntitySystemOf(typeof({{ name }}))]
    [FriendOf(typeof({{ name }}))]
    public static partial class {{ name }}System
    {
		[EntitySystem]
        public static void Awake(this {{ name }} self)
        {
            FUI fui = self.GetParent<FUI>();
            GComponent contentPane = fui.ContentPane;

            #region [子节点]
{{ for node in nodes }} {{ if is_accept_name node.name }}
            self.{{ upper_first node.name }} = ({{ node.ref_type_full_name }})contentPane.GetChildAt({{ node.index }});
{{ end }} {{ end }}
            #endregion

            #region [控制器]
{{ for controller in controllers }} {{ if is_accept_name controller.name }}
            self.{{ upper_first controller.name }}Controller = contentPane.GetControllerAt({{ controller.index }});
{{ end }} {{ end }}
            #endregion

            #region [动效]
{{ for transition in transitions }} {{ if is_accept_name transition.name }}
            self.{{ upper_first transition.name }}Transition = contentPane.GetTransitionAt({{ transition.index }});
{{ end }} {{ end }}
            #endregion

            self.OnCreate(fui, contentPane);
        }

        [EntitySystem]
        public static void Destroy(this {{ name }} self)
        {
            self.OnDestroy();
        }
    }

    [FUIEvent(FUIViewId.{{ name }})]
    public partial class {{ name }}EventHandler : AFUIEventHandler<{{ name }}>
    {
        public override string UIAssetURL => {{ name }}.URL;

        protected override void OnOpen(FUI ui, {{ name }} component, object userData)
        {
            component.OnOpen(ui, userData);
        }

        protected override void OnClose(FUI ui, {{ name }} component)
        {
            component.OnClose(ui);
        }

        protected override void OnPause(FUI ui, {{ name }} component)
        {
            component.OnPause(ui);
        }

        protected override void OnResume(FUI ui, {{ name }} component)
        {
            component.OnResume(ui);
        }

        protected override void OnCover(FUI ui, {{ name }} component)
        {
            component.OnCover(ui);
        }

        protected override void OnReveal(FUI ui, {{ name }} component)
        {
            component.OnReveal(ui);
        }

        protected override void OnRefocus(FUI ui, {{ name }} component, object userData)
        {
            component.OnRefocus(ui, userData);
        }

        protected override void OnMaskLayerClicked(FUI ui, {{ name }} component)
        {
            component.OnMaskLayerClicked(ui);
        }
    }
}