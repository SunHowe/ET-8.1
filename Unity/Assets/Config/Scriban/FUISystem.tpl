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
        public static void Awake(this {{ name }} self, GComponent contentPane)
        {
            #region [子节点]
{{ for node in nodes }} {{ if is_accept_name node.name }}
            self.{{ upper_first node.name }} = ({{ node.ref_type_full_name }})contentPane.GetChild("{{ node.name }}");
{{ end }} {{ end }}
            #endregion

            #region [控制器]
{{ for controller in controllers }} {{ if is_accept_name controller.name }}
            self.{{ upper_first controller.name }}Controller = contentPane.GetController("{{ controller.name }}");
{{ end }} {{ end }}
            #endregion

            #region [动效]
{{ for transition in transitions }} {{ if is_accept_name transition.name }}
            self.{{ upper_first transition.name }}Transition = contentPane.GetTransition("{{ transition.name }}");
{{ end }} {{ end }}
            #endregion
        }
    }
}