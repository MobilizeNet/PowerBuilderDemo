#pragma warning disable
#line 1 "d_showallprescrpition\\d_showallprescrpition.cs"
#line hidden
namespace medicationcenter
{
    public partial class d_showallprescrpition
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

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_id_t) > 0)
            {
                yield return "id_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_medicine_t) > 0)
            {
                yield return "medicine_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_patient_t) > 0)
            {
                yield return "patient_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dose_t) > 0)
            {
                yield return "dose_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_socialsecurity_t) > 0)
            {
                yield return "socialsecurity_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_iid) > 0)
            {
                yield return "iid";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_medicine) > 0)
            {
                yield return "medicine";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_patient) > 0)
            {
                yield return "patient";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dose) > 0)
            {
                yield return "dose";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_socialsecurity) > 0)
            {
                yield return "socialsecurity";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_1) > 0)
            {
                yield return "t_1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_compute_1) > 0)
            {
                yield return "compute_1";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "id_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_id_t) > 0;
                case "medicine_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_medicine_t) > 0;
                case "patient_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_patient_t) > 0;
                case "dose_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dose_t) > 0;
                case "socialsecurity_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_socialsecurity_t) > 0;
                case "iid":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_iid) > 0;
                case "medicine":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_medicine) > 0;
                case "patient":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_patient) > 0;
                case "dose":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dose) > 0;
                case "socialsecurity":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_socialsecurity) > 0;
                case "t_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_1) > 0;
                case "compute_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_compute_1) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["id_t"] = _Mobilize_References[0];
            refs["medicine_t"] = _Mobilize_References[1];
            refs["patient_t"] = _Mobilize_References[2];
            refs["dose_t"] = _Mobilize_References[3];
            refs["socialsecurity_t"] = _Mobilize_References[4];
            refs["iid"] = _Mobilize_References[5];
            refs["medicine"] = _Mobilize_References[6];
            refs["patient"] = _Mobilize_References[7];
            refs["dose"] = _Mobilize_References[8];
            refs["socialsecurity"] = _Mobilize_References[9];
            refs["t_1"] = _Mobilize_References[10];
            refs["compute_1"] = _Mobilize_References[11];
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

            var ref_id_t = (Mobilize.WebMap.Common.Core.IObservable)this.id_t;
            if (ref_id_t != null)
                yield return ref_id_t;
            var ref_medicine_t = (Mobilize.WebMap.Common.Core.IObservable)this.medicine_t;
            if (ref_medicine_t != null)
                yield return ref_medicine_t;
            var ref_patient_t = (Mobilize.WebMap.Common.Core.IObservable)this.patient_t;
            if (ref_patient_t != null)
                yield return ref_patient_t;
            var ref_dose_t = (Mobilize.WebMap.Common.Core.IObservable)this.dose_t;
            if (ref_dose_t != null)
                yield return ref_dose_t;
            var ref_socialsecurity_t = (Mobilize.WebMap.Common.Core.IObservable)this.socialsecurity_t;
            if (ref_socialsecurity_t != null)
                yield return ref_socialsecurity_t;
            var ref_iid = (Mobilize.WebMap.Common.Core.IObservable)this.iid;
            if (ref_iid != null)
                yield return ref_iid;
            var ref_medicine = (Mobilize.WebMap.Common.Core.IObservable)this.medicine;
            if (ref_medicine != null)
                yield return ref_medicine;
            var ref_patient = (Mobilize.WebMap.Common.Core.IObservable)this.patient;
            if (ref_patient != null)
                yield return ref_patient;
            var ref_dose = (Mobilize.WebMap.Common.Core.IObservable)this.dose;
            if (ref_dose != null)
                yield return ref_dose;
            var ref_socialsecurity = (Mobilize.WebMap.Common.Core.IObservable)this.socialsecurity;
            if (ref_socialsecurity != null)
                yield return ref_socialsecurity;
            var ref_t_1 = (Mobilize.WebMap.Common.Core.IObservable)this.t_1;
            if (ref_t_1 != null)
                yield return ref_t_1;
            var ref_compute_1 = (Mobilize.WebMap.Common.Core.IObservable)this.compute_1;
            if (ref_compute_1 != null)
                yield return ref_compute_1;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_id_t = (uint)1 << 0;
        const uint _Mobilize_Loaded_id_t = (uint)1 << 0;
        const uint _Mobilize_Dirty_medicine_t = (uint)1 << 1;
        const uint _Mobilize_Loaded_medicine_t = (uint)1 << 1;
        const uint _Mobilize_Dirty_patient_t = (uint)1 << 2;
        const uint _Mobilize_Loaded_patient_t = (uint)1 << 2;
        const uint _Mobilize_Dirty_dose_t = (uint)1 << 3;
        const uint _Mobilize_Loaded_dose_t = (uint)1 << 3;
        const uint _Mobilize_Dirty_socialsecurity_t = (uint)1 << 4;
        const uint _Mobilize_Loaded_socialsecurity_t = (uint)1 << 4;
        const uint _Mobilize_Dirty_iid = (uint)1 << 5;
        const uint _Mobilize_Loaded_iid = (uint)1 << 5;
        const uint _Mobilize_Dirty_medicine = (uint)1 << 6;
        const uint _Mobilize_Loaded_medicine = (uint)1 << 6;
        const uint _Mobilize_Dirty_patient = (uint)1 << 7;
        const uint _Mobilize_Loaded_patient = (uint)1 << 7;
        const uint _Mobilize_Dirty_dose = (uint)1 << 8;
        const uint _Mobilize_Loaded_dose = (uint)1 << 8;
        const uint _Mobilize_Dirty_socialsecurity = (uint)1 << 9;
        const uint _Mobilize_Loaded_socialsecurity = (uint)1 << 9;
        const uint _Mobilize_Dirty_t_1 = (uint)1 << 10;
        const uint _Mobilize_Loaded_t_1 = (uint)1 << 10;
        const uint _Mobilize_Dirty_compute_1 = (uint)1 << 11;
        const uint _Mobilize_Loaded_compute_1 = (uint)1 << 11;
#line 7
    }
}