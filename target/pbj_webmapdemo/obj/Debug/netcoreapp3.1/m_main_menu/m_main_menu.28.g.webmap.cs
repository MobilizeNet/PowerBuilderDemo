#pragma warning disable
#line 1 "m_main_menu\\m_main_menu.cs"
#line hidden
namespace pbj_webmapdemo
{
    public partial class m_main_menu
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[4];
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_controls) > 0)
            {
                yield return "m_controls";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_features) > 0)
            {
                yield return "m_features";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_medicalcenter) > 0)
            {
                yield return "m_medicalcenter";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_reports) > 0)
            {
                yield return "m_reports";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "m_controls":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_controls) > 0;
                case "m_features":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_features) > 0;
                case "m_medicalcenter":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_medicalcenter) > 0;
                case "m_reports":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_m_reports) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["m_controls"] = _Mobilize_References[0];
            refs["m_features"] = _Mobilize_References[1];
            refs["m_medicalcenter"] = _Mobilize_References[2];
            refs["m_reports"] = _Mobilize_References[3];
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

            var ref_m_controls = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_controls);
            if (ref_m_controls != null)
                yield return ref_m_controls;
            var ref_m_features = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_features);
            if (ref_m_features != null)
                yield return ref_m_features;
            var ref_m_medicalcenter = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_medicalcenter);
            if (ref_m_medicalcenter != null)
                yield return ref_m_medicalcenter;
            var ref_m_reports = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.m_reports);
            if (ref_m_reports != null)
                yield return ref_m_reports;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_m_controls = (uint)1 << 0;
        const uint _Mobilize_Loaded_m_controls = (uint)1 << 0;
        const uint _Mobilize_Dirty_m_features = (uint)1 << 1;
        const uint _Mobilize_Loaded_m_features = (uint)1 << 1;
        const uint _Mobilize_Dirty_m_medicalcenter = (uint)1 << 2;
        const uint _Mobilize_Loaded_m_medicalcenter = (uint)1 << 2;
        const uint _Mobilize_Dirty_m_reports = (uint)1 << 3;
        const uint _Mobilize_Loaded_m_reports = (uint)1 << 3;
#line 7
    }
}