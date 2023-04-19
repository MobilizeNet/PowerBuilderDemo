#pragma warning disable
#line 1 "m_basemdi\\m_basemdi.cs"
#line hidden
namespace medicationcenter
{
    public partial class m_basemdi : Mobilize.Web.Menu, medicationcenter.Im_basemdi
    {
        public partial class m_edit_type
        {
#line hidden
            [System.NonSerialized]
            private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[2];
            protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
            {
                foreach (var item in base._Mobilize_GetChanges())
                {
                    yield return item;
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_save) > 0)
                {
                    yield return "m_save";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_close) > 0)
                {
                    yield return "m_close";
                }

                yield break;
            }

            protected override bool _Mobilize_HasChanges(string propertyName)
            {
                switch (propertyName)
                {
                    case "m_save":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_save) > 0;
                    case "m_close":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_close) > 0;
                }

                return base._Mobilize_HasChanges(propertyName);
            }

            protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
            {
                base._Mobilize_GetReferenceMap(refs);
                refs["m_save"] = _Mobilize_References[0];
                refs["m_close"] = _Mobilize_References[1];
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

                var ref_m_save = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_save);
                if (ref_m_save != null)
                    yield return ref_m_save;
                var ref_m_close = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_close);
                if (ref_m_close != null)
                    yield return ref_m_close;
                yield break;
            }

            private uint _Mobilize_DirtyFlag_0;
            private uint _Mobilize_LoadedFlag_0;
            const uint _Mobilize_Dirty_m_save = (uint)1 << 0;
            const uint _Mobilize_Loaded_m_save = (uint)1 << 0;
            const uint _Mobilize_Dirty_m_close = (uint)1 << 1;
            const uint _Mobilize_Loaded_m_close = (uint)1 << 1;
#line 277
        }
    }
}