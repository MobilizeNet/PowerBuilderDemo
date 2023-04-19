#pragma warning disable
#line 1 "d_removeprescription\\d_removeprescription.cs"
#line hidden
namespace medicationcenter
{
    public partial class d_removeprescription
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

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_l_1) > 0)
            {
                yield return "l_1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_1) > 0)
            {
                yield return "t_1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_id_t) > 0)
            {
                yield return "id_t";
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
                case "l_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_l_1) > 0;
                case "t_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_t_1) > 0;
                case "id_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_id_t) > 0;
                case "iid":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_iid) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["l_1"] = _Mobilize_References[0];
            refs["t_1"] = _Mobilize_References[1];
            refs["id_t"] = _Mobilize_References[2];
            refs["iid"] = _Mobilize_References[3];
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

            var ref_l_1 = (Mobilize.WebMap.Common.Core.IObservable)this.l_1;
            if (ref_l_1 != null)
                yield return ref_l_1;
            var ref_t_1 = (Mobilize.WebMap.Common.Core.IObservable)this.t_1;
            if (ref_t_1 != null)
                yield return ref_t_1;
            var ref_id_t = (Mobilize.WebMap.Common.Core.IObservable)this.id_t;
            if (ref_id_t != null)
                yield return ref_id_t;
            var ref_iid = (Mobilize.WebMap.Common.Core.IObservable)this.iid;
            if (ref_iid != null)
                yield return ref_iid;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_l_1 = (uint)1 << 0;
        const uint _Mobilize_Loaded_l_1 = (uint)1 << 0;
        const uint _Mobilize_Dirty_t_1 = (uint)1 << 1;
        const uint _Mobilize_Loaded_t_1 = (uint)1 << 1;
        const uint _Mobilize_Dirty_id_t = (uint)1 << 2;
        const uint _Mobilize_Loaded_id_t = (uint)1 << 2;
        const uint _Mobilize_Dirty_iid = (uint)1 << 3;
        const uint _Mobilize_Loaded_iid = (uint)1 << 3;
#line 7
    }
}