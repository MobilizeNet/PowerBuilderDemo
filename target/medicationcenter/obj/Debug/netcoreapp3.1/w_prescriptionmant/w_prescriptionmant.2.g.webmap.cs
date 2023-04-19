#pragma warning disable
#line 1 "w_prescriptionmant\\w_prescriptionmant.cs"
#line hidden
namespace medicationcenter
{
    public partial class w_prescriptionmant
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[1];
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_uo_1) > 0)
            {
                yield return "uo_1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dirtyadd) > 0)
            {
                yield return "dirtyadd";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dirtyremove) > 0)
            {
                yield return "dirtyremove";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "uo_1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_uo_1) > 0;
                case "dirtyadd":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dirtyadd) > 0;
                case "dirtyremove":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_dirtyremove) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["uo_1"] = _Mobilize_References[0];
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

            var ref_uo_1 = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.uo_1);
            if (ref_uo_1 != null)
                yield return ref_uo_1;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_uo_1 = (uint)1 << 0;
        const uint _Mobilize_Loaded_uo_1 = (uint)1 << 0;
        const uint _Mobilize_Dirty_dirtyadd = (uint)1 << 1;
        const uint _Mobilize_Dirty_dirtyremove = (uint)1 << 2;
#line 7
    }
}