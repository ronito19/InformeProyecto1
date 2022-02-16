using InformeProyecto.Services.DataSet.ProyectoDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformeProyecto.Services.DataSet
{
    class DataSetHandler
    {

        private static DepartamentoTableAdapter dptoAdapter = new DepartamentoTableAdapter();

        public static void insertaDpto(string nombreDpto)
        {
            dptoAdapter.Insert(nombreDpto);
        }


        private static InformeTableAdapter adapter = new InformeTableAdapter();

        public static DataTable GetByIdDpto(int idDpto)
        {
            return adapter.GetByIdDpto(idDpto);
        }


        public static DataTable GetDataByIdProyecto(int idProyecto)
        {
            return adapter.GetDataByIdProyecto(idProyecto);
        }


        public static DataTable GetDataByIdDptoIdPro(int idProyecto, int idDpto)
        {
            return adapter.GetDataByIdDptoIdPro(idProyecto, idDpto);
        }


        public static DataTable GetDataByFechaInicio(string fecha1, string fecha2)
        {
            return adapter.GetDataByFechaInicio(fecha1, fecha2);
        }
    }
}
