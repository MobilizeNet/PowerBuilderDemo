#pragma warning disable
#line 1 "dw_product\\dw_product.cs"
#line hidden
namespace reports
{
    public partial class dw_product
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[11];
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__name) > 0)
            {
                yield return "_name";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_price) > 0)
            {
                yield return "price";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_vendor) > 0)
            {
                yield return "vendor";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_4) > 0)
            {
                yield return "t_4";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_3) > 0)
            {
                yield return "t_3";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_2) > 0)
            {
                yield return "t_2";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_1) > 0)
            {
                yield return "t_1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__id) > 0)
            {
                yield return "_id";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_compute_1) > 0)
            {
                yield return "compute_1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_compute_2) > 0)
            {
                yield return "compute_2";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_category) > 0)
            {
                yield return "category";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "_name":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__name) > 0;
                case "price":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_price) > 0;
                case "vendor":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_vendor) > 0;
                case "t_4":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_4) > 0;
                case "t_3":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_3) > 0;
                case "t_2":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_2) > 0;
                case "t_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_1) > 0;
                case "_id":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__id) > 0;
                case "compute_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_compute_1) > 0;
                case "compute_2":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_compute_2) > 0;
                case "category":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_category) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["_name"] = _Mobilize_References[0];
            refs["price"] = _Mobilize_References[1];
            refs["vendor"] = _Mobilize_References[2];
            refs["t_4"] = _Mobilize_References[3];
            refs["t_3"] = _Mobilize_References[4];
            refs["t_2"] = _Mobilize_References[5];
            refs["t_1"] = _Mobilize_References[6];
            refs["_id"] = _Mobilize_References[7];
            refs["compute_1"] = _Mobilize_References[8];
            refs["compute_2"] = _Mobilize_References[9];
            refs["category"] = _Mobilize_References[10];
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

            var ref__name = (Mobilize.WebMap.Common.Core.IObservable)this._name;
            if (ref__name != null)
                yield return ref__name;
            var ref_price = (Mobilize.WebMap.Common.Core.IObservable)this.price;
            if (ref_price != null)
                yield return ref_price;
            var ref_vendor = (Mobilize.WebMap.Common.Core.IObservable)this.vendor;
            if (ref_vendor != null)
                yield return ref_vendor;
            var ref_t_4 = (Mobilize.WebMap.Common.Core.IObservable)this.t_4;
            if (ref_t_4 != null)
                yield return ref_t_4;
            var ref_t_3 = (Mobilize.WebMap.Common.Core.IObservable)this.t_3;
            if (ref_t_3 != null)
                yield return ref_t_3;
            var ref_t_2 = (Mobilize.WebMap.Common.Core.IObservable)this.t_2;
            if (ref_t_2 != null)
                yield return ref_t_2;
            var ref_t_1 = (Mobilize.WebMap.Common.Core.IObservable)this.t_1;
            if (ref_t_1 != null)
                yield return ref_t_1;
            var ref__id = (Mobilize.WebMap.Common.Core.IObservable)this._id;
            if (ref__id != null)
                yield return ref__id;
            var ref_compute_1 = (Mobilize.WebMap.Common.Core.IObservable)this.compute_1;
            if (ref_compute_1 != null)
                yield return ref_compute_1;
            var ref_compute_2 = (Mobilize.WebMap.Common.Core.IObservable)this.compute_2;
            if (ref_compute_2 != null)
                yield return ref_compute_2;
            var ref_category = (Mobilize.WebMap.Common.Core.IObservable)this.category;
            if (ref_category != null)
                yield return ref_category;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty__name = (uint)1 << 0;
        const uint _Mobilize_Loaded__name = (uint)1 << 0;
        const uint _Mobilize_Dirty_price = (uint)1 << 1;
        const uint _Mobilize_Loaded_price = (uint)1 << 1;
        const uint _Mobilize_Dirty_vendor = (uint)1 << 2;
        const uint _Mobilize_Loaded_vendor = (uint)1 << 2;
        const uint _Mobilize_Dirty_t_4 = (uint)1 << 3;
        const uint _Mobilize_Loaded_t_4 = (uint)1 << 3;
        const uint _Mobilize_Dirty_t_3 = (uint)1 << 4;
        const uint _Mobilize_Loaded_t_3 = (uint)1 << 4;
        const uint _Mobilize_Dirty_t_2 = (uint)1 << 5;
        const uint _Mobilize_Loaded_t_2 = (uint)1 << 5;
        const uint _Mobilize_Dirty_t_1 = (uint)1 << 6;
        const uint _Mobilize_Loaded_t_1 = (uint)1 << 6;
        const uint _Mobilize_Dirty__id = (uint)1 << 7;
        const uint _Mobilize_Loaded__id = (uint)1 << 7;
        const uint _Mobilize_Dirty_compute_1 = (uint)1 << 8;
        const uint _Mobilize_Loaded_compute_1 = (uint)1 << 8;
        const uint _Mobilize_Dirty_compute_2 = (uint)1 << 9;
        const uint _Mobilize_Loaded_compute_2 = (uint)1 << 9;
        const uint _Mobilize_Dirty_category = (uint)1 << 10;
        const uint _Mobilize_Loaded_category = (uint)1 << 10;
#line 7
    }
}