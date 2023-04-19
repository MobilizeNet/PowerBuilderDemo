#pragma warning disable
#line 1 "uo_okcancelretry\\uo_okcancelretry.cs"
#line hidden
namespace medicationcenter
{
    public partial class uo_okcancelretry
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[3];
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_retry) > 0)
            {
                yield return "cb_retry";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_cancel) > 0)
            {
                yield return "cb_cancel";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_ok) > 0)
            {
                yield return "cb_ok";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "cb_retry":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_retry) > 0;
                case "cb_cancel":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_cancel) > 0;
                case "cb_ok":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_ok) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["cb_retry"] = _Mobilize_References[0];
            refs["cb_cancel"] = _Mobilize_References[1];
            refs["cb_ok"] = _Mobilize_References[2];
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

            var ref_cb_retry = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_retry);
            if (ref_cb_retry != null)
                yield return ref_cb_retry;
            var ref_cb_cancel = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_cancel);
            if (ref_cb_cancel != null)
                yield return ref_cb_cancel;
            var ref_cb_ok = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_ok);
            if (ref_cb_ok != null)
                yield return ref_cb_ok;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_cb_retry = (uint)1 << 0;
        const uint _Mobilize_Loaded_cb_retry = (uint)1 << 0;
        const uint _Mobilize_Dirty_cb_cancel = (uint)1 << 1;
        const uint _Mobilize_Loaded_cb_cancel = (uint)1 << 1;
        const uint _Mobilize_Dirty_cb_ok = (uint)1 << 2;
        const uint _Mobilize_Loaded_cb_ok = (uint)1 << 2;
#line 7
    }
}