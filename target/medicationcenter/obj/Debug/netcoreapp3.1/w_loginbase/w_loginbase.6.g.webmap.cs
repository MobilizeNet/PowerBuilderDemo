#pragma warning disable
#line 1 "w_loginbase\\w_loginbase.cs"
#line hidden
namespace medicationcenter
{
    public partial class w_loginbase
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

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cbx_admin) > 0)
            {
                yield return "cbx_admin";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_st_pass) > 0)
            {
                yield return "st_pass";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_st_user) > 0)
            {
                yield return "st_user";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_sle_pass) > 0)
            {
                yield return "sle_pass";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_sle_user) > 0)
            {
                yield return "sle_user";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_uo_okcancel) > 0)
            {
                yield return "uo_okcancel";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "cbx_admin":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_cbx_admin) > 0;
                case "st_pass":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_st_pass) > 0;
                case "st_user":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_st_user) > 0;
                case "sle_pass":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_sle_pass) > 0;
                case "sle_user":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_sle_user) > 0;
                case "uo_okcancel":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_uo_okcancel) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["cbx_admin"] = _Mobilize_References[0];
            refs["st_pass"] = _Mobilize_References[1];
            refs["st_user"] = _Mobilize_References[2];
            refs["sle_pass"] = _Mobilize_References[3];
            refs["sle_user"] = _Mobilize_References[4];
            refs["uo_okcancel"] = _Mobilize_References[5];
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

            var ref_cbx_admin = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.cbx_admin);
            if (ref_cbx_admin != null)
                yield return ref_cbx_admin;
            var ref_st_pass = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.st_pass);
            if (ref_st_pass != null)
                yield return ref_st_pass;
            var ref_st_user = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.st_user);
            if (ref_st_user != null)
                yield return ref_st_user;
            var ref_sle_pass = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.sle_pass);
            if (ref_sle_pass != null)
                yield return ref_sle_pass;
            var ref_sle_user = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.sle_user);
            if (ref_sle_user != null)
                yield return ref_sle_user;
            var ref_uo_okcancel = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.uo_okcancel);
            if (ref_uo_okcancel != null)
                yield return ref_uo_okcancel;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_cbx_admin = (uint)1 << 0;
        const uint _Mobilize_Loaded_cbx_admin = (uint)1 << 0;
        const uint _Mobilize_Dirty_st_pass = (uint)1 << 1;
        const uint _Mobilize_Loaded_st_pass = (uint)1 << 1;
        const uint _Mobilize_Dirty_st_user = (uint)1 << 2;
        const uint _Mobilize_Loaded_st_user = (uint)1 << 2;
        const uint _Mobilize_Dirty_sle_pass = (uint)1 << 3;
        const uint _Mobilize_Loaded_sle_pass = (uint)1 << 3;
        const uint _Mobilize_Dirty_sle_user = (uint)1 << 4;
        const uint _Mobilize_Loaded_sle_user = (uint)1 << 4;
        const uint _Mobilize_Dirty_uo_okcancel = (uint)1 << 5;
        const uint _Mobilize_Loaded_uo_okcancel = (uint)1 << 5;
#line 7
    }
}