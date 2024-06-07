using SistemaGestionData;

namespace SistemaGestionBussiness
{
    public class TablasBussiness
    {
        public static List<string> GetTablas()
        {
            return TablasData.GetTablas();
        }

    }
}
