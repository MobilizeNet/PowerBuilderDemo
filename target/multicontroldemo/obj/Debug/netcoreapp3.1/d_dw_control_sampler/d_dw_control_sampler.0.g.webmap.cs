#pragma warning disable
#line 1 "d_dw_control_sampler\\d_dw_control_sampler.cs"
#line hidden
namespace multicontroldemo
{
    public partial class d_dw_control_sampler
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

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_name_field_t) > 0)
            {
                yield return "name_field_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_name_field) > 0)
            {
                yield return "name_field";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_age_field_t) > 0)
            {
                yield return "age_field_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_age_field) > 0)
            {
                yield return "age_field";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_description_field_t) > 0)
            {
                yield return "description_field_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_description_field) > 0)
            {
                yield return "description_field";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_date_field_t) > 0)
            {
                yield return "date_field_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_date_field) > 0)
            {
                yield return "date_field";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_event_date_field_t) > 0)
            {
                yield return "event_date_field_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_event_date_field) > 0)
            {
                yield return "event_date_field";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_salary_field_t) > 0)
            {
                yield return "salary_field_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_salary_field) > 0)
            {
                yield return "salary_field";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_flag_field) > 0)
            {
                yield return "flag_field";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_1) > 0)
            {
                yield return "t_1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_options_field) > 0)
            {
                yield return "options_field";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_2) > 0)
            {
                yield return "t_2";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_drop_field) > 0)
            {
                yield return "drop_field";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_3) > 0)
            {
                yield return "t_3";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "name_field_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_name_field_t) > 0;
                case "name_field":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_name_field) > 0;
                case "age_field_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_age_field_t) > 0;
                case "age_field":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_age_field) > 0;
                case "description_field_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_description_field_t) > 0;
                case "description_field":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_description_field) > 0;
                case "date_field_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_date_field_t) > 0;
                case "date_field":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_date_field) > 0;
                case "event_date_field_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_event_date_field_t) > 0;
                case "event_date_field":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_event_date_field) > 0;
                case "salary_field_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_salary_field_t) > 0;
                case "salary_field":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_salary_field) > 0;
                case "flag_field":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_flag_field) > 0;
                case "t_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_1) > 0;
                case "options_field":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_options_field) > 0;
                case "t_2":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_2) > 0;
                case "drop_field":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_drop_field) > 0;
                case "t_3":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_3) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["name_field_t"] = _Mobilize_References[0];
            refs["name_field"] = _Mobilize_References[1];
            refs["age_field_t"] = _Mobilize_References[2];
            refs["age_field"] = _Mobilize_References[3];
            refs["description_field_t"] = _Mobilize_References[4];
            refs["description_field"] = _Mobilize_References[5];
            refs["date_field_t"] = _Mobilize_References[6];
            refs["date_field"] = _Mobilize_References[7];
            refs["event_date_field_t"] = _Mobilize_References[8];
            refs["event_date_field"] = _Mobilize_References[9];
            refs["salary_field_t"] = _Mobilize_References[10];
            refs["salary_field"] = _Mobilize_References[11];
            refs["flag_field"] = _Mobilize_References[12];
            refs["t_1"] = _Mobilize_References[13];
            refs["options_field"] = _Mobilize_References[14];
            refs["t_2"] = _Mobilize_References[15];
            refs["drop_field"] = _Mobilize_References[16];
            refs["t_3"] = _Mobilize_References[17];
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

            var ref_name_field_t = (Mobilize.WebMap.Common.Core.IObservable)this.name_field_t;
            if (ref_name_field_t != null)
                yield return ref_name_field_t;
            var ref_name_field = (Mobilize.WebMap.Common.Core.IObservable)this.name_field;
            if (ref_name_field != null)
                yield return ref_name_field;
            var ref_age_field_t = (Mobilize.WebMap.Common.Core.IObservable)this.age_field_t;
            if (ref_age_field_t != null)
                yield return ref_age_field_t;
            var ref_age_field = (Mobilize.WebMap.Common.Core.IObservable)this.age_field;
            if (ref_age_field != null)
                yield return ref_age_field;
            var ref_description_field_t = (Mobilize.WebMap.Common.Core.IObservable)this.description_field_t;
            if (ref_description_field_t != null)
                yield return ref_description_field_t;
            var ref_description_field = (Mobilize.WebMap.Common.Core.IObservable)this.description_field;
            if (ref_description_field != null)
                yield return ref_description_field;
            var ref_date_field_t = (Mobilize.WebMap.Common.Core.IObservable)this.date_field_t;
            if (ref_date_field_t != null)
                yield return ref_date_field_t;
            var ref_date_field = (Mobilize.WebMap.Common.Core.IObservable)this.date_field;
            if (ref_date_field != null)
                yield return ref_date_field;
            var ref_event_date_field_t = (Mobilize.WebMap.Common.Core.IObservable)this.event_date_field_t;
            if (ref_event_date_field_t != null)
                yield return ref_event_date_field_t;
            var ref_event_date_field = (Mobilize.WebMap.Common.Core.IObservable)this.event_date_field;
            if (ref_event_date_field != null)
                yield return ref_event_date_field;
            var ref_salary_field_t = (Mobilize.WebMap.Common.Core.IObservable)this.salary_field_t;
            if (ref_salary_field_t != null)
                yield return ref_salary_field_t;
            var ref_salary_field = (Mobilize.WebMap.Common.Core.IObservable)this.salary_field;
            if (ref_salary_field != null)
                yield return ref_salary_field;
            var ref_flag_field = (Mobilize.WebMap.Common.Core.IObservable)this.flag_field;
            if (ref_flag_field != null)
                yield return ref_flag_field;
            var ref_t_1 = (Mobilize.WebMap.Common.Core.IObservable)this.t_1;
            if (ref_t_1 != null)
                yield return ref_t_1;
            var ref_options_field = (Mobilize.WebMap.Common.Core.IObservable)this.options_field;
            if (ref_options_field != null)
                yield return ref_options_field;
            var ref_t_2 = (Mobilize.WebMap.Common.Core.IObservable)this.t_2;
            if (ref_t_2 != null)
                yield return ref_t_2;
            var ref_drop_field = (Mobilize.WebMap.Common.Core.IObservable)this.drop_field;
            if (ref_drop_field != null)
                yield return ref_drop_field;
            var ref_t_3 = (Mobilize.WebMap.Common.Core.IObservable)this.t_3;
            if (ref_t_3 != null)
                yield return ref_t_3;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_name_field_t = (uint)1 << 0;
        const uint _Mobilize_Loaded_name_field_t = (uint)1 << 0;
        const uint _Mobilize_Dirty_name_field = (uint)1 << 1;
        const uint _Mobilize_Loaded_name_field = (uint)1 << 1;
        const uint _Mobilize_Dirty_age_field_t = (uint)1 << 2;
        const uint _Mobilize_Loaded_age_field_t = (uint)1 << 2;
        const uint _Mobilize_Dirty_age_field = (uint)1 << 3;
        const uint _Mobilize_Loaded_age_field = (uint)1 << 3;
        const uint _Mobilize_Dirty_description_field_t = (uint)1 << 4;
        const uint _Mobilize_Loaded_description_field_t = (uint)1 << 4;
        const uint _Mobilize_Dirty_description_field = (uint)1 << 5;
        const uint _Mobilize_Loaded_description_field = (uint)1 << 5;
        const uint _Mobilize_Dirty_date_field_t = (uint)1 << 6;
        const uint _Mobilize_Loaded_date_field_t = (uint)1 << 6;
        const uint _Mobilize_Dirty_date_field = (uint)1 << 7;
        const uint _Mobilize_Loaded_date_field = (uint)1 << 7;
        const uint _Mobilize_Dirty_event_date_field_t = (uint)1 << 8;
        const uint _Mobilize_Loaded_event_date_field_t = (uint)1 << 8;
        const uint _Mobilize_Dirty_event_date_field = (uint)1 << 9;
        const uint _Mobilize_Loaded_event_date_field = (uint)1 << 9;
        const uint _Mobilize_Dirty_salary_field_t = (uint)1 << 10;
        const uint _Mobilize_Loaded_salary_field_t = (uint)1 << 10;
        const uint _Mobilize_Dirty_salary_field = (uint)1 << 11;
        const uint _Mobilize_Loaded_salary_field = (uint)1 << 11;
        const uint _Mobilize_Dirty_flag_field = (uint)1 << 12;
        const uint _Mobilize_Loaded_flag_field = (uint)1 << 12;
        const uint _Mobilize_Dirty_t_1 = (uint)1 << 13;
        const uint _Mobilize_Loaded_t_1 = (uint)1 << 13;
        const uint _Mobilize_Dirty_options_field = (uint)1 << 14;
        const uint _Mobilize_Loaded_options_field = (uint)1 << 14;
        const uint _Mobilize_Dirty_t_2 = (uint)1 << 15;
        const uint _Mobilize_Loaded_t_2 = (uint)1 << 15;
        const uint _Mobilize_Dirty_drop_field = (uint)1 << 16;
        const uint _Mobilize_Loaded_drop_field = (uint)1 << 16;
        const uint _Mobilize_Dirty_t_3 = (uint)1 << 17;
        const uint _Mobilize_Loaded_t_3 = (uint)1 << 17;
#line 7
    }
}