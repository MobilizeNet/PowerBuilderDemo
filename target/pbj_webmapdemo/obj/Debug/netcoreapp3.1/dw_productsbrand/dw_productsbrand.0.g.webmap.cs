#pragma warning disable
#line 1 "dw_productsbrand\\dw_productsbrand.cs"
#line hidden
namespace pbj_webmapdemo
{
    public partial class dw_productsbrand
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[6];
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

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_name_t) > 0)
            {
                yield return "name_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_brandid_t) > 0)
            {
                yield return "brandid_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__id) > 0)
            {
                yield return "_id";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__name) > 0)
            {
                yield return "_name";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_brandid) > 0)
            {
                yield return "brandid";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "id_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_id_t) > 0;
                case "name_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_name_t) > 0;
                case "brandid_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_brandid_t) > 0;
                case "_id":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__id) > 0;
                case "_name":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__name) > 0;
                case "brandid":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_brandid) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["id_t"] = _Mobilize_References[0];
            refs["name_t"] = _Mobilize_References[1];
            refs["brandid_t"] = _Mobilize_References[2];
            refs["_id"] = _Mobilize_References[3];
            refs["_name"] = _Mobilize_References[4];
            refs["brandid"] = _Mobilize_References[5];
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
            var ref_name_t = (Mobilize.WebMap.Common.Core.IObservable)this.name_t;
            if (ref_name_t != null)
                yield return ref_name_t;
            var ref_brandid_t = (Mobilize.WebMap.Common.Core.IObservable)this.brandid_t;
            if (ref_brandid_t != null)
                yield return ref_brandid_t;
            var ref__id = (Mobilize.WebMap.Common.Core.IObservable)this._id;
            if (ref__id != null)
                yield return ref__id;
            var ref__name = (Mobilize.WebMap.Common.Core.IObservable)this._name;
            if (ref__name != null)
                yield return ref__name;
            var ref_brandid = (Mobilize.WebMap.Common.Core.IObservable)this.brandid;
            if (ref_brandid != null)
                yield return ref_brandid;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_id_t = (uint)1 << 0;
        const uint _Mobilize_Loaded_id_t = (uint)1 << 0;
        const uint _Mobilize_Dirty_name_t = (uint)1 << 1;
        const uint _Mobilize_Loaded_name_t = (uint)1 << 1;
        const uint _Mobilize_Dirty_brandid_t = (uint)1 << 2;
        const uint _Mobilize_Loaded_brandid_t = (uint)1 << 2;
        const uint _Mobilize_Dirty__id = (uint)1 << 3;
        const uint _Mobilize_Loaded__id = (uint)1 << 3;
        const uint _Mobilize_Dirty__name = (uint)1 << 4;
        const uint _Mobilize_Loaded__name = (uint)1 << 4;
        const uint _Mobilize_Dirty_brandid = (uint)1 << 5;
        const uint _Mobilize_Loaded_brandid = (uint)1 << 5;
#line 7
    }
}