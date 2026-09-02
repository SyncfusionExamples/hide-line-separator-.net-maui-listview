# How to hide the line separator with grouping in .NET MAUI ListView (SfListView) ?

In the [.NET MAUI ListView (SfListView)](https://www.syncfusion.com/maui-controls/maui-listview)<font face="Segoe UI"><span>,&nbsp;you can add a separator line to items with grouping enabled. To hide the separator line for the last item in a group, use a converter bound to the <em><strong>IsVisible </strong></em>property</span></font>

**Steps**
1. Define the [SfListView.ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTemplate) with a StackLayout having a HeightRequest as 1 to display the separator line. Utilize a converter to control the visibility of the separator for the last item in each group.
2. Get the group details of the item from the [DataSource.DisplayItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_Maui_DataSource_DataSource_DisplayItems) and get the group items from the [GroupResult.Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.Extensions.GroupResult.html#Syncfusion_Maui_DataSource_Extensions_GroupResult_Items) property. Returns false for the last item of the group and true for other items.

![Hide separator for the last item of a group in .NET MAUI ListView (SfListView)](https://www.syncfusion.com/uploads/user/kb/maui/maui-2121/maui-2121_img1.png)

Download the complete sample on [GitHub](https://github.com/SyncfusionExamples/hide-line-separator-.net-maui-listview)

**Conclusion**

I hope you enjoyed learning how to hide the line separator for the last item in groups within the .NET MAUI ListView.

You can refer to our [.NET MAUI ListView feature tour](https://www.syncfusion.com/maui-controls/maui-listview) page to learn about its other groundbreaking feature representations and [documentation](https://help.syncfusion.com/maui/listview/getting-started), and how to quickly get started with configuration specifications. Explore our [.NET MAUI ListView example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/ListView) to understand how to create and manipulate data.

For current customers, you can check out our components from the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion®, try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to check out our other controls.

Please let us know in the comments section below if you have any queries or require clarification. Contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create), or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sflistview). We are always happy to assist you!
