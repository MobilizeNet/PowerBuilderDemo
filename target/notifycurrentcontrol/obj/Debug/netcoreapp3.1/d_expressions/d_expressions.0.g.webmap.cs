#pragma warning disable
#line 1 "d_expressions\\d_expressions.cs"
#line hidden
namespace notifycurrentcontrol
{
    public partial class d_expressions
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[8];
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

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_street_t) > 0)
            {
                yield return "street_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_1) > 0)
            {
                yield return "t_1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__id) > 0)
            {
                yield return "_id";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_street) > 0)
            {
                yield return "street";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_compute_1) > 0)
            {
                yield return "compute_1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_compute_2) > 0)
            {
                yield return "compute_2";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_2) > 0)
            {
                yield return "t_2";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "id_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_id_t) > 0;
                case "street_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_street_t) > 0;
                case "t_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_1) > 0;
                case "_id":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty__id) > 0;
                case "street":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_street) > 0;
                case "compute_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_compute_1) > 0;
                case "compute_2":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_compute_2) > 0;
                case "t_2":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_2) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["id_t"] = _Mobilize_References[0];
            refs["street_t"] = _Mobilize_References[1];
            refs["t_1"] = _Mobilize_References[2];
            refs["_id"] = _Mobilize_References[3];
            refs["street"] = _Mobilize_References[4];
            refs["compute_1"] = _Mobilize_References[5];
            refs["compute_2"] = _Mobilize_References[6];
            refs["t_2"] = _Mobilize_References[7];
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
            var ref_street_t = (Mobilize.WebMap.Common.Core.IObservable)this.street_t;
            if (ref_street_t != null)
                yield return ref_street_t;
            var ref_t_1 = (Mobilize.WebMap.Common.Core.IObservable)this.t_1;
            if (ref_t_1 != null)
                yield return ref_t_1;
            var ref__id = (Mobilize.WebMap.Common.Core.IObservable)this._id;
            if (ref__id != null)
                yield return ref__id;
            var ref_street = (Mobilize.WebMap.Common.Core.IObservable)this.street;
            if (ref_street != null)
                yield return ref_street;
            var ref_compute_1 = (Mobilize.WebMap.Common.Core.IObservable)this.compute_1;
            if (ref_compute_1 != null)
                yield return ref_compute_1;
            var ref_compute_2 = (Mobilize.WebMap.Common.Core.IObservable)this.compute_2;
            if (ref_compute_2 != null)
                yield return ref_compute_2;
            var ref_t_2 = (Mobilize.WebMap.Common.Core.IObservable)this.t_2;
            if (ref_t_2 != null)
                yield return ref_t_2;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_id_t = (uint)1 << 0;
        const uint _Mobilize_Loaded_id_t = (uint)1 << 0;
        const uint _Mobilize_Dirty_street_t = (uint)1 << 1;
        const uint _Mobilize_Loaded_street_t = (uint)1 << 1;
        const uint _Mobilize_Dirty_t_1 = (uint)1 << 2;
        const uint _Mobilize_Loaded_t_1 = (uint)1 << 2;
        const uint _Mobilize_Dirty__id = (uint)1 << 3;
        const uint _Mobilize_Loaded__id = (uint)1 << 3;
        const uint _Mobilize_Dirty_street = (uint)1 << 4;
        const uint _Mobilize_Loaded_street = (uint)1 << 4;
        const uint _Mobilize_Dirty_compute_1 = (uint)1 << 5;
        const uint _Mobilize_Loaded_compute_1 = (uint)1 << 5;
        const uint _Mobilize_Dirty_compute_2 = (uint)1 << 6;
        const uint _Mobilize_Loaded_compute_2 = (uint)1 << 6;
        const uint _Mobilize_Dirty_t_2 = (uint)1 << 7;
        const uint _Mobilize_Loaded_t_2 = (uint)1 << 7;
#line 7
    }
}