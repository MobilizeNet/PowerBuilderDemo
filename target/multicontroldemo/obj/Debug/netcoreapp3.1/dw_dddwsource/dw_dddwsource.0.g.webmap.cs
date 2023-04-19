#pragma warning disable
#line 1 "dw_dddwsource\\dw_dddwsource.cs"
#line hidden
namespace multicontroldemo
{
    public partial class dw_dddwsource
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

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_type_value_t) > 0)
            {
                yield return "type_value_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_type_name) > 0)
            {
                yield return "type_name";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_type_desc) > 0)
            {
                yield return "type_desc";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_type_value) > 0)
            {
                yield return "type_value";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "type_value_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_type_value_t) > 0;
                case "type_name":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_type_name) > 0;
                case "type_desc":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_type_desc) > 0;
                case "type_value":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_type_value) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["type_value_t"] = _Mobilize_References[0];
            refs["type_name"] = _Mobilize_References[1];
            refs["type_desc"] = _Mobilize_References[2];
            refs["type_value"] = _Mobilize_References[3];
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

            var ref_type_value_t = (Mobilize.WebMap.Common.Core.IObservable)this.type_value_t;
            if (ref_type_value_t != null)
                yield return ref_type_value_t;
            var ref_type_name = (Mobilize.WebMap.Common.Core.IObservable)this.type_name;
            if (ref_type_name != null)
                yield return ref_type_name;
            var ref_type_desc = (Mobilize.WebMap.Common.Core.IObservable)this.type_desc;
            if (ref_type_desc != null)
                yield return ref_type_desc;
            var ref_type_value = (Mobilize.WebMap.Common.Core.IObservable)this.type_value;
            if (ref_type_value != null)
                yield return ref_type_value;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_type_value_t = (uint)1 << 0;
        const uint _Mobilize_Loaded_type_value_t = (uint)1 << 0;
        const uint _Mobilize_Dirty_type_name = (uint)1 << 1;
        const uint _Mobilize_Loaded_type_name = (uint)1 << 1;
        const uint _Mobilize_Dirty_type_desc = (uint)1 << 2;
        const uint _Mobilize_Loaded_type_desc = (uint)1 << 2;
        const uint _Mobilize_Dirty_type_value = (uint)1 << 3;
        const uint _Mobilize_Loaded_type_value = (uint)1 << 3;
#line 7
    }
}