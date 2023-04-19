#pragma warning disable
#line 1 "w_dw_control_sampler_events\\w_dw_control_sampler_events.cs"
#line hidden
namespace multicontroldemo
{
    public partial class w_dw_control_sampler_events
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

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_3) > 0)
            {
                yield return "cb_3";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_2) > 0)
            {
                yield return "cb_2";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_1) > 0)
            {
                yield return "cb_1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_mle_log) > 0)
            {
                yield return "mle_log";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dw_1) > 0)
            {
                yield return "dw_1";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "cb_3":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_3) > 0;
                case "cb_2":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_2) > 0;
                case "cb_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_1) > 0;
                case "mle_log":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_mle_log) > 0;
                case "dw_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dw_1) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["cb_3"] = _Mobilize_References[0];
            refs["cb_2"] = _Mobilize_References[1];
            refs["cb_1"] = _Mobilize_References[2];
            refs["mle_log"] = _Mobilize_References[3];
            refs["dw_1"] = _Mobilize_References[4];
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

            var ref_cb_3 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_3);
            if (ref_cb_3 != null)
                yield return ref_cb_3;
            var ref_cb_2 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_2);
            if (ref_cb_2 != null)
                yield return ref_cb_2;
            var ref_cb_1 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_1);
            if (ref_cb_1 != null)
                yield return ref_cb_1;
            var ref_mle_log = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.mle_log);
            if (ref_mle_log != null)
                yield return ref_mle_log;
            var ref_dw_1 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.dw_1);
            if (ref_dw_1 != null)
                yield return ref_dw_1;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_cb_3 = (uint)1 << 0;
        const uint _Mobilize_Loaded_cb_3 = (uint)1 << 0;
        const uint _Mobilize_Dirty_cb_2 = (uint)1 << 1;
        const uint _Mobilize_Loaded_cb_2 = (uint)1 << 1;
        const uint _Mobilize_Dirty_cb_1 = (uint)1 << 2;
        const uint _Mobilize_Loaded_cb_1 = (uint)1 << 2;
        const uint _Mobilize_Dirty_mle_log = (uint)1 << 3;
        const uint _Mobilize_Loaded_mle_log = (uint)1 << 3;
        const uint _Mobilize_Dirty_dw_1 = (uint)1 << 4;
        const uint _Mobilize_Loaded_dw_1 = (uint)1 << 4;
#line 7
    }
}