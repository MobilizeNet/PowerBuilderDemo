#pragma warning disable
#line 1 "str_patient\\str_patient.cs"
#line hidden
namespace models
{
    public sealed partial class str_patient
    {
#line hidden
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_firstname) > 0)
            {
                yield return "firstname";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lastname) > 0)
            {
                yield return "lastname";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_age) > 0)
            {
                yield return "age";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_iid) > 0)
            {
                yield return "iid";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "firstname":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_firstname) > 0;
                case "lastname":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lastname) > 0;
                case "age":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_age) > 0;
                case "iid":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_iid) > 0;
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
        const uint _Mobilize_Dirty_firstname = (uint)1 << 0;
        const uint _Mobilize_Dirty_lastname = (uint)1 << 1;
        const uint _Mobilize_Dirty_age = (uint)1 << 2;
        const uint _Mobilize_Dirty_iid = (uint)1 << 3;
#line 7
    }
}