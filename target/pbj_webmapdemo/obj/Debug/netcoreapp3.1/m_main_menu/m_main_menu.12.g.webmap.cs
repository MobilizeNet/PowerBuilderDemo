#pragma warning disable
#line 1 "m_main_menu\\m_main_menu.cs"
#line hidden
namespace pbj_webmapdemo
{
    public partial class m_main_menu : Mobilize.Web.Menu, pbj_webmapdemo.Im_main_menu
    {
        public partial class m_controls_type
        {
#line hidden
            [System.NonSerialized]
            private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[11];
            protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
            {
                foreach (var item in base._Mobilize_GetChanges())
                {
                    yield return item;
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_statictext) > 0)
                {
                    yield return "m_statictext";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_0) > 0)
                {
                    yield return "m_0";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_commandbutton) > 0)
                {
                    yield return "m_commandbutton";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_editmask) > 0)
                {
                    yield return "m_editmask";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_multilineedit) > 0)
                {
                    yield return "m_multilineedit";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_radiobutton) > 0)
                {
                    yield return "m_radiobutton";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_checkbox) > 0)
                {
                    yield return "m_checkbox";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_dropdownlistbox) > 0)
                {
                    yield return "m_dropdownlistbox";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_picture) > 0)
                {
                    yield return "m_picture";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_picturebutton) > 0)
                {
                    yield return "m_picturebutton";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_datamangercontrols) > 0)
                {
                    yield return "m_datamangercontrols";
                }

                yield break;
            }

            protected override bool _Mobilize_HasChanges(string propertyName)
            {
                switch (propertyName)
                {
                    case "m_statictext":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_statictext) > 0;
                    case "m_0":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_0) > 0;
                    case "m_commandbutton":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_commandbutton) > 0;
                    case "m_editmask":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_editmask) > 0;
                    case "m_multilineedit":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_multilineedit) > 0;
                    case "m_radiobutton":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_radiobutton) > 0;
                    case "m_checkbox":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_checkbox) > 0;
                    case "m_dropdownlistbox":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_dropdownlistbox) > 0;
                    case "m_picture":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_picture) > 0;
                    case "m_picturebutton":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_picturebutton) > 0;
                    case "m_datamangercontrols":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_datamangercontrols) > 0;
                }

                return base._Mobilize_HasChanges(propertyName);
            }

            protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
            {
                base._Mobilize_GetReferenceMap(refs);
                refs["m_statictext"] = _Mobilize_References[0];
                refs["m_0"] = _Mobilize_References[1];
                refs["m_commandbutton"] = _Mobilize_References[2];
                refs["m_editmask"] = _Mobilize_References[3];
                refs["m_multilineedit"] = _Mobilize_References[4];
                refs["m_radiobutton"] = _Mobilize_References[5];
                refs["m_checkbox"] = _Mobilize_References[6];
                refs["m_dropdownlistbox"] = _Mobilize_References[7];
                refs["m_picture"] = _Mobilize_References[8];
                refs["m_picturebutton"] = _Mobilize_References[9];
                refs["m_datamangercontrols"] = _Mobilize_References[10];
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

                var ref_m_statictext = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_statictext);
                if (ref_m_statictext != null)
                    yield return ref_m_statictext;
                var ref_m_0 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_0);
                if (ref_m_0 != null)
                    yield return ref_m_0;
                var ref_m_commandbutton = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_commandbutton);
                if (ref_m_commandbutton != null)
                    yield return ref_m_commandbutton;
                var ref_m_editmask = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_editmask);
                if (ref_m_editmask != null)
                    yield return ref_m_editmask;
                var ref_m_multilineedit = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_multilineedit);
                if (ref_m_multilineedit != null)
                    yield return ref_m_multilineedit;
                var ref_m_radiobutton = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_radiobutton);
                if (ref_m_radiobutton != null)
                    yield return ref_m_radiobutton;
                var ref_m_checkbox = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_checkbox);
                if (ref_m_checkbox != null)
                    yield return ref_m_checkbox;
                var ref_m_dropdownlistbox = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_dropdownlistbox);
                if (ref_m_dropdownlistbox != null)
                    yield return ref_m_dropdownlistbox;
                var ref_m_picture = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_picture);
                if (ref_m_picture != null)
                    yield return ref_m_picture;
                var ref_m_picturebutton = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_picturebutton);
                if (ref_m_picturebutton != null)
                    yield return ref_m_picturebutton;
                var ref_m_datamangercontrols = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_datamangercontrols);
                if (ref_m_datamangercontrols != null)
                    yield return ref_m_datamangercontrols;
                yield break;
            }

            private uint _Mobilize_DirtyFlag_0;
            private uint _Mobilize_LoadedFlag_0;
            const uint _Mobilize_Dirty_m_statictext = (uint)1 << 0;
            const uint _Mobilize_Loaded_m_statictext = (uint)1 << 0;
            const uint _Mobilize_Dirty_m_0 = (uint)1 << 1;
            const uint _Mobilize_Loaded_m_0 = (uint)1 << 1;
            const uint _Mobilize_Dirty_m_commandbutton = (uint)1 << 2;
            const uint _Mobilize_Loaded_m_commandbutton = (uint)1 << 2;
            const uint _Mobilize_Dirty_m_editmask = (uint)1 << 3;
            const uint _Mobilize_Loaded_m_editmask = (uint)1 << 3;
            const uint _Mobilize_Dirty_m_multilineedit = (uint)1 << 4;
            const uint _Mobilize_Loaded_m_multilineedit = (uint)1 << 4;
            const uint _Mobilize_Dirty_m_radiobutton = (uint)1 << 5;
            const uint _Mobilize_Loaded_m_radiobutton = (uint)1 << 5;
            const uint _Mobilize_Dirty_m_checkbox = (uint)1 << 6;
            const uint _Mobilize_Loaded_m_checkbox = (uint)1 << 6;
            const uint _Mobilize_Dirty_m_dropdownlistbox = (uint)1 << 7;
            const uint _Mobilize_Loaded_m_dropdownlistbox = (uint)1 << 7;
            const uint _Mobilize_Dirty_m_picture = (uint)1 << 8;
            const uint _Mobilize_Loaded_m_picture = (uint)1 << 8;
            const uint _Mobilize_Dirty_m_picturebutton = (uint)1 << 9;
            const uint _Mobilize_Loaded_m_picturebutton = (uint)1 << 9;
            const uint _Mobilize_Dirty_m_datamangercontrols = (uint)1 << 10;
            const uint _Mobilize_Loaded_m_datamangercontrols = (uint)1 << 10;
#line 58
        }
    }
}