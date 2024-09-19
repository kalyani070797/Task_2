using Task_2.Model.Response;

namespace Task_2.Core.Dashboards.Interface
{
    public interface IDashboardCommon
    {
        DashboardResponseModel GetDashboard(int year);
    }
}