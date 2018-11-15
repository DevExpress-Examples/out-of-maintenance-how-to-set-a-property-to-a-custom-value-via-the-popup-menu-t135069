<!-- default file list -->
*Files to look at*:

* [Data.cs](./CS/pgrid_attribute/Data.cs) (VB: [Data.vb](./VB/pgrid_attribute/Data.vb))
* **[MainWindow.xaml](./CS/pgrid_attribute/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/pgrid_attribute/MainWindow.xaml.vb))**
* [MainWindow.xaml.cs](./CS/pgrid_attribute/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/pgrid_attribute/MainWindow.xaml.vb))
<!-- default file list end -->
# How to: Set a Property to a Custom Value via the Popup Menu


<p>The PropertyGridControl provides an easy way to add custom items that will set the underlying property to the <a href="https://documentation.devexpress.com/#WPF/CustomDocument15631">Property Menu</a>. This can be done on different levels.<br>1. To implement this functionality at the View level, use the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyDefinitionBase_InstanceInitializertopic">PropertyDefinitionBase.InstanceInitializer</a> property; it can be set to an object that implements the <strong>DevExpress.Mvvm.Native.IInstanceInitializer</strong> interface.<br>2. At the ViewModel/Model level, use the <strong>InstanceInitializerAttribute</strong>. In this attribute, you can specify the type of the value the underlying property will be set to.</p>

<br/>


