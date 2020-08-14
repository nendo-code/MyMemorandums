using System;
using System.Collections.Generic;
using System.Text;

namespace PrismApplicationSample.Model
{
    class ModelRepository : IModelRepository
    {
        private string statusStore = "Empty";
        public string GetStatus()
        {
            return statusStore;
        }

        public void SaveStatus( string status )
        {
            statusStore = status;// 実際にはここで永続化する。
        }
    }
}
