**[View document in Syncfusion .NET MAUI Knowledge Base](https://www.syncfusion.com/kb/13443/how-to-hide-the-line-separator-with-grouping-in-net-maui-listview-sflistview)**

## Sample

```xaml
<ContentPage.Resources>
    <ResourceDictionary>
        <local:SeparatorVisibilityConverter x:Key="VisibilityConverter"/>
    </ResourceDictionary>
</ContentPage.Resources>

<ListView:SfListView x:Name="listView"
                        ItemSize="70" 
                        GroupHeaderSize="50"
                        SelectionMode="Single"
                        IsStickyGroupHeader="True"
                        ItemsSource="{Binding ContactsInfo}"
                        AllowGroupExpandCollapse="True">

    <ListView:SfListView.GroupHeaderTemplate>
        <DataTemplate>
            <StackLayout BackgroundColor="#E4E4E4">
                <Label Text="{Binding Key}" FontSize="20" FontAttributes="Bold" TextColor="#4d4d4d" Padding="10,0,0,0" VerticalOptions="Center" HorizontalOptions="Start"/>
            </StackLayout>
        </DataTemplate>
    </ListView:SfListView.GroupHeaderTemplate>
    
    <ListView:SfListView.ItemTemplate>
        <DataTemplate>
            <code>
            . . .
            . . .
            <code>
        </DataTemplate>
    </ListView:SfListView.ItemTemplate>
</ListView:SfListView>

C#:

ListView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
{
    PropertyName = "ContactName",
    KeySelector = (object obj1) =>
    {
        var item = (obj1 as ListViewContactInfo);
        return item.ContactName[0].ToString();
    },
});

public class SeparatorVisibilityConverter : IValueConverter
{

    SfListView ListView;
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

    private GroupResult GetGroup(object itemData)
    {
        var item = itemData as ListViewContactInfo;
        return ListView.DataSource.DisplayItems.FirstOrDefault(x => (x is GroupResult group) && group.Key.ToString() == item.ContactName[0].ToString()) as GroupResult;
    }
}
```
