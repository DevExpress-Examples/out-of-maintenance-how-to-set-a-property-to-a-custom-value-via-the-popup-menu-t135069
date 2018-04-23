using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Markup;
using DevExpress.Mvvm.Native;

namespace pgrid_attribute {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }
    public class ItemInitializer : MarkupExtension, IInstanceInitializer {
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
        object IInstanceInitializer.CreateInstance(TypeInfo type) {
            return DateTime.Today;
        }
        IEnumerable<TypeInfo> IInstanceInitializer.Types {
            get {
                return new List<TypeInfo>() {
                        new TypeInfo(typeof(DateTime), "Today"),
                    };
            }
        }
    }
}