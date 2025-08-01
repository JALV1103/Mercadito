﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace Mercadito
{
    public class ExportarExcel
    {
        private XLWorkbook wb;

        public ExportarExcel()
        {
            this.wb = new XLWorkbook();
        }

        public void ExportarListaAExcel<T>(IEnumerable<T> listaExportar, string archivoAGuardar)
        {
            IXLWorksheet xLWorksheet = this.wb.AddWorksheet();
            xLWorksheet.Cell("A1").Value = "Exportando Listado";
            xLWorksheet.Cell("A2").InsertData(listaExportar);
            wb.SaveAs(archivoAGuardar);
        }
    }
}
