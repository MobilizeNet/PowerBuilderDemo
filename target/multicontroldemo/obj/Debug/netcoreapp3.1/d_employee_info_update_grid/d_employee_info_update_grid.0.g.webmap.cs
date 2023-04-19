#pragma warning disable
#line 1 "d_employee_info_update_grid\\d_employee_info_update_grid.cs"
#line hidden
namespace multicontroldemo
{
    public partial class d_employee_info_update_grid
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[20];
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_level_t) > 0)
            {
                yield return "level_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tregistered_t) > 0)
            {
                yield return "tregistered_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tname_t) > 0)
            {
                yield return "tname_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tage_t) > 0)
            {
                yield return "tage_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tdescription_t) > 0)
            {
                yield return "tdescription_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tdepartment_t) > 0)
            {
                yield return "tdepartment_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tsalary_t) > 0)
            {
                yield return "tsalary_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tcategory_t) > 0)
            {
                yield return "tcategory_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_thiredate_t) > 0)
            {
                yield return "thiredate_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tlastlogin_t) > 0)
            {
                yield return "tlastlogin_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_level) > 0)
            {
                yield return "level";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tregistered) > 0)
            {
                yield return "tregistered";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tname) > 0)
            {
                yield return "tname";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tage) > 0)
            {
                yield return "tage";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tdescription) > 0)
            {
                yield return "tdescription";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tdepartment) > 0)
            {
                yield return "tdepartment";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tsalary) > 0)
            {
                yield return "tsalary";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tcategory) > 0)
            {
                yield return "tcategory";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_thiredate) > 0)
            {
                yield return "thiredate";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tlastlogin) > 0)
            {
                yield return "tlastlogin";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "level_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_level_t) > 0;
                case "tregistered_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tregistered_t) > 0;
                case "tname_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tname_t) > 0;
                case "tage_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tage_t) > 0;
                case "tdescription_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tdescription_t) > 0;
                case "tdepartment_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tdepartment_t) > 0;
                case "tsalary_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tsalary_t) > 0;
                case "tcategory_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tcategory_t) > 0;
                case "thiredate_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_thiredate_t) > 0;
                case "tlastlogin_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tlastlogin_t) > 0;
                case "level":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_level) > 0;
                case "tregistered":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tregistered) > 0;
                case "tname":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tname) > 0;
                case "tage":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tage) > 0;
                case "tdescription":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tdescription) > 0;
                case "tdepartment":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tdepartment) > 0;
                case "tsalary":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tsalary) > 0;
                case "tcategory":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tcategory) > 0;
                case "thiredate":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_thiredate) > 0;
                case "tlastlogin":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tlastlogin) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["level_t"] = _Mobilize_References[0];
            refs["tregistered_t"] = _Mobilize_References[1];
            refs["tname_t"] = _Mobilize_References[2];
            refs["tage_t"] = _Mobilize_References[3];
            refs["tdescription_t"] = _Mobilize_References[4];
            refs["tdepartment_t"] = _Mobilize_References[5];
            refs["tsalary_t"] = _Mobilize_References[6];
            refs["tcategory_t"] = _Mobilize_References[7];
            refs["thiredate_t"] = _Mobilize_References[8];
            refs["tlastlogin_t"] = _Mobilize_References[9];
            refs["level"] = _Mobilize_References[10];
            refs["tregistered"] = _Mobilize_References[11];
            refs["tname"] = _Mobilize_References[12];
            refs["tage"] = _Mobilize_References[13];
            refs["tdescription"] = _Mobilize_References[14];
            refs["tdepartment"] = _Mobilize_References[15];
            refs["tsalary"] = _Mobilize_References[16];
            refs["tcategory"] = _Mobilize_References[17];
            refs["thiredate"] = _Mobilize_References[18];
            refs["tlastlogin"] = _Mobilize_References[19];
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

            var ref_level_t = (Mobilize.WebMap.Common.Core.IObservable)this.level_t;
            if (ref_level_t != null)
                yield return ref_level_t;
            var ref_tregistered_t = (Mobilize.WebMap.Common.Core.IObservable)this.tregistered_t;
            if (ref_tregistered_t != null)
                yield return ref_tregistered_t;
            var ref_tname_t = (Mobilize.WebMap.Common.Core.IObservable)this.tname_t;
            if (ref_tname_t != null)
                yield return ref_tname_t;
            var ref_tage_t = (Mobilize.WebMap.Common.Core.IObservable)this.tage_t;
            if (ref_tage_t != null)
                yield return ref_tage_t;
            var ref_tdescription_t = (Mobilize.WebMap.Common.Core.IObservable)this.tdescription_t;
            if (ref_tdescription_t != null)
                yield return ref_tdescription_t;
            var ref_tdepartment_t = (Mobilize.WebMap.Common.Core.IObservable)this.tdepartment_t;
            if (ref_tdepartment_t != null)
                yield return ref_tdepartment_t;
            var ref_tsalary_t = (Mobilize.WebMap.Common.Core.IObservable)this.tsalary_t;
            if (ref_tsalary_t != null)
                yield return ref_tsalary_t;
            var ref_tcategory_t = (Mobilize.WebMap.Common.Core.IObservable)this.tcategory_t;
            if (ref_tcategory_t != null)
                yield return ref_tcategory_t;
            var ref_thiredate_t = (Mobilize.WebMap.Common.Core.IObservable)this.thiredate_t;
            if (ref_thiredate_t != null)
                yield return ref_thiredate_t;
            var ref_tlastlogin_t = (Mobilize.WebMap.Common.Core.IObservable)this.tlastlogin_t;
            if (ref_tlastlogin_t != null)
                yield return ref_tlastlogin_t;
            var ref_level = (Mobilize.WebMap.Common.Core.IObservable)this.level;
            if (ref_level != null)
                yield return ref_level;
            var ref_tregistered = (Mobilize.WebMap.Common.Core.IObservable)this.tregistered;
            if (ref_tregistered != null)
                yield return ref_tregistered;
            var ref_tname = (Mobilize.WebMap.Common.Core.IObservable)this.tname;
            if (ref_tname != null)
                yield return ref_tname;
            var ref_tage = (Mobilize.WebMap.Common.Core.IObservable)this.tage;
            if (ref_tage != null)
                yield return ref_tage;
            var ref_tdescription = (Mobilize.WebMap.Common.Core.IObservable)this.tdescription;
            if (ref_tdescription != null)
                yield return ref_tdescription;
            var ref_tdepartment = (Mobilize.WebMap.Common.Core.IObservable)this.tdepartment;
            if (ref_tdepartment != null)
                yield return ref_tdepartment;
            var ref_tsalary = (Mobilize.WebMap.Common.Core.IObservable)this.tsalary;
            if (ref_tsalary != null)
                yield return ref_tsalary;
            var ref_tcategory = (Mobilize.WebMap.Common.Core.IObservable)this.tcategory;
            if (ref_tcategory != null)
                yield return ref_tcategory;
            var ref_thiredate = (Mobilize.WebMap.Common.Core.IObservable)this.thiredate;
            if (ref_thiredate != null)
                yield return ref_thiredate;
            var ref_tlastlogin = (Mobilize.WebMap.Common.Core.IObservable)this.tlastlogin;
            if (ref_tlastlogin != null)
                yield return ref_tlastlogin;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_level_t = (uint)1 << 0;
        const uint _Mobilize_Loaded_level_t = (uint)1 << 0;
        const uint _Mobilize_Dirty_tregistered_t = (uint)1 << 1;
        const uint _Mobilize_Loaded_tregistered_t = (uint)1 << 1;
        const uint _Mobilize_Dirty_tname_t = (uint)1 << 2;
        const uint _Mobilize_Loaded_tname_t = (uint)1 << 2;
        const uint _Mobilize_Dirty_tage_t = (uint)1 << 3;
        const uint _Mobilize_Loaded_tage_t = (uint)1 << 3;
        const uint _Mobilize_Dirty_tdescription_t = (uint)1 << 4;
        const uint _Mobilize_Loaded_tdescription_t = (uint)1 << 4;
        const uint _Mobilize_Dirty_tdepartment_t = (uint)1 << 5;
        const uint _Mobilize_Loaded_tdepartment_t = (uint)1 << 5;
        const uint _Mobilize_Dirty_tsalary_t = (uint)1 << 6;
        const uint _Mobilize_Loaded_tsalary_t = (uint)1 << 6;
        const uint _Mobilize_Dirty_tcategory_t = (uint)1 << 7;
        const uint _Mobilize_Loaded_tcategory_t = (uint)1 << 7;
        const uint _Mobilize_Dirty_thiredate_t = (uint)1 << 8;
        const uint _Mobilize_Loaded_thiredate_t = (uint)1 << 8;
        const uint _Mobilize_Dirty_tlastlogin_t = (uint)1 << 9;
        const uint _Mobilize_Loaded_tlastlogin_t = (uint)1 << 9;
        const uint _Mobilize_Dirty_level = (uint)1 << 10;
        const uint _Mobilize_Loaded_level = (uint)1 << 10;
        const uint _Mobilize_Dirty_tregistered = (uint)1 << 11;
        const uint _Mobilize_Loaded_tregistered = (uint)1 << 11;
        const uint _Mobilize_Dirty_tname = (uint)1 << 12;
        const uint _Mobilize_Loaded_tname = (uint)1 << 12;
        const uint _Mobilize_Dirty_tage = (uint)1 << 13;
        const uint _Mobilize_Loaded_tage = (uint)1 << 13;
        const uint _Mobilize_Dirty_tdescription = (uint)1 << 14;
        const uint _Mobilize_Loaded_tdescription = (uint)1 << 14;
        const uint _Mobilize_Dirty_tdepartment = (uint)1 << 15;
        const uint _Mobilize_Loaded_tdepartment = (uint)1 << 15;
        const uint _Mobilize_Dirty_tsalary = (uint)1 << 16;
        const uint _Mobilize_Loaded_tsalary = (uint)1 << 16;
        const uint _Mobilize_Dirty_tcategory = (uint)1 << 17;
        const uint _Mobilize_Loaded_tcategory = (uint)1 << 17;
        const uint _Mobilize_Dirty_thiredate = (uint)1 << 18;
        const uint _Mobilize_Loaded_thiredate = (uint)1 << 18;
        const uint _Mobilize_Dirty_tlastlogin = (uint)1 << 19;
        const uint _Mobilize_Loaded_tlastlogin = (uint)1 << 19;
#line 7
    }
}