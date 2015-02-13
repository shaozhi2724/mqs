using System.Collections.Generic;

namespace WMS.App.Services
{
    public interface IRegulatoryCodeService
    {
        int ImportCodes(List<CodeViewModel> codes, string corpCode);

        List<ExportTicketViewModel> GenExportTickets();
        void UpdateCodesStatusToExported(List<string> codes);

        RegulatoryCodeStatisticViewMode GetStatistics();
    }

    public class RegulatoryCodeStatisticViewMode
    {
        public int TotalCount { get; set; }
        public int UsedCount { get; set; }

        public int ExportedCount { get; set; }

        public int UnUsedCount { get; set; }
    }
}