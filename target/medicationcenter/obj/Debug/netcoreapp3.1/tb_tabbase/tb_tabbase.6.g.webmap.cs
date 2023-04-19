#pragma warning disable
#line 1 "tb_tabbase\\tb_tabbase.cs"
#line hidden
namespace medicationcenter
{
    public partial class tb_tabbase
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[3];
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tabpage_add) > 0)
            {
                yield return "tabpage_add";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tabpage_remove) > 0)
            {
                yield return "tabpage_remove";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tabpage_search) > 0)
            {
                yield return "tabpage_search";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "tabpage_add":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tabpage_add) > 0;
                case "tabpage_remove":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tabpage_remove) > 0;
                case "tabpage_search":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_tabpage_search) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["tabpage_add"] = _Mobilize_References[0];
            refs["tabpage_remove"] = _Mobilize_References[1];
            refs["tabpage_search"] = _Mobilize_References[2];
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

            var ref_tabpage_add = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.tabpage_add);
            if (ref_tabpage_add != null)
                yield return ref_tabpage_add;
            var ref_tabpage_remove = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.tabpage_remove);
            if (ref_tabpage_remove != null)
                yield return ref_tabpage_remove;
            var ref_tabpage_search = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.tabpage_search);
            if (ref_tabpage_search != null)
                yield return ref_tabpage_search;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_tabpage_add = (uint)1 << 0;
        const uint _Mobilize_Loaded_tabpage_add = (uint)1 << 0;
        const uint _Mobilize_Dirty_tabpage_remove = (uint)1 << 1;
        const uint _Mobilize_Loaded_tabpage_remove = (uint)1 << 1;
        const uint _Mobilize_Dirty_tabpage_search = (uint)1 << 2;
        const uint _Mobilize_Loaded_tabpage_search = (uint)1 << 2;
#line 7
    }
}