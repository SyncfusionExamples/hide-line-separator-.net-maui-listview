using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Syncfusion.Maui.ListView.Helpers;
using Syncfusion.Maui.DataSource;
using Syncfusion.Maui.ListView;
using Syncfusion.Maui.DataSource.Extensions;
using System.Globalization;

namespace ListViewMaui
{
    #region SeparatorVisibilityConverter
    public class SeparatorVisibilityConverter : IValueConverter
    {
        #region Fields

        SfListView ListView;
        #endregion

        #region Converters
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ListView = parameter as SfListView;

            if (value == null || ListView.DataSource.Groups.Count == 0)
                return false;

            var groupresult = GetGroup(value);
            var list = groupresult.Items.ToList<object>().ToList();
            var item = list[list.Count - 1] as ListViewContactInfo;
            
            return item != value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Private methods
        private GroupResult GetGroup(object itemData)
        {
            var item = itemData as ListViewContactInfo;
            return ListView.DataSource.DisplayItems.FirstOrDefault(x => (x is GroupResult group) && group.Key.ToString() == item.ContactName[0].ToString()) as GroupResult;
        }
        #endregion
    }
    #endregion
}
