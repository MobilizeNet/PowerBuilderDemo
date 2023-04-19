#pragma warning disable
#line 1 "w_shareddatawindow\\w_shareddatawindow.cs"
#line hidden
namespace notifycurrentcontrol
{
    public partial class w_shareddatawindow
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[8];
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_st_3) > 0)
            {
                yield return "st_3";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_st_2) > 0)
            {
                yield return "st_2";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_st_1) > 0)
            {
                yield return "st_1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_2) > 0)
            {
                yield return "cb_2";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_1) > 0)
            {
                yield return "cb_1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dw_3) > 0)
            {
                yield return "dw_3";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dw_2) > 0)
            {
                yield return "dw_2";
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
                case "st_3":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_st_3) > 0;
                case "st_2":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_st_2) > 0;
                case "st_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_st_1) > 0;
                case "cb_2":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_2) > 0;
                case "cb_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_1) > 0;
                case "dw_3":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dw_3) > 0;
                case "dw_2":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dw_2) > 0;
                case "dw_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dw_1) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["st_3"] = _Mobilize_References[0];
            refs["st_2"] = _Mobilize_References[1];
            refs["st_1"] = _Mobilize_References[2];
            refs["cb_2"] = _Mobilize_References[3];
            refs["cb_1"] = _Mobilize_References[4];
            refs["dw_3"] = _Mobilize_References[5];
            refs["dw_2"] = _Mobilize_References[6];
            refs["dw_1"] = _Mobilize_References[7];
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

            var ref_st_3 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.st_3);
            if (ref_st_3 != null)
                yield return ref_st_3;
            var ref_st_2 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.st_2);
            if (ref_st_2 != null)
                yield return ref_st_2;
            var ref_st_1 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.st_1);
            if (ref_st_1 != null)
                yield return ref_st_1;
            var ref_cb_2 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_2);
            if (ref_cb_2 != null)
                yield return ref_cb_2;
            var ref_cb_1 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_1);
            if (ref_cb_1 != null)
                yield return ref_cb_1;
            var ref_dw_3 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.dw_3);
            if (ref_dw_3 != null)
                yield return ref_dw_3;
            var ref_dw_2 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.dw_2);
            if (ref_dw_2 != null)
                yield return ref_dw_2;
            var ref_dw_1 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.dw_1);
            if (ref_dw_1 != null)
                yield return ref_dw_1;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_st_3 = (uint)1 << 0;
        const uint _Mobilize_Loaded_st_3 = (uint)1 << 0;
        const uint _Mobilize_Dirty_st_2 = (uint)1 << 1;
        const uint _Mobilize_Loaded_st_2 = (uint)1 << 1;
        const uint _Mobilize_Dirty_st_1 = (uint)1 << 2;
        const uint _Mobilize_Loaded_st_1 = (uint)1 << 2;
        const uint _Mobilize_Dirty_cb_2 = (uint)1 << 3;
        const uint _Mobilize_Loaded_cb_2 = (uint)1 << 3;
        const uint _Mobilize_Dirty_cb_1 = (uint)1 << 4;
        const uint _Mobilize_Loaded_cb_1 = (uint)1 << 4;
        const uint _Mobilize_Dirty_dw_3 = (uint)1 << 5;
        const uint _Mobilize_Loaded_dw_3 = (uint)1 << 5;
        const uint _Mobilize_Dirty_dw_2 = (uint)1 << 6;
        const uint _Mobilize_Loaded_dw_2 = (uint)1 << 6;
        const uint _Mobilize_Dirty_dw_1 = (uint)1 << 7;
        const uint _Mobilize_Loaded_dw_1 = (uint)1 << 7;
#line 7
    }
}