#pragma warning disable
#line 1 "d_users\\d_users.cs"
#line hidden
namespace notifycurrentcontrol
{
    public partial class d_users
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

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__id) > 0)
            {
                yield return "_id";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_name_t) > 0)
            {
                yield return "name_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__name) > 0)
            {
                yield return "_name";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_street_t) > 0)
            {
                yield return "street_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_street) > 0)
            {
                yield return "street";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_state_t) > 0)
            {
                yield return "state_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_state) > 0)
            {
                yield return "state";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_address_t) > 0)
            {
                yield return "address_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_address) > 0)
            {
                yield return "address";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_company_t) > 0)
            {
                yield return "company_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_company) > 0)
            {
                yield return "company";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "id_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_id_t) > 0;
                case "_id":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__id) > 0;
                case "name_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_name_t) > 0;
                case "_name":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__name) > 0;
                case "street_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_street_t) > 0;
                case "street":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_street) > 0;
                case "state_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_state_t) > 0;
                case "state":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_state) > 0;
                case "address_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_address_t) > 0;
                case "address":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_address) > 0;
                case "company_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_company_t) > 0;
                case "company":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_company) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["id_t"] = _Mobilize_References[0];
            refs["_id"] = _Mobilize_References[1];
            refs["name_t"] = _Mobilize_References[2];
            refs["_name"] = _Mobilize_References[3];
            refs["street_t"] = _Mobilize_References[4];
            refs["street"] = _Mobilize_References[5];
            refs["state_t"] = _Mobilize_References[6];
            refs["state"] = _Mobilize_References[7];
            refs["address_t"] = _Mobilize_References[8];
            refs["address"] = _Mobilize_References[9];
            refs["company_t"] = _Mobilize_References[10];
            refs["company"] = _Mobilize_References[11];
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
            var ref__id = (Mobilize.WebMap.Common.Core.IObservable)this._id;
            if (ref__id != null)
                yield return ref__id;
            var ref_name_t = (Mobilize.WebMap.Common.Core.IObservable)this.name_t;
            if (ref_name_t != null)
                yield return ref_name_t;
            var ref__name = (Mobilize.WebMap.Common.Core.IObservable)this._name;
            if (ref__name != null)
                yield return ref__name;
            var ref_street_t = (Mobilize.WebMap.Common.Core.IObservable)this.street_t;
            if (ref_street_t != null)
                yield return ref_street_t;
            var ref_street = (Mobilize.WebMap.Common.Core.IObservable)this.street;
            if (ref_street != null)
                yield return ref_street;
            var ref_state_t = (Mobilize.WebMap.Common.Core.IObservable)this.state_t;
            if (ref_state_t != null)
                yield return ref_state_t;
            var ref_state = (Mobilize.WebMap.Common.Core.IObservable)this.state;
            if (ref_state != null)
                yield return ref_state;
            var ref_address_t = (Mobilize.WebMap.Common.Core.IObservable)this.address_t;
            if (ref_address_t != null)
                yield return ref_address_t;
            var ref_address = (Mobilize.WebMap.Common.Core.IObservable)this.address;
            if (ref_address != null)
                yield return ref_address;
            var ref_company_t = (Mobilize.WebMap.Common.Core.IObservable)this.company_t;
            if (ref_company_t != null)
                yield return ref_company_t;
            var ref_company = (Mobilize.WebMap.Common.Core.IObservable)this.company;
            if (ref_company != null)
                yield return ref_company;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_id_t = (uint)1 << 0;
        const uint _Mobilize_Loaded_id_t = (uint)1 << 0;
        const uint _Mobilize_Dirty__id = (uint)1 << 1;
        const uint _Mobilize_Loaded__id = (uint)1 << 1;
        const uint _Mobilize_Dirty_name_t = (uint)1 << 2;
        const uint _Mobilize_Loaded_name_t = (uint)1 << 2;
        const uint _Mobilize_Dirty__name = (uint)1 << 3;
        const uint _Mobilize_Loaded__name = (uint)1 << 3;
        const uint _Mobilize_Dirty_street_t = (uint)1 << 4;
        const uint _Mobilize_Loaded_street_t = (uint)1 << 4;
        const uint _Mobilize_Dirty_street = (uint)1 << 5;
        const uint _Mobilize_Loaded_street = (uint)1 << 5;
        const uint _Mobilize_Dirty_state_t = (uint)1 << 6;
        const uint _Mobilize_Loaded_state_t = (uint)1 << 6;
        const uint _Mobilize_Dirty_state = (uint)1 << 7;
        const uint _Mobilize_Loaded_state = (uint)1 << 7;
        const uint _Mobilize_Dirty_address_t = (uint)1 << 8;
        const uint _Mobilize_Loaded_address_t = (uint)1 << 8;
        const uint _Mobilize_Dirty_address = (uint)1 << 9;
        const uint _Mobilize_Loaded_address = (uint)1 << 9;
        const uint _Mobilize_Dirty_company_t = (uint)1 << 10;
        const uint _Mobilize_Loaded_company_t = (uint)1 << 10;
        const uint _Mobilize_Dirty_company = (uint)1 << 11;
        const uint _Mobilize_Loaded_company = (uint)1 << 11;
#line 7
    }
}