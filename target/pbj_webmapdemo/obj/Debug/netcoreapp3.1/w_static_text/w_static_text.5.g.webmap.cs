#pragma warning disable
#line 1 "w_static_text\\w_static_text.cs"
#line hidden
namespace pbj_webmapdemo
{
    public partial class w_static_text
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

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_st_1) > 0)
            {
                yield return "st_1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_enable) > 0)
            {
                yield return "cb_enable";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_visible) > 0)
            {
                yield return "cb_visible";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_text) > 0)
            {
                yield return "cb_text";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_showhide) > 0)
            {
                yield return "cb_showhide";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "st_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_st_1) > 0;
                case "cb_enable":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_enable) > 0;
                case "cb_visible":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_visible) > 0;
                case "cb_text":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_text) > 0;
                case "cb_showhide":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_showhide) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["st_1"] = _Mobilize_References[0];
            refs["cb_enable"] = _Mobilize_References[1];
            refs["cb_visible"] = _Mobilize_References[2];
            refs["cb_text"] = _Mobilize_References[3];
            refs["cb_showhide"] = _Mobilize_References[4];
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

            var ref_st_1 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.st_1);
            if (ref_st_1 != null)
                yield return ref_st_1;
            var ref_cb_enable = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_enable);
            if (ref_cb_enable != null)
                yield return ref_cb_enable;
            var ref_cb_visible = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_visible);
            if (ref_cb_visible != null)
                yield return ref_cb_visible;
            var ref_cb_text = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_text);
            if (ref_cb_text != null)
                yield return ref_cb_text;
            var ref_cb_showhide = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_showhide);
            if (ref_cb_showhide != null)
                yield return ref_cb_showhide;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_st_1 = (uint)1 << 0;
        const uint _Mobilize_Loaded_st_1 = (uint)1 << 0;
        const uint _Mobilize_Dirty_cb_enable = (uint)1 << 1;
        const uint _Mobilize_Loaded_cb_enable = (uint)1 << 1;
        const uint _Mobilize_Dirty_cb_visible = (uint)1 << 2;
        const uint _Mobilize_Loaded_cb_visible = (uint)1 << 2;
        const uint _Mobilize_Dirty_cb_text = (uint)1 << 3;
        const uint _Mobilize_Loaded_cb_text = (uint)1 << 3;
        const uint _Mobilize_Dirty_cb_showhide = (uint)1 << 4;
        const uint _Mobilize_Loaded_cb_showhide = (uint)1 << 4;
#line 7
    }
}