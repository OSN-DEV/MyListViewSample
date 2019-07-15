﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyListViewSample {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ListViewSample05 : Window {

        // ItemTemplate : ItemContainerStyle 
        // 項目単位での外観を設定。トリガーなどもこれで設定。

        public ListViewSample05() {
            InitializeComponent();

            this.cList.DataContext = new ListData().ListDataCollection;
        }
    }
}
