#pragma warning disable
#line 1 "m_main_menu\\m_main_menu.cs"
#line hidden
namespace pbj_webmapdemo
{
    public partial class m_main_menu : Mobilize.Web.Menu, pbj_webmapdemo.Im_main_menu
    {
        public partial class m_controls_type : Mobilize.Web.Menu, Im_main_menuInner.Im_controls_type
        {
            public partial class m_datamangercontrols_type
            {
#line hidden
                [System.NonSerialized]
                private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[1];
                protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
                {
                    foreach (var item in base._Mobilize_GetChanges())
                    {
                        yield return item;
                    }

                    if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_dropdowndw) > 0)
                    {
                        yield return "m_dropdowndw";
                    }

                    yield break;
                }

                protected override bool _Mobilize_HasChanges(string propertyName)
                {
                    switch (propertyName)
                    {
                        case "m_dropdowndw":
                            return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_dropdowndw) > 0;
                    }

                    return base._Mobilize_HasChanges(propertyName);
                }

                protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
                {
                    base._Mobilize_GetReferenceMap(refs);
                    refs["m_dropdowndw"] = _Mobilize_References[0];
                    return refs;
                }

                protected override void _Mobilize_CleanChanges()
                {
                    if (!((Mobilize.WebMap.Common.Core.ITrackable)this).IsNew || ((Mobilize.WebMap.Common.Core.IObservable)this).RefCount > 0)
                    {
                        this._Mobilize_DirtyFlag_0 = 0;
                        this._Mobilize_LoadedFlag_0 = 0;
                        this._Mobilize_ControlFlag = 0;
                    }

                    base._Mobilize_CleanChanges();
                }

                protected override System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> _Mobilize_GetReferences()
                {
                    foreach (var baseRef in base._Mobilize_GetReferences())
                    {
                        yield return baseRef;
                    }

                    var ref_m_dropdowndw = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_dropdowndw);
                    if (ref_m_dropdowndw != null)
                        yield return ref_m_dropdowndw;
                    yield break;
                }

                private uint _Mobilize_DirtyFlag_0;
                private uint _Mobilize_LoadedFlag_0;
                const uint _Mobilize_Dirty_m_dropdowndw = (uint)1 << 0;
                const uint _Mobilize_Loaded_m_dropdowndw = (uint)1 << 0;
#line 538
            }
        }
    }
}