#pragma warning disable
#line 1 "d_current_control_change\\d_current_control_change.cs"
#line hidden
namespace notifycurrentcontrol
{
    public partial class d_current_control_change
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[4];
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_name_t) > 0)
            {
                yield return "name_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__name) > 0)
            {
                yield return "_name";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_address) > 0)
            {
                yield return "address";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_address_t) > 0)
            {
                yield return "address_t";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "name_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_name_t) > 0;
                case "_name":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__name) > 0;
                case "address":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_address) > 0;
                case "address_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_address_t) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["name_t"] = _Mobilize_References[0];
            refs["_name"] = _Mobilize_References[1];
            refs["address"] = _Mobilize_References[2];
            refs["address_t"] = _Mobilize_References[3];
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

            var ref_name_t = (Mobilize.WebMap.Common.Core.IObservable)this.name_t;
            if (ref_name_t != null)
                yield return ref_name_t;
            var ref__name = (Mobilize.WebMap.Common.Core.IObservable)this._name;
            if (ref__name != null)
                yield return ref__name;
            var ref_address = (Mobilize.WebMap.Common.Core.IObservable)this.address;
            if (ref_address != null)
                yield return ref_address;
            var ref_address_t = (Mobilize.WebMap.Common.Core.IObservable)this.address_t;
            if (ref_address_t != null)
                yield return ref_address_t;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_name_t = (uint)1 << 0;
        const uint _Mobilize_Loaded_name_t = (uint)1 << 0;
        const uint _Mobilize_Dirty__name = (uint)1 << 1;
        const uint _Mobilize_Loaded__name = (uint)1 << 1;
        const uint _Mobilize_Dirty_address = (uint)1 << 2;
        const uint _Mobilize_Loaded_address = (uint)1 << 2;
        const uint _Mobilize_Dirty_address_t = (uint)1 << 3;
        const uint _Mobilize_Loaded_address_t = (uint)1 << 3;
#line 7
    }
}