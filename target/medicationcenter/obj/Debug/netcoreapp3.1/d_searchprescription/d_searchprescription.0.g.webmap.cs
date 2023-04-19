#pragma warning disable
#line 1 "d_searchprescription\\d_searchprescription.cs"
#line hidden
namespace medicationcenter
{
    public partial class d_searchprescription
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[7];
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_patient_t) > 0)
            {
                yield return "patient_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_patient) > 0)
            {
                yield return "patient";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_medication_t) > 0)
            {
                yield return "medication_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_medication) > 0)
            {
                yield return "medication";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_b_1) > 0)
            {
                yield return "b_1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_search) > 0)
            {
                yield return "t_search";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_searchby) > 0)
            {
                yield return "searchby";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "patient_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_patient_t) > 0;
                case "patient":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_patient) > 0;
                case "medication_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_medication_t) > 0;
                case "medication":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_medication) > 0;
                case "b_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_b_1) > 0;
                case "t_search":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_search) > 0;
                case "searchby":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_searchby) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["patient_t"] = _Mobilize_References[0];
            refs["patient"] = _Mobilize_References[1];
            refs["medication_t"] = _Mobilize_References[2];
            refs["medication"] = _Mobilize_References[3];
            refs["b_1"] = _Mobilize_References[4];
            refs["t_search"] = _Mobilize_References[5];
            refs["searchby"] = _Mobilize_References[6];
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

            var ref_patient_t = (Mobilize.WebMap.Common.Core.IObservable)this.patient_t;
            if (ref_patient_t != null)
                yield return ref_patient_t;
            var ref_patient = (Mobilize.WebMap.Common.Core.IObservable)this.patient;
            if (ref_patient != null)
                yield return ref_patient;
            var ref_medication_t = (Mobilize.WebMap.Common.Core.IObservable)this.medication_t;
            if (ref_medication_t != null)
                yield return ref_medication_t;
            var ref_medication = (Mobilize.WebMap.Common.Core.IObservable)this.medication;
            if (ref_medication != null)
                yield return ref_medication;
            var ref_b_1 = (Mobilize.WebMap.Common.Core.IObservable)this.b_1;
            if (ref_b_1 != null)
                yield return ref_b_1;
            var ref_t_search = (Mobilize.WebMap.Common.Core.IObservable)this.t_search;
            if (ref_t_search != null)
                yield return ref_t_search;
            var ref_searchby = (Mobilize.WebMap.Common.Core.IObservable)this.searchby;
            if (ref_searchby != null)
                yield return ref_searchby;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_patient_t = (uint)1 << 0;
        const uint _Mobilize_Loaded_patient_t = (uint)1 << 0;
        const uint _Mobilize_Dirty_patient = (uint)1 << 1;
        const uint _Mobilize_Loaded_patient = (uint)1 << 1;
        const uint _Mobilize_Dirty_medication_t = (uint)1 << 2;
        const uint _Mobilize_Loaded_medication_t = (uint)1 << 2;
        const uint _Mobilize_Dirty_medication = (uint)1 << 3;
        const uint _Mobilize_Loaded_medication = (uint)1 << 3;
        const uint _Mobilize_Dirty_b_1 = (uint)1 << 4;
        const uint _Mobilize_Loaded_b_1 = (uint)1 << 4;
        const uint _Mobilize_Dirty_t_search = (uint)1 << 5;
        const uint _Mobilize_Loaded_t_search = (uint)1 << 5;
        const uint _Mobilize_Dirty_searchby = (uint)1 << 6;
        const uint _Mobilize_Loaded_searchby = (uint)1 << 6;
#line 7
    }
}