#pragma warning disable
#line 1 "dw_allcontrols_one\\dw_allcontrols_one.cs"
#line hidden
namespace multicontroldemo
{
    public partial class dw_allcontrols_one
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[19];
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_name) > 0)
            {
                yield return "t_name";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__name) > 0)
            {
                yield return "_name";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_b_change_state) > 0)
            {
                yield return "b_change_state";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_hire_date) > 0)
            {
                yield return "t_hire_date";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_schedule) > 0)
            {
                yield return "t_schedule";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_phone) > 0)
            {
                yield return "t_phone";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_gender) > 0)
            {
                yield return "t_gender";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_type) > 0)
            {
                yield return "t_type";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_social_number) > 0)
            {
                yield return "t_social_number";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_gender) > 0)
            {
                yield return "gender";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_type) > 0)
            {
                yield return "type";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_compute_percentage) > 0)
            {
                yield return "compute_percentage";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_active) > 0)
            {
                yield return "active";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_account) > 0)
            {
                yield return "account";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_social_number) > 0)
            {
                yield return "social_number";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_phone) > 0)
            {
                yield return "phone";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_hire_date) > 0)
            {
                yield return "hire_date";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_schedule) > 0)
            {
                yield return "schedule";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dist_code) > 0)
            {
                yield return "dist_code";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "t_name":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_name) > 0;
                case "_name":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__name) > 0;
                case "b_change_state":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_b_change_state) > 0;
                case "t_hire_date":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_hire_date) > 0;
                case "t_schedule":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_schedule) > 0;
                case "t_phone":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_phone) > 0;
                case "t_gender":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_gender) > 0;
                case "t_type":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_type) > 0;
                case "t_social_number":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_social_number) > 0;
                case "gender":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_gender) > 0;
                case "type":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_type) > 0;
                case "compute_percentage":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_compute_percentage) > 0;
                case "active":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_active) > 0;
                case "account":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_account) > 0;
                case "social_number":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_social_number) > 0;
                case "phone":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_phone) > 0;
                case "hire_date":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_hire_date) > 0;
                case "schedule":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_schedule) > 0;
                case "dist_code":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dist_code) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["t_name"] = _Mobilize_References[0];
            refs["_name"] = _Mobilize_References[1];
            refs["b_change_state"] = _Mobilize_References[2];
            refs["t_hire_date"] = _Mobilize_References[3];
            refs["t_schedule"] = _Mobilize_References[4];
            refs["t_phone"] = _Mobilize_References[5];
            refs["t_gender"] = _Mobilize_References[6];
            refs["t_type"] = _Mobilize_References[7];
            refs["t_social_number"] = _Mobilize_References[8];
            refs["gender"] = _Mobilize_References[9];
            refs["type"] = _Mobilize_References[10];
            refs["compute_percentage"] = _Mobilize_References[11];
            refs["active"] = _Mobilize_References[12];
            refs["account"] = _Mobilize_References[13];
            refs["social_number"] = _Mobilize_References[14];
            refs["phone"] = _Mobilize_References[15];
            refs["hire_date"] = _Mobilize_References[16];
            refs["schedule"] = _Mobilize_References[17];
            refs["dist_code"] = _Mobilize_References[18];
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

            var ref_t_name = (Mobilize.WebMap.Common.Core.IObservable)this.t_name;
            if (ref_t_name != null)
                yield return ref_t_name;
            var ref__name = (Mobilize.WebMap.Common.Core.IObservable)this._name;
            if (ref__name != null)
                yield return ref__name;
            var ref_b_change_state = (Mobilize.WebMap.Common.Core.IObservable)this.b_change_state;
            if (ref_b_change_state != null)
                yield return ref_b_change_state;
            var ref_t_hire_date = (Mobilize.WebMap.Common.Core.IObservable)this.t_hire_date;
            if (ref_t_hire_date != null)
                yield return ref_t_hire_date;
            var ref_t_schedule = (Mobilize.WebMap.Common.Core.IObservable)this.t_schedule;
            if (ref_t_schedule != null)
                yield return ref_t_schedule;
            var ref_t_phone = (Mobilize.WebMap.Common.Core.IObservable)this.t_phone;
            if (ref_t_phone != null)
                yield return ref_t_phone;
            var ref_t_gender = (Mobilize.WebMap.Common.Core.IObservable)this.t_gender;
            if (ref_t_gender != null)
                yield return ref_t_gender;
            var ref_t_type = (Mobilize.WebMap.Common.Core.IObservable)this.t_type;
            if (ref_t_type != null)
                yield return ref_t_type;
            var ref_t_social_number = (Mobilize.WebMap.Common.Core.IObservable)this.t_social_number;
            if (ref_t_social_number != null)
                yield return ref_t_social_number;
            var ref_gender = (Mobilize.WebMap.Common.Core.IObservable)this.gender;
            if (ref_gender != null)
                yield return ref_gender;
            var ref_type = (Mobilize.WebMap.Common.Core.IObservable)this.type;
            if (ref_type != null)
                yield return ref_type;
            var ref_compute_percentage = (Mobilize.WebMap.Common.Core.IObservable)this.compute_percentage;
            if (ref_compute_percentage != null)
                yield return ref_compute_percentage;
            var ref_active = (Mobilize.WebMap.Common.Core.IObservable)this.active;
            if (ref_active != null)
                yield return ref_active;
            var ref_account = (Mobilize.WebMap.Common.Core.IObservable)this.account;
            if (ref_account != null)
                yield return ref_account;
            var ref_social_number = (Mobilize.WebMap.Common.Core.IObservable)this.social_number;
            if (ref_social_number != null)
                yield return ref_social_number;
            var ref_phone = (Mobilize.WebMap.Common.Core.IObservable)this.phone;
            if (ref_phone != null)
                yield return ref_phone;
            var ref_hire_date = (Mobilize.WebMap.Common.Core.IObservable)this.hire_date;
            if (ref_hire_date != null)
                yield return ref_hire_date;
            var ref_schedule = (Mobilize.WebMap.Common.Core.IObservable)this.schedule;
            if (ref_schedule != null)
                yield return ref_schedule;
            var ref_dist_code = (Mobilize.WebMap.Common.Core.IObservable)this.dist_code;
            if (ref_dist_code != null)
                yield return ref_dist_code;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_t_name = (uint)1 << 0;
        const uint _Mobilize_Loaded_t_name = (uint)1 << 0;
        const uint _Mobilize_Dirty__name = (uint)1 << 1;
        const uint _Mobilize_Loaded__name = (uint)1 << 1;
        const uint _Mobilize_Dirty_b_change_state = (uint)1 << 2;
        const uint _Mobilize_Loaded_b_change_state = (uint)1 << 2;
        const uint _Mobilize_Dirty_t_hire_date = (uint)1 << 3;
        const uint _Mobilize_Loaded_t_hire_date = (uint)1 << 3;
        const uint _Mobilize_Dirty_t_schedule = (uint)1 << 4;
        const uint _Mobilize_Loaded_t_schedule = (uint)1 << 4;
        const uint _Mobilize_Dirty_t_phone = (uint)1 << 5;
        const uint _Mobilize_Loaded_t_phone = (uint)1 << 5;
        const uint _Mobilize_Dirty_t_gender = (uint)1 << 6;
        const uint _Mobilize_Loaded_t_gender = (uint)1 << 6;
        const uint _Mobilize_Dirty_t_type = (uint)1 << 7;
        const uint _Mobilize_Loaded_t_type = (uint)1 << 7;
        const uint _Mobilize_Dirty_t_social_number = (uint)1 << 8;
        const uint _Mobilize_Loaded_t_social_number = (uint)1 << 8;
        const uint _Mobilize_Dirty_gender = (uint)1 << 9;
        const uint _Mobilize_Loaded_gender = (uint)1 << 9;
        const uint _Mobilize_Dirty_type = (uint)1 << 10;
        const uint _Mobilize_Loaded_type = (uint)1 << 10;
        const uint _Mobilize_Dirty_compute_percentage = (uint)1 << 11;
        const uint _Mobilize_Loaded_compute_percentage = (uint)1 << 11;
        const uint _Mobilize_Dirty_active = (uint)1 << 12;
        const uint _Mobilize_Loaded_active = (uint)1 << 12;
        const uint _Mobilize_Dirty_account = (uint)1 << 13;
        const uint _Mobilize_Loaded_account = (uint)1 << 13;
        const uint _Mobilize_Dirty_social_number = (uint)1 << 14;
        const uint _Mobilize_Loaded_social_number = (uint)1 << 14;
        const uint _Mobilize_Dirty_phone = (uint)1 << 15;
        const uint _Mobilize_Loaded_phone = (uint)1 << 15;
        const uint _Mobilize_Dirty_hire_date = (uint)1 << 16;
        const uint _Mobilize_Loaded_hire_date = (uint)1 << 16;
        const uint _Mobilize_Dirty_schedule = (uint)1 << 17;
        const uint _Mobilize_Loaded_schedule = (uint)1 << 17;
        const uint _Mobilize_Dirty_dist_code = (uint)1 << 18;
        const uint _Mobilize_Loaded_dist_code = (uint)1 << 18;
#line 7
    }
}