#pragma warning disable
#line 1 "w_allinformation\\w_allinformation.cs"
#line hidden
namespace multicontroldemo
{
    public partial class w_allinformation
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[12];
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

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_sle_1) > 0)
            {
                yield return "sle_1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_insert_details) > 0)
            {
                yield return "cb_insert_details";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_get_text_details) > 0)
            {
                yield return "cb_get_text_details";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_insertrow) > 0)
            {
                yield return "cb_insertrow";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_gettext) > 0)
            {
                yield return "cb_gettext";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_clear) > 0)
            {
                yield return "cb_clear";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_mle_log) > 0)
            {
                yield return "mle_log";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dw_additional_info) > 0)
            {
                yield return "dw_additional_info";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dw_main_info) > 0)
            {
                yield return "dw_main_info";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_gb_main) > 0)
            {
                yield return "gb_main";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_gb_details) > 0)
            {
                yield return "gb_details";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "cb_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_1) > 0;
                case "sle_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_sle_1) > 0;
                case "cb_insert_details":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_insert_details) > 0;
                case "cb_get_text_details":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_get_text_details) > 0;
                case "cb_insertrow":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_insertrow) > 0;
                case "cb_gettext":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_gettext) > 0;
                case "cb_clear":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_clear) > 0;
                case "mle_log":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_mle_log) > 0;
                case "dw_additional_info":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dw_additional_info) > 0;
                case "dw_main_info":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dw_main_info) > 0;
                case "gb_main":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_gb_main) > 0;
                case "gb_details":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_gb_details) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["cb_1"] = _Mobilize_References[0];
            refs["sle_1"] = _Mobilize_References[1];
            refs["cb_insert_details"] = _Mobilize_References[2];
            refs["cb_get_text_details"] = _Mobilize_References[3];
            refs["cb_insertrow"] = _Mobilize_References[4];
            refs["cb_gettext"] = _Mobilize_References[5];
            refs["cb_clear"] = _Mobilize_References[6];
            refs["mle_log"] = _Mobilize_References[7];
            refs["dw_additional_info"] = _Mobilize_References[8];
            refs["dw_main_info"] = _Mobilize_References[9];
            refs["gb_main"] = _Mobilize_References[10];
            refs["gb_details"] = _Mobilize_References[11];
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
            var ref_sle_1 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.sle_1);
            if (ref_sle_1 != null)
                yield return ref_sle_1;
            var ref_cb_insert_details = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_insert_details);
            if (ref_cb_insert_details != null)
                yield return ref_cb_insert_details;
            var ref_cb_get_text_details = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_get_text_details);
            if (ref_cb_get_text_details != null)
                yield return ref_cb_get_text_details;
            var ref_cb_insertrow = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_insertrow);
            if (ref_cb_insertrow != null)
                yield return ref_cb_insertrow;
            var ref_cb_gettext = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_gettext);
            if (ref_cb_gettext != null)
                yield return ref_cb_gettext;
            var ref_cb_clear = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_clear);
            if (ref_cb_clear != null)
                yield return ref_cb_clear;
            var ref_mle_log = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.mle_log);
            if (ref_mle_log != null)
                yield return ref_mle_log;
            var ref_dw_additional_info = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.dw_additional_info);
            if (ref_dw_additional_info != null)
                yield return ref_dw_additional_info;
            var ref_dw_main_info = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.dw_main_info);
            if (ref_dw_main_info != null)
                yield return ref_dw_main_info;
            var ref_gb_main = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.gb_main);
            if (ref_gb_main != null)
                yield return ref_gb_main;
            var ref_gb_details = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.gb_details);
            if (ref_gb_details != null)
                yield return ref_gb_details;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_cb_1 = (uint)1 << 0;
        const uint _Mobilize_Loaded_cb_1 = (uint)1 << 0;
        const uint _Mobilize_Dirty_sle_1 = (uint)1 << 1;
        const uint _Mobilize_Loaded_sle_1 = (uint)1 << 1;
        const uint _Mobilize_Dirty_cb_insert_details = (uint)1 << 2;
        const uint _Mobilize_Loaded_cb_insert_details = (uint)1 << 2;
        const uint _Mobilize_Dirty_cb_get_text_details = (uint)1 << 3;
        const uint _Mobilize_Loaded_cb_get_text_details = (uint)1 << 3;
        const uint _Mobilize_Dirty_cb_insertrow = (uint)1 << 4;
        const uint _Mobilize_Loaded_cb_insertrow = (uint)1 << 4;
        const uint _Mobilize_Dirty_cb_gettext = (uint)1 << 5;
        const uint _Mobilize_Loaded_cb_gettext = (uint)1 << 5;
        const uint _Mobilize_Dirty_cb_clear = (uint)1 << 6;
        const uint _Mobilize_Loaded_cb_clear = (uint)1 << 6;
        const uint _Mobilize_Dirty_mle_log = (uint)1 << 7;
        const uint _Mobilize_Loaded_mle_log = (uint)1 << 7;
        const uint _Mobilize_Dirty_dw_additional_info = (uint)1 << 8;
        const uint _Mobilize_Loaded_dw_additional_info = (uint)1 << 8;
        const uint _Mobilize_Dirty_dw_main_info = (uint)1 << 9;
        const uint _Mobilize_Loaded_dw_main_info = (uint)1 << 9;
        const uint _Mobilize_Dirty_gb_main = (uint)1 << 10;
        const uint _Mobilize_Loaded_gb_main = (uint)1 << 10;
        const uint _Mobilize_Dirty_gb_details = (uint)1 << 11;
        const uint _Mobilize_Loaded_gb_details = (uint)1 << 11;
#line 7
    }
}