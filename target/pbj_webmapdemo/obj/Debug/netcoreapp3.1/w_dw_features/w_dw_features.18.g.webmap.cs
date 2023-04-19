#pragma warning disable
#line 1 "w_dw_features\\w_dw_features.cs"
#line hidden
namespace pbj_webmapdemo
{
    public partial class w_dw_features
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[18];
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_rb_freeform) > 0)
            {
                yield return "rb_freeform";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_rb_grid) > 0)
            {
                yield return "rb_grid";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_rb_4) > 0)
            {
                yield return "rb_4";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_rb_3) > 0)
            {
                yield return "rb_3";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_rb_2) > 0)
            {
                yield return "rb_2";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_rb_1) > 0)
            {
                yield return "rb_1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_st_4) > 0)
            {
                yield return "st_4";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_sle_1) > 0)
            {
                yield return "sle_1";
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

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dw_1) > 0)
            {
                yield return "dw_1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_gb_1) > 0)
            {
                yield return "gb_1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_gb_2) > 0)
            {
                yield return "gb_2";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_gb_3) > 0)
            {
                yield return "gb_3";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "rb_freeform":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_rb_freeform) > 0;
                case "rb_grid":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_rb_grid) > 0;
                case "rb_4":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_rb_4) > 0;
                case "rb_3":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_rb_3) > 0;
                case "rb_2":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_rb_2) > 0;
                case "rb_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_rb_1) > 0;
                case "st_4":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_st_4) > 0;
                case "sle_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_sle_1) > 0;
                case "cb_6":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_6) > 0;
                case "cb_5":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_5) > 0;
                case "cb_4":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_4) > 0;
                case "cb_3":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_3) > 0;
                case "cb_2":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_2) > 0;
                case "cb_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cb_1) > 0;
                case "dw_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dw_1) > 0;
                case "gb_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_gb_1) > 0;
                case "gb_2":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_gb_2) > 0;
                case "gb_3":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_gb_3) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["rb_freeform"] = _Mobilize_References[0];
            refs["rb_grid"] = _Mobilize_References[1];
            refs["rb_4"] = _Mobilize_References[2];
            refs["rb_3"] = _Mobilize_References[3];
            refs["rb_2"] = _Mobilize_References[4];
            refs["rb_1"] = _Mobilize_References[5];
            refs["st_4"] = _Mobilize_References[6];
            refs["sle_1"] = _Mobilize_References[7];
            refs["cb_6"] = _Mobilize_References[8];
            refs["cb_5"] = _Mobilize_References[9];
            refs["cb_4"] = _Mobilize_References[10];
            refs["cb_3"] = _Mobilize_References[11];
            refs["cb_2"] = _Mobilize_References[12];
            refs["cb_1"] = _Mobilize_References[13];
            refs["dw_1"] = _Mobilize_References[14];
            refs["gb_1"] = _Mobilize_References[15];
            refs["gb_2"] = _Mobilize_References[16];
            refs["gb_3"] = _Mobilize_References[17];
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

            var ref_rb_freeform = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.rb_freeform);
            if (ref_rb_freeform != null)
                yield return ref_rb_freeform;
            var ref_rb_grid = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.rb_grid);
            if (ref_rb_grid != null)
                yield return ref_rb_grid;
            var ref_rb_4 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.rb_4);
            if (ref_rb_4 != null)
                yield return ref_rb_4;
            var ref_rb_3 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.rb_3);
            if (ref_rb_3 != null)
                yield return ref_rb_3;
            var ref_rb_2 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.rb_2);
            if (ref_rb_2 != null)
                yield return ref_rb_2;
            var ref_rb_1 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.rb_1);
            if (ref_rb_1 != null)
                yield return ref_rb_1;
            var ref_st_4 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.st_4);
            if (ref_st_4 != null)
                yield return ref_st_4;
            var ref_sle_1 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.sle_1);
            if (ref_sle_1 != null)
                yield return ref_sle_1;
            var ref_cb_6 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_6);
            if (ref_cb_6 != null)
                yield return ref_cb_6;
            var ref_cb_5 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_5);
            if (ref_cb_5 != null)
                yield return ref_cb_5;
            var ref_cb_4 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_4);
            if (ref_cb_4 != null)
                yield return ref_cb_4;
            var ref_cb_3 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_3);
            if (ref_cb_3 != null)
                yield return ref_cb_3;
            var ref_cb_2 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_2);
            if (ref_cb_2 != null)
                yield return ref_cb_2;
            var ref_cb_1 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cb_1);
            if (ref_cb_1 != null)
                yield return ref_cb_1;
            var ref_dw_1 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.dw_1);
            if (ref_dw_1 != null)
                yield return ref_dw_1;
            var ref_gb_1 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.gb_1);
            if (ref_gb_1 != null)
                yield return ref_gb_1;
            var ref_gb_2 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.gb_2);
            if (ref_gb_2 != null)
                yield return ref_gb_2;
            var ref_gb_3 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.gb_3);
            if (ref_gb_3 != null)
                yield return ref_gb_3;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_rb_freeform = (uint)1 << 0;
        const uint _Mobilize_Loaded_rb_freeform = (uint)1 << 0;
        const uint _Mobilize_Dirty_rb_grid = (uint)1 << 1;
        const uint _Mobilize_Loaded_rb_grid = (uint)1 << 1;
        const uint _Mobilize_Dirty_rb_4 = (uint)1 << 2;
        const uint _Mobilize_Loaded_rb_4 = (uint)1 << 2;
        const uint _Mobilize_Dirty_rb_3 = (uint)1 << 3;
        const uint _Mobilize_Loaded_rb_3 = (uint)1 << 3;
        const uint _Mobilize_Dirty_rb_2 = (uint)1 << 4;
        const uint _Mobilize_Loaded_rb_2 = (uint)1 << 4;
        const uint _Mobilize_Dirty_rb_1 = (uint)1 << 5;
        const uint _Mobilize_Loaded_rb_1 = (uint)1 << 5;
        const uint _Mobilize_Dirty_st_4 = (uint)1 << 6;
        const uint _Mobilize_Loaded_st_4 = (uint)1 << 6;
        const uint _Mobilize_Dirty_sle_1 = (uint)1 << 7;
        const uint _Mobilize_Loaded_sle_1 = (uint)1 << 7;
        const uint _Mobilize_Dirty_cb_6 = (uint)1 << 8;
        const uint _Mobilize_Loaded_cb_6 = (uint)1 << 8;
        const uint _Mobilize_Dirty_cb_5 = (uint)1 << 9;
        const uint _Mobilize_Loaded_cb_5 = (uint)1 << 9;
        const uint _Mobilize_Dirty_cb_4 = (uint)1 << 10;
        const uint _Mobilize_Loaded_cb_4 = (uint)1 << 10;
        const uint _Mobilize_Dirty_cb_3 = (uint)1 << 11;
        const uint _Mobilize_Loaded_cb_3 = (uint)1 << 11;
        const uint _Mobilize_Dirty_cb_2 = (uint)1 << 12;
        const uint _Mobilize_Loaded_cb_2 = (uint)1 << 12;
        const uint _Mobilize_Dirty_cb_1 = (uint)1 << 13;
        const uint _Mobilize_Loaded_cb_1 = (uint)1 << 13;
        const uint _Mobilize_Dirty_dw_1 = (uint)1 << 14;
        const uint _Mobilize_Loaded_dw_1 = (uint)1 << 14;
        const uint _Mobilize_Dirty_gb_1 = (uint)1 << 15;
        const uint _Mobilize_Loaded_gb_1 = (uint)1 << 15;
        const uint _Mobilize_Dirty_gb_2 = (uint)1 << 16;
        const uint _Mobilize_Loaded_gb_2 = (uint)1 << 16;
        const uint _Mobilize_Dirty_gb_3 = (uint)1 << 17;
        const uint _Mobilize_Loaded_gb_3 = (uint)1 << 17;
#line 7
    }
}