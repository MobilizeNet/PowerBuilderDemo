#pragma warning disable
#line 1 "w_login\\w_login.cs"
#line hidden
namespace medicationcenter
{
    public partial class w_login : medicationcenter.w_loginbase, medicationcenter.Iw_login
    {
        public partial class cbx_admin_type
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
#line 126
        }
    }
}