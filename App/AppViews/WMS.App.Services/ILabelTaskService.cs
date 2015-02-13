using System.Collections.Generic;
using WMS.Model;

namespace WMS.App.Services
{
    public interface ILabelTaskService
    {
        List<LabelTask> GetAllLocalLabelTasks(string address);
        void UpdateLabelTask(LabelTask task);
    }
}