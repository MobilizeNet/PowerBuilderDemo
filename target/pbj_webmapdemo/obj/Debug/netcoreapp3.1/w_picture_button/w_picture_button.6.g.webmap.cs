#pragma warning disable
#line 1 "w_picture_button\\w_picture_button.cs"
#line hidden
namespace pbj_webmapdemo
{
    public partial class w_picture_button
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[6];
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_1) > 0)
            {
                yield return "cb_1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_3) > 0)
            {
                yield return "cb_3";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_6) > 0)
            {
                yield return "cb_6";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_5) > 0)
            {
                yield return "cb_5";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_4) > 0)
            {
                yield return "cb_4";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_pb_1) > 0)
            {
                yield return "pb_1";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "cb_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_1) > 0;
                case "cb_3":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_3) > 0;
                case "cb_6":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_6) > 0;
                case "cb_5":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_5) > 0;
                case "cb_4":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_4) > 0;
                case "pb_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_pb_1) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["cb_1"] = _Mobilize_References[0];
            refs["cb_3"] = _Mobilize_References[1];
            refs["cb_6"] = _Mobilize_References[2];
            refs["cb_5"] = _Mobilize_References[3];
            refs["cb_4"] = _Mobilize_References[4];
            refs["pb_1"] = _Mobilize_References[5];
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

            var ref_cb_1 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_1);
            if (ref_cb_1 != null)
                yield return ref_cb_1;
            var ref_cb_3 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_3);
            if (ref_cb_3 != null)
                yield return ref_cb_3;
            var ref_cb_6 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_6);
            if (ref_cb_6 != null)
                yield return ref_cb_6;
            var ref_cb_5 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_5);
            if (ref_cb_5 != null)
                yield return ref_cb_5;
            var ref_cb_4 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_4);
            if (ref_cb_4 != null)
                yield return ref_cb_4;
            var ref_pb_1 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.pb_1);
            if (ref_pb_1 != null)
                yield return ref_pb_1;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_cb_1 = (uint)1 << 0;
        const uint _Mobilize_Loaded_cb_1 = (uint)1 << 0;
        const uint _Mobilize_Dirty_cb_3 = (uint)1 << 1;
        const uint _Mobilize_Loaded_cb_3 = (uint)1 << 1;
        const uint _Mobilize_Dirty_cb_6 = (uint)1 << 2;
        const uint _Mobilize_Loaded_cb_6 = (uint)1 << 2;
        const uint _Mobilize_Dirty_cb_5 = (uint)1 << 3;
        const uint _Mobilize_Loaded_cb_5 = (uint)1 << 3;
        const uint _Mobilize_Dirty_cb_4 = (uint)1 << 4;
        const uint _Mobilize_Loaded_cb_4 = (uint)1 << 4;
        const uint _Mobilize_Dirty_pb_1 = (uint)1 << 5;
        const uint _Mobilize_Loaded_pb_1 = (uint)1 << 5;
#line 7
    }
}