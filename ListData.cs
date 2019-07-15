using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListViewSample {
    internal class ListData {
        // http://grabacr.net/archives/1240
        internal class ListDataModel {
            public string DisplayText { set; get; }
            internal ListDataModel(string displayText) {
                this.DisplayText = displayText;
            }
        }

        private ObservableCollection<ListDataModel> _listData = new ObservableCollection<ListDataModel>();
        public ObservableCollection<ListDataModel> ListDataCollection { get { return this._listData; } }


        internal ListData() {
            this._listData.Add(new ListDataModel("AAAAA"));
            this._listData.Add(new ListDataModel("BBBBB"));
            this._listData.Add(new ListDataModel("CCCCC"));
            this._listData.Add(new ListDataModel("DDDDD"));
            this._listData.Add(new ListDataModel("EEEEE"));
        }
    }
}
