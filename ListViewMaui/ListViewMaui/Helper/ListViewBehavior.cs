using Syncfusion.Maui.DataSource;
using Syncfusion.Maui.ListView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
    #region ListViewBehavior
    public class ListViewBehavior : Behavior<SfListView>
    {
        #region Fields
        private SfListView ListView;

        #endregion

        #region Overrides

        protected override void OnAttachedTo(SfListView bindable)
        {
            ListView = bindable;
            ListView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
            {
                PropertyName = "ContactName",
                KeySelector = (object obj1) =>
                {
                    var item = (obj1 as ListViewContactInfo);
                    return item.ContactName[0].ToString();
                },
            });

            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(SfListView bindable)
        {
            ListView = null;
            base.OnDetachingFrom(bindable);
        }
        #endregion
    }
    #endregion
}
