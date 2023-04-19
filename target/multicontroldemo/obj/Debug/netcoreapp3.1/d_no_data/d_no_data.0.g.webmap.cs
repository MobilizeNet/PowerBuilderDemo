#pragma warning disable
#line 1 "d_no_data\\d_no_data.cs"
#line hidden
namespace multicontroldemo
{
    public partial class d_no_data
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

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_field1_t) > 0)
            {
                yield return "field1_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_field1) > 0)
            {
                yield return "field1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_field2_t) > 0)
            {
                yield return "field2_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_field2) > 0)
            {
                yield return "field2";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_field3_t) > 0)
            {
                yield return "field3_t";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_field3) > 0)
            {
                yield return "field3";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "field1_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_field1_t) > 0;
                case "field1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_field1) > 0;
                case "field2_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_field2_t) > 0;
                case "field2":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_field2) > 0;
                case "field3_t":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_field3_t) > 0;
                case "field3":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_field3) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["field1_t"] = _Mobilize_References[0];
            refs["field1"] = _Mobilize_References[1];
            refs["field2_t"] = _Mobilize_References[2];
            refs["field2"] = _Mobilize_References[3];
            refs["field3_t"] = _Mobilize_References[4];
            refs["field3"] = _Mobilize_References[5];
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

            var ref_field1_t = (Mobilize.WebMap.Common.Core.IObservable)this.field1_t;
            if (ref_field1_t != null)
                yield return ref_field1_t;
            var ref_field1 = (Mobilize.WebMap.Common.Core.IObservable)this.field1;
            if (ref_field1 != null)
                yield return ref_field1;
            var ref_field2_t = (Mobilize.WebMap.Common.Core.IObservable)this.field2_t;
            if (ref_field2_t != null)
                yield return ref_field2_t;
            var ref_field2 = (Mobilize.WebMap.Common.Core.IObservable)this.field2;
            if (ref_field2 != null)
                yield return ref_field2;
            var ref_field3_t = (Mobilize.WebMap.Common.Core.IObservable)this.field3_t;
            if (ref_field3_t != null)
                yield return ref_field3_t;
            var ref_field3 = (Mobilize.WebMap.Common.Core.IObservable)this.field3;
            if (ref_field3 != null)
                yield return ref_field3;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_field1_t = (uint)1 << 0;
        const uint _Mobilize_Loaded_field1_t = (uint)1 << 0;
        const uint _Mobilize_Dirty_field1 = (uint)1 << 1;
        const uint _Mobilize_Loaded_field1 = (uint)1 << 1;
        const uint _Mobilize_Dirty_field2_t = (uint)1 << 2;
        const uint _Mobilize_Loaded_field2_t = (uint)1 << 2;
        const uint _Mobilize_Dirty_field2 = (uint)1 << 3;
        const uint _Mobilize_Loaded_field2 = (uint)1 << 3;
        const uint _Mobilize_Dirty_field3_t = (uint)1 << 4;
        const uint _Mobilize_Loaded_field3_t = (uint)1 << 4;
        const uint _Mobilize_Dirty_field3 = (uint)1 << 5;
        const uint _Mobilize_Loaded_field3 = (uint)1 << 5;
#line 7
    }
}