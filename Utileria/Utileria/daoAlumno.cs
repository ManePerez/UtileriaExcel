using System;
using System.Collections.Generic;
using System.IO.Compression;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Utileria
{
   class daoAlumno
    {
        public Boolean descomprimir(String ruta, String nombre) {
            try {
                String path = @""+ruta;
                String pathZip = @""+ruta +"\\"+ nombre + ".zip";
                              
                ZipFile.ExtractToDirectory(pathZip, path);
                return true;
            }
            catch (Exception e) {
                return false;
            }            
        }        

        public List<Alumno> EstatusUno(List<Alumno> alumnosA)
        {
            List<Alumno> ls = new List<Alumno>();
            for (int i = 0; i < alumnosA.Count; i++) {
                if (alumnosA[i].Estatus == 1) {
                    ls.Add(alumnosA[i]);
                }
            }            
            return ls;
        }

        public List<Alumno> EstatusDos(List<Alumno> alumnosA)
        {
            List<Alumno> ls = new List<Alumno>();
            for (int i = 0; i < alumnosA.Count; i++){
                if (alumnosA[i].Estatus == 2){
                    ls.Add(alumnosA[i]);
                }
            }
            return ls;
        }

        public List<Alumno> EstatusDiferenteUno(List<Alumno> alumnosA)
        {
            List<Alumno> ls = new List<Alumno>();
            for (int i = 0; i < alumnosA.Count; i++)
            {
                if (alumnosA[i].Estatus != 1 & alumnosA[i].Archivo!=null)
                {
                    ls.Add(alumnosA[i]);
                }
            }
            return ls;
        }
        public List<Alumno> LeerArchivo(String ruta, String nombre)
        {
            String path = @"" + ruta + "/" + nombre + ".xls";
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            List<Alumno> la = new List<Alumno>();
            Alumno na;
            int irow = 2;
            while (irow <= rowCount)
            {
                na = new Alumno();
                na.Archivo = xlRange.Cells[irow, 1].Value2.ToString();
                na.Estatus = Convert.ToInt32(xlRange.Cells[irow, 2].Value2);
                na.Descripcion = xlRange.Cells[irow, 3].Value2.ToString();
                na.FolioControl = xlRange.Cells[irow, 4].Value2.ToString();
                la.Add(na);
                irow++;
            }

            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);            
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            return la;
        }    
    }
}
