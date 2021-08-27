<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655226/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T135069)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Data.cs](./CS/pgrid_attribute/Data.cs) (VB: [Data.vb](./VB/pgrid_attribute/Data.vb))
* **[MainWindow.xaml](./CS/pgrid_attribute/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/pgrid_attribute/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/pgrid_attribute/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/pgrid_attribute/MainWindow.xaml.vb))
<!-- default file list end -->
# How to: Set a Property to a Custom Value via the Popup Menu


<p>The PropertyGridControl provides an easy way to add custom items that will set the underlying property to the <a href="https://documentation.devexpress.com/#WPF/CustomDocument15631">Property Menu</a>. This can be done on different levels.<br>1. To implement this functionality at the View level, use the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyDefinitionBase_InstanceInitializertopic">PropertyDefinitionBase.InstanceInitializer</a> property; it can be set to an object that implements the <strong>DevExpress.Mvvm.Native.IInstanceInitializer</strong> interface.<br>2. At the ViewModel/Model level, use the <strong>InstanceInitializerAttribute</strong>. In this attribute, you can specify the type of the value the underlying property will be set to.</p>

<br/>


