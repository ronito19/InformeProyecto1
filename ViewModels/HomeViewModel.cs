using InformeProyecto.Services.DataSet;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformeProyecto.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public string pdfData { set; get; }

        ReportViewer myReport { set; get; }

        ReportDataSource rds { set; get; }

        //public int idDpto;

        public HomeViewModel()
        {
            myReport = new ReportViewer();
            rds = new ReportDataSource();
            
        }


        public void GenerarInforme(int idDpto)
        {
            rds.Name = "DataSet2";
            rds.Value = DataSetHandler.GetByIdDpto(idDpto);
            myReport.LocalReport.DataSources.Add(rds);
            myReport.LocalReport.ReportPath = "../../Reporting/InformeDpto.rdlc";
            byte[] PDFBytes = myReport.LocalReport.Render(format: "PDF", deviceInfo: "");
            pdfData = "data:application/pdf;base64," + Convert.ToBase64String(PDFBytes);
        }



        public void GenerarInformeFechas(string fecha1, string fecha2)
        {
            rds.Name = "InformeFechas";
            rds.Value = DataSetHandler.GetDataByFechaInicio(fecha1, fecha2);
            myReport.LocalReport.DataSources.Add(rds);
            myReport.LocalReport.ReportPath = "../../Reporting/InformeFechas.rdlc";
            byte[] PDFBytes = myReport.LocalReport.Render(format: "PDF", deviceInfo: "");
            pdfData = "data:application/pdf;base64," + Convert.ToBase64String(PDFBytes);
        }


    }
    }

