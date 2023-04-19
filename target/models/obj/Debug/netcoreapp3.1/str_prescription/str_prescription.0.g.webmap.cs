#pragma warning disable
#line 1 "str_prescription\\str_prescription.cs"
#line hidden
namespace models
{
    public sealed partial class str_prescription
    {
#line hidden
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dose) > 0)
            {
                yield return "dose";
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

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_state) > 0)
            {
                yield return "state";
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
                case "dose":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dose) > 0;
                case "iid":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_iid) > 0;
                case "medicine":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_medicine) > 0;
                case "patient":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_patient) > 0;
                case "state":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_state) > 0;
                case "socialsecurity":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_socialsecurity) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            return refs;
        }

        protected override void _Mobilize_CleanChanges()
        {
            if (!((Mobilize.WebMap.Common.Core.ITrackable)this).IsNew || ((Mobilize.WebMap.Common.Core.IObservable)this).RefCount > 0)
            {
                this._Mobilize_DirtyFlag_0 = 0;
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

            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        const uint _Mobilize_Dirty_dose = (uint)1 << 0;
        const uint _Mobilize_Dirty_iid = (uint)1 << 1;
        const uint _Mobilize_Dirty_medicine = (uint)1 << 2;
        const uint _Mobilize_Dirty_patient = (uint)1 << 3;
        const uint _Mobilize_Dirty_state = (uint)1 << 4;
        const uint _Mobilize_Dirty_socialsecurity = (uint)1 << 5;
#line 7
    }
}