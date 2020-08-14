using System;
using System.Collections.Generic;
using System.Text;

namespace PrismApplicationSample.Model
{
    public interface IModelRepository
    {
        string GetStatus();
        void SaveStatus(string status);
    }
}
