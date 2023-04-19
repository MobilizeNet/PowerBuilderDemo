#pragma warning disable
#line 1 "m_adminmdi\\m_adminmdi.cs"
#line hidden
namespace medicationcenter
{
    public partial class m_adminmdi : medicationcenter.m_basemdi, medicationcenter.Im_adminmdi
    {
        public partial class m_edit_type : medicationcenter.m_basemdi.m_edit_type, Im_adminmdiInner.Im_edit_type
        {
            public partial class m_save_type
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
#line 323
            }
        }
    }
}