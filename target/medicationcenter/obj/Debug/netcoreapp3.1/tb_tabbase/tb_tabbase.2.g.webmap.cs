#pragma warning disable
#line 1 "tb_tabbase\\tb_tabbase.cs"
#line hidden
namespace medicationcenter
{
    public partial class tb_tabbase : Mobilize.Web.Tab, medicationcenter.Itb_tabbase
    {
        public partial class tabpage_remove_type : Mobilize.Web.UserObject, Itb_tabbaseInner.Itabpage_remove_type
        {
            public partial class dw_remove_type
            {
#line hidden
                protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
                {
                    foreach (var item in base._Mobilize_GetChanges())
                    {
                        yield return item;
                    }

                    yield break;
                }

                protected override bool _Mobilize_HasChanges(string propertyName)
                {
                    return base._Mobilize_HasChanges(propertyName);
                }

                protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
                {
                    base._Mobilize_GetReferenceMap(refs);
                    return refs;
                }

                protected override void _Mobilize_CleanChanges()
                {
                    if (!((Mobilize.WebMap.Common.Core.ITrackable)this).IsNew || ((Mobilize.WebMap.Common.Core.IObservable)this).RefCount > 0)
                    {
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

                    yield break;
                }
#line 239
            }
        }
    }
}