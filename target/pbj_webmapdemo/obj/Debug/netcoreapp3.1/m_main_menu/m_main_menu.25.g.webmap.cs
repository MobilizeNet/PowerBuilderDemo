#pragma warning disable
#line 1 "m_main_menu\\m_main_menu.cs"
#line hidden
namespace pbj_webmapdemo
{
    public partial class m_main_menu : Mobilize.Web.Menu, pbj_webmapdemo.Im_main_menu
    {
        public partial class m_features_type
        {
#line hidden
            [System.NonSerialized]
            private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[12];
            protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
            {
                foreach (var item in base._Mobilize_GetChanges())
                {
                    yield return item;
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_datawindowcrud) > 0)
                {
                    yield return "m_datawindowcrud";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_datamanagereventonsinglerow) > 0)
                {
                    yield return "m_datamanagereventonsinglerow";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_alldatamanagercontrolinteractions) > 0)
                {
                    yield return "m_alldatamanagercontrolinteractions";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_1) > 0)
                {
                    yield return "m_1";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_2) > 0)
                {
                    yield return "m_2";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_3) > 0)
                {
                    yield return "m_3";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_4) > 0)
                {
                    yield return "m_4";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_datamanagerstate_nodata) > 0)
                {
                    yield return "m_datamanagerstate_nodata";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_datamanagerw_window) > 0)
                {
                    yield return "m_datamanagerw_window";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_datamanagerw_shared) > 0)
                {
                    yield return "m_datamanagerw_shared";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_datamanagerw_dropdown) > 0)
                {
                    yield return "m_datamanagerw_dropdown";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_datamanagerw_expression) > 0)
                {
                    yield return "m_datamanagerw_expression";
                }

                yield break;
            }

            protected override bool _Mobilize_HasChanges(string propertyName)
            {
                switch (propertyName)
                {
                    case "m_datawindowcrud":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_datawindowcrud) > 0;
                    case "m_datamanagereventonsinglerow":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_datamanagereventonsinglerow) > 0;
                    case "m_alldatamanagercontrolinteractions":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_alldatamanagercontrolinteractions) > 0;
                    case "m_1":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_1) > 0;
                    case "m_2":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_2) > 0;
                    case "m_3":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_3) > 0;
                    case "m_4":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_4) > 0;
                    case "m_datamanagerstate_nodata":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_datamanagerstate_nodata) > 0;
                    case "m_datamanagerw_window":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_datamanagerw_window) > 0;
                    case "m_datamanagerw_shared":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_datamanagerw_shared) > 0;
                    case "m_datamanagerw_dropdown":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_datamanagerw_dropdown) > 0;
                    case "m_datamanagerw_expression":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_datamanagerw_expression) > 0;
                }

                return base._Mobilize_HasChanges(propertyName);
            }

            protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
            {
                base._Mobilize_GetReferenceMap(refs);
                refs["m_datawindowcrud"] = _Mobilize_References[0];
                refs["m_datamanagereventonsinglerow"] = _Mobilize_References[1];
                refs["m_alldatamanagercontrolinteractions"] = _Mobilize_References[2];
                refs["m_1"] = _Mobilize_References[3];
                refs["m_2"] = _Mobilize_References[4];
                refs["m_3"] = _Mobilize_References[5];
                refs["m_4"] = _Mobilize_References[6];
                refs["m_datamanagerstate_nodata"] = _Mobilize_References[7];
                refs["m_datamanagerw_window"] = _Mobilize_References[8];
                refs["m_datamanagerw_shared"] = _Mobilize_References[9];
                refs["m_datamanagerw_dropdown"] = _Mobilize_References[10];
                refs["m_datamanagerw_expression"] = _Mobilize_References[11];
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

                var ref_m_datawindowcrud = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_datawindowcrud);
                if (ref_m_datawindowcrud != null)
                    yield return ref_m_datawindowcrud;
                var ref_m_datamanagereventonsinglerow = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_datamanagereventonsinglerow);
                if (ref_m_datamanagereventonsinglerow != null)
                    yield return ref_m_datamanagereventonsinglerow;
                var ref_m_alldatamanagercontrolinteractions = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_alldatamanagercontrolinteractions);
                if (ref_m_alldatamanagercontrolinteractions != null)
                    yield return ref_m_alldatamanagercontrolinteractions;
                var ref_m_1 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_1);
                if (ref_m_1 != null)
                    yield return ref_m_1;
                var ref_m_2 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_2);
                if (ref_m_2 != null)
                    yield return ref_m_2;
                var ref_m_3 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_3);
                if (ref_m_3 != null)
                    yield return ref_m_3;
                var ref_m_4 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_4);
                if (ref_m_4 != null)
                    yield return ref_m_4;
                var ref_m_datamanagerstate_nodata = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_datamanagerstate_nodata);
                if (ref_m_datamanagerstate_nodata != null)
                    yield return ref_m_datamanagerstate_nodata;
                var ref_m_datamanagerw_window = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_datamanagerw_window);
                if (ref_m_datamanagerw_window != null)
                    yield return ref_m_datamanagerw_window;
                var ref_m_datamanagerw_shared = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_datamanagerw_shared);
                if (ref_m_datamanagerw_shared != null)
                    yield return ref_m_datamanagerw_shared;
                var ref_m_datamanagerw_dropdown = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_datamanagerw_dropdown);
                if (ref_m_datamanagerw_dropdown != null)
                    yield return ref_m_datamanagerw_dropdown;
                var ref_m_datamanagerw_expression = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_datamanagerw_expression);
                if (ref_m_datamanagerw_expression != null)
                    yield return ref_m_datamanagerw_expression;
                yield break;
            }

            private uint _Mobilize_DirtyFlag_0;
            private uint _Mobilize_LoadedFlag_0;
            const uint _Mobilize_Dirty_m_datawindowcrud = (uint)1 << 0;
            const uint _Mobilize_Loaded_m_datawindowcrud = (uint)1 << 0;
            const uint _Mobilize_Dirty_m_datamanagereventonsinglerow = (uint)1 << 1;
            const uint _Mobilize_Loaded_m_datamanagereventonsinglerow = (uint)1 << 1;
            const uint _Mobilize_Dirty_m_alldatamanagercontrolinteractions = (uint)1 << 2;
            const uint _Mobilize_Loaded_m_alldatamanagercontrolinteractions = (uint)1 << 2;
            const uint _Mobilize_Dirty_m_1 = (uint)1 << 3;
            const uint _Mobilize_Loaded_m_1 = (uint)1 << 3;
            const uint _Mobilize_Dirty_m_2 = (uint)1 << 4;
            const uint _Mobilize_Loaded_m_2 = (uint)1 << 4;
            const uint _Mobilize_Dirty_m_3 = (uint)1 << 5;
            const uint _Mobilize_Loaded_m_3 = (uint)1 << 5;
            const uint _Mobilize_Dirty_m_4 = (uint)1 << 6;
            const uint _Mobilize_Loaded_m_4 = (uint)1 << 6;
            const uint _Mobilize_Dirty_m_datamanagerstate_nodata = (uint)1 << 7;
            const uint _Mobilize_Loaded_m_datamanagerstate_nodata = (uint)1 << 7;
            const uint _Mobilize_Dirty_m_datamanagerw_window = (uint)1 << 8;
            const uint _Mobilize_Loaded_m_datamanagerw_window = (uint)1 << 8;
            const uint _Mobilize_Dirty_m_datamanagerw_shared = (uint)1 << 9;
            const uint _Mobilize_Loaded_m_datamanagerw_shared = (uint)1 << 9;
            const uint _Mobilize_Dirty_m_datamanagerw_dropdown = (uint)1 << 10;
            const uint _Mobilize_Loaded_m_datamanagerw_dropdown = (uint)1 << 10;
            const uint _Mobilize_Dirty_m_datamanagerw_expression = (uint)1 << 11;
            const uint _Mobilize_Loaded_m_datamanagerw_expression = (uint)1 << 11;
#line 606
        }
    }
}