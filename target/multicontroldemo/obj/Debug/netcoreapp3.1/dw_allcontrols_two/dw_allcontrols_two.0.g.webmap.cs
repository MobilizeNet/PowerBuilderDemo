#pragma warning disable
#line 1 "dw_allcontrols_two\\dw_allcontrols_two.cs"
#line hidden
namespace multicontroldemo
{
    public partial class dw_allcontrols_two
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[16];
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_prospect) > 0)
            {
                yield return "prospect";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_password_t) > 0)
            {
                yield return "password_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_department_t) > 0)
            {
                yield return "department_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_full_name_t) > 0)
            {
                yield return "full_name_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_full_name) > 0)
            {
                yield return "full_name";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_password) > 0)
            {
                yield return "password";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_department) > 0)
            {
                yield return "department";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_domain) > 0)
            {
                yield return "domain";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_code_t) > 0)
            {
                yield return "code_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_code) > 0)
            {
                yield return "code";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_compute_full_info) > 0)
            {
                yield return "compute_full_info";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_revenuew_t) > 0)
            {
                yield return "revenuew_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_logo) > 0)
            {
                yield return "logo";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_last_meeting_t) > 0)
            {
                yield return "last_meeting_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_revenuew) > 0)
            {
                yield return "revenuew";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_last_meeting) > 0)
            {
                yield return "last_meeting";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "prospect":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_prospect) > 0;
                case "password_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_password_t) > 0;
                case "department_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_department_t) > 0;
                case "full_name_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_full_name_t) > 0;
                case "full_name":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_full_name) > 0;
                case "password":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_password) > 0;
                case "department":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_department) > 0;
                case "domain":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_domain) > 0;
                case "code_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_code_t) > 0;
                case "code":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_code) > 0;
                case "compute_full_info":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_compute_full_info) > 0;
                case "revenuew_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_revenuew_t) > 0;
                case "logo":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_logo) > 0;
                case "last_meeting_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_last_meeting_t) > 0;
                case "revenuew":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_revenuew) > 0;
                case "last_meeting":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_last_meeting) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["prospect"] = _Mobilize_References[0];
            refs["password_t"] = _Mobilize_References[1];
            refs["department_t"] = _Mobilize_References[2];
            refs["full_name_t"] = _Mobilize_References[3];
            refs["full_name"] = _Mobilize_References[4];
            refs["password"] = _Mobilize_References[5];
            refs["department"] = _Mobilize_References[6];
            refs["domain"] = _Mobilize_References[7];
            refs["code_t"] = _Mobilize_References[8];
            refs["code"] = _Mobilize_References[9];
            refs["compute_full_info"] = _Mobilize_References[10];
            refs["revenuew_t"] = _Mobilize_References[11];
            refs["logo"] = _Mobilize_References[12];
            refs["last_meeting_t"] = _Mobilize_References[13];
            refs["revenuew"] = _Mobilize_References[14];
            refs["last_meeting"] = _Mobilize_References[15];
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

            var ref_prospect = (Mobilize.WebMap.Common.Core.IObservable)this.prospect;
            if (ref_prospect != null)
                yield return ref_prospect;
            var ref_password_t = (Mobilize.WebMap.Common.Core.IObservable)this.password_t;
            if (ref_password_t != null)
                yield return ref_password_t;
            var ref_department_t = (Mobilize.WebMap.Common.Core.IObservable)this.department_t;
            if (ref_department_t != null)
                yield return ref_department_t;
            var ref_full_name_t = (Mobilize.WebMap.Common.Core.IObservable)this.full_name_t;
            if (ref_full_name_t != null)
                yield return ref_full_name_t;
            var ref_full_name = (Mobilize.WebMap.Common.Core.IObservable)this.full_name;
            if (ref_full_name != null)
                yield return ref_full_name;
            var ref_password = (Mobilize.WebMap.Common.Core.IObservable)this.password;
            if (ref_password != null)
                yield return ref_password;
            var ref_department = (Mobilize.WebMap.Common.Core.IObservable)this.department;
            if (ref_department != null)
                yield return ref_department;
            var ref_domain = (Mobilize.WebMap.Common.Core.IObservable)this.domain;
            if (ref_domain != null)
                yield return ref_domain;
            var ref_code_t = (Mobilize.WebMap.Common.Core.IObservable)this.code_t;
            if (ref_code_t != null)
                yield return ref_code_t;
            var ref_code = (Mobilize.WebMap.Common.Core.IObservable)this.code;
            if (ref_code != null)
                yield return ref_code;
            var ref_compute_full_info = (Mobilize.WebMap.Common.Core.IObservable)this.compute_full_info;
            if (ref_compute_full_info != null)
                yield return ref_compute_full_info;
            var ref_revenuew_t = (Mobilize.WebMap.Common.Core.IObservable)this.revenuew_t;
            if (ref_revenuew_t != null)
                yield return ref_revenuew_t;
            var ref_logo = (Mobilize.WebMap.Common.Core.IObservable)this.logo;
            if (ref_logo != null)
                yield return ref_logo;
            var ref_last_meeting_t = (Mobilize.WebMap.Common.Core.IObservable)this.last_meeting_t;
            if (ref_last_meeting_t != null)
                yield return ref_last_meeting_t;
            var ref_revenuew = (Mobilize.WebMap.Common.Core.IObservable)this.revenuew;
            if (ref_revenuew != null)
                yield return ref_revenuew;
            var ref_last_meeting = (Mobilize.WebMap.Common.Core.IObservable)this.last_meeting;
            if (ref_last_meeting != null)
                yield return ref_last_meeting;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_prospect = (uint)1 << 0;
        const uint _Mobilize_Loaded_prospect = (uint)1 << 0;
        const uint _Mobilize_Dirty_password_t = (uint)1 << 1;
        const uint _Mobilize_Loaded_password_t = (uint)1 << 1;
        const uint _Mobilize_Dirty_department_t = (uint)1 << 2;
        const uint _Mobilize_Loaded_department_t = (uint)1 << 2;
        const uint _Mobilize_Dirty_full_name_t = (uint)1 << 3;
        const uint _Mobilize_Loaded_full_name_t = (uint)1 << 3;
        const uint _Mobilize_Dirty_full_name = (uint)1 << 4;
        const uint _Mobilize_Loaded_full_name = (uint)1 << 4;
        const uint _Mobilize_Dirty_password = (uint)1 << 5;
        const uint _Mobilize_Loaded_password = (uint)1 << 5;
        const uint _Mobilize_Dirty_department = (uint)1 << 6;
        const uint _Mobilize_Loaded_department = (uint)1 << 6;
        const uint _Mobilize_Dirty_domain = (uint)1 << 7;
        const uint _Mobilize_Loaded_domain = (uint)1 << 7;
        const uint _Mobilize_Dirty_code_t = (uint)1 << 8;
        const uint _Mobilize_Loaded_code_t = (uint)1 << 8;
        const uint _Mobilize_Dirty_code = (uint)1 << 9;
        const uint _Mobilize_Loaded_code = (uint)1 << 9;
        const uint _Mobilize_Dirty_compute_full_info = (uint)1 << 10;
        const uint _Mobilize_Loaded_compute_full_info = (uint)1 << 10;
        const uint _Mobilize_Dirty_revenuew_t = (uint)1 << 11;
        const uint _Mobilize_Loaded_revenuew_t = (uint)1 << 11;
        const uint _Mobilize_Dirty_logo = (uint)1 << 12;
        const uint _Mobilize_Loaded_logo = (uint)1 << 12;
        const uint _Mobilize_Dirty_last_meeting_t = (uint)1 << 13;
        const uint _Mobilize_Loaded_last_meeting_t = (uint)1 << 13;
        const uint _Mobilize_Dirty_revenuew = (uint)1 << 14;
        const uint _Mobilize_Loaded_revenuew = (uint)1 << 14;
        const uint _Mobilize_Dirty_last_meeting = (uint)1 << 15;
        const uint _Mobilize_Loaded_last_meeting = (uint)1 << 15;
#line 7
    }
}