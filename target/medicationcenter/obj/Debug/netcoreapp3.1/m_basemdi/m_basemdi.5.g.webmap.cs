#pragma warning disable
#line 1 "m_basemdi\\m_basemdi.cs"
#line hidden
namespace medicationcenter
{
    public partial class m_basemdi : Mobilize.Web.Menu, medicationcenter.Im_basemdi
    {
        public partial class m_prescriptions_type
        {
#line hidden
            [System.NonSerialized]
            private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[5];
            protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
            {
                foreach (var item in base._Mobilize_GetChanges())
                {
                    yield return item;
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_addprescription) > 0)
                {
                    yield return "m_addprescription";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_showall) > 0)
                {
                    yield return "m_showall";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_search) > 0)
                {
                    yield return "m_search";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_removeprescription) > 0)
                {
                    yield return "m_removeprescription";
                }

                if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_dwcontrolsampler) > 0)
                {
                    yield return "m_dwcontrolsampler";
                }

                yield break;
            }

            protected override bool _Mobilize_HasChanges(string propertyName)
            {
                switch (propertyName)
                {
                    case "m_addprescription":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_addprescription) > 0;
                    case "m_showall":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_showall) > 0;
                    case "m_search":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_search) > 0;
                    case "m_removeprescription":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_removeprescription) > 0;
                    case "m_dwcontrolsampler":
                        return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_dwcontrolsampler) > 0;
                }

                return base._Mobilize_HasChanges(propertyName);
            }

            protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
            {
                base._Mobilize_GetReferenceMap(refs);
                refs["m_addprescription"] = _Mobilize_References[0];
                refs["m_showall"] = _Mobilize_References[1];
                refs["m_search"] = _Mobilize_References[2];
                refs["m_removeprescription"] = _Mobilize_References[3];
                refs["m_dwcontrolsampler"] = _Mobilize_References[4];
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

                var ref_m_addprescription = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_addprescription);
                if (ref_m_addprescription != null)
                    yield return ref_m_addprescription;
                var ref_m_showall = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_showall);
                if (ref_m_showall != null)
                    yield return ref_m_showall;
                var ref_m_search = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_search);
                if (ref_m_search != null)
                    yield return ref_m_search;
                var ref_m_removeprescription = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_removeprescription);
                if (ref_m_removeprescription != null)
                    yield return ref_m_removeprescription;
                var ref_m_dwcontrolsampler = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_dwcontrolsampler);
                if (ref_m_dwcontrolsampler != null)
                    yield return ref_m_dwcontrolsampler;
                yield break;
            }

            private uint _Mobilize_DirtyFlag_0;
            private uint _Mobilize_LoadedFlag_0;
            const uint _Mobilize_Dirty_m_addprescription = (uint)1 << 0;
            const uint _Mobilize_Loaded_m_addprescription = (uint)1 << 0;
            const uint _Mobilize_Dirty_m_showall = (uint)1 << 1;
            const uint _Mobilize_Loaded_m_showall = (uint)1 << 1;
            const uint _Mobilize_Dirty_m_search = (uint)1 << 2;
            const uint _Mobilize_Loaded_m_search = (uint)1 << 2;
            const uint _Mobilize_Dirty_m_removeprescription = (uint)1 << 3;
            const uint _Mobilize_Loaded_m_removeprescription = (uint)1 << 3;
            const uint _Mobilize_Dirty_m_dwcontrolsampler = (uint)1 << 4;
            const uint _Mobilize_Loaded_m_dwcontrolsampler = (uint)1 << 4;
#line 41
        }
    }
}