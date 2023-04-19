#pragma warning disable
#line 1 "d_addprescription\\d_addprescription.cs"
#line hidden
namespace medicationcenter
{
    public partial class d_addprescription
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[10];
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_1) > 0)
            {
                yield return "t_1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_2) > 0)
            {
                yield return "t_2";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_patient) > 0)
            {
                yield return "patient";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_4) > 0)
            {
                yield return "t_4";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_iid) > 0)
            {
                yield return "iid";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_3) > 0)
            {
                yield return "t_3";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dose) > 0)
            {
                yield return "dose";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_5) > 0)
            {
                yield return "t_5";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_medicine) > 0)
            {
                yield return "medicine";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_socialsecurity) > 0)
            {
                yield return "socialsecurity";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "t_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_1) > 0;
                case "t_2":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_2) > 0;
                case "patient":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_patient) > 0;
                case "t_4":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_4) > 0;
                case "iid":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_iid) > 0;
                case "t_3":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_3) > 0;
                case "dose":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dose) > 0;
                case "t_5":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_5) > 0;
                case "medicine":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_medicine) > 0;
                case "socialsecurity":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_socialsecurity) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["t_1"] = _Mobilize_References[0];
            refs["t_2"] = _Mobilize_References[1];
            refs["patient"] = _Mobilize_References[2];
            refs["t_4"] = _Mobilize_References[3];
            refs["iid"] = _Mobilize_References[4];
            refs["t_3"] = _Mobilize_References[5];
            refs["dose"] = _Mobilize_References[6];
            refs["t_5"] = _Mobilize_References[7];
            refs["medicine"] = _Mobilize_References[8];
            refs["socialsecurity"] = _Mobilize_References[9];
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

            var ref_t_1 = (Mobilize.WebMap.Common.Core.IObservable)this.t_1;
            if (ref_t_1 != null)
                yield return ref_t_1;
            var ref_t_2 = (Mobilize.WebMap.Common.Core.IObservable)this.t_2;
            if (ref_t_2 != null)
                yield return ref_t_2;
            var ref_patient = (Mobilize.WebMap.Common.Core.IObservable)this.patient;
            if (ref_patient != null)
                yield return ref_patient;
            var ref_t_4 = (Mobilize.WebMap.Common.Core.IObservable)this.t_4;
            if (ref_t_4 != null)
                yield return ref_t_4;
            var ref_iid = (Mobilize.WebMap.Common.Core.IObservable)this.iid;
            if (ref_iid != null)
                yield return ref_iid;
            var ref_t_3 = (Mobilize.WebMap.Common.Core.IObservable)this.t_3;
            if (ref_t_3 != null)
                yield return ref_t_3;
            var ref_dose = (Mobilize.WebMap.Common.Core.IObservable)this.dose;
            if (ref_dose != null)
                yield return ref_dose;
            var ref_t_5 = (Mobilize.WebMap.Common.Core.IObservable)this.t_5;
            if (ref_t_5 != null)
                yield return ref_t_5;
            var ref_medicine = (Mobilize.WebMap.Common.Core.IObservable)this.medicine;
            if (ref_medicine != null)
                yield return ref_medicine;
            var ref_socialsecurity = (Mobilize.WebMap.Common.Core.IObservable)this.socialsecurity;
            if (ref_socialsecurity != null)
                yield return ref_socialsecurity;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_t_1 = (uint)1 << 0;
        const uint _Mobilize_Loaded_t_1 = (uint)1 << 0;
        const uint _Mobilize_Dirty_t_2 = (uint)1 << 1;
        const uint _Mobilize_Loaded_t_2 = (uint)1 << 1;
        const uint _Mobilize_Dirty_patient = (uint)1 << 2;
        const uint _Mobilize_Loaded_patient = (uint)1 << 2;
        const uint _Mobilize_Dirty_t_4 = (uint)1 << 3;
        const uint _Mobilize_Loaded_t_4 = (uint)1 << 3;
        const uint _Mobilize_Dirty_iid = (uint)1 << 4;
        const uint _Mobilize_Loaded_iid = (uint)1 << 4;
        const uint _Mobilize_Dirty_t_3 = (uint)1 << 5;
        const uint _Mobilize_Loaded_t_3 = (uint)1 << 5;
        const uint _Mobilize_Dirty_dose = (uint)1 << 6;
        const uint _Mobilize_Loaded_dose = (uint)1 << 6;
        const uint _Mobilize_Dirty_t_5 = (uint)1 << 7;
        const uint _Mobilize_Loaded_t_5 = (uint)1 << 7;
        const uint _Mobilize_Dirty_medicine = (uint)1 << 8;
        const uint _Mobilize_Loaded_medicine = (uint)1 << 8;
        const uint _Mobilize_Dirty_socialsecurity = (uint)1 << 9;
        const uint _Mobilize_Loaded_socialsecurity = (uint)1 << 9;
#line 7
    }
}