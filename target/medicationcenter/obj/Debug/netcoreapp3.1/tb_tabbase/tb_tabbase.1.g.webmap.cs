#pragma warning disable
#line 1 "tb_tabbase\\tb_tabbase.cs"
#line hidden
namespace medicationcenter
{
    public partial class tb_tabbase : Mobilize.Web.Tab, medicationcenter.Itb_tabbase
    {
        public partial class tabpage_add_type
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

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dw_add) > 0)
                {
                    yield return "dw_add";
                }

                yield break;
            }

            protected override bool _Mobilize_HasChanges(string propertyName)
            {
                switch (propertyName)
                {
                    case "dw_add":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dw_add) > 0;
                }

                return base._Mobilize_HasChanges(propertyName);
            }

            protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
            {
                base._Mobilize_GetReferenceMap(refs);
                refs["dw_add"] = _Mobilize_References[0];
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

                var ref_dw_add = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.dw_add);
                if (ref_dw_add != null)
                    yield return ref_dw_add;
                yield break;
            }

            private uint _Mobilize_DirtyFlag_0;
            private uint _Mobilize_LoadedFlag_0;
            const uint _Mobilize_Dirty_dw_add = (uint)1 << 0;
            const uint _Mobilize_Loaded_dw_add = (uint)1 << 0;
#line 94
        }
    }
}