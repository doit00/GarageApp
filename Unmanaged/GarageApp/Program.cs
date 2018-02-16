using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace GarageApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //EPPlus (excel lib)

            DocX report = DocX.Create("Report.docx", DocumentTypes.Document);

            
            var paragraph = report.InsertParagraph("YoY Value Report",false,
                new Formatting() { Bold = true });
            
            report.InsertParagraph();
            report.InsertParagraph();

            var table = report.InsertTable(2, 3);
            table.Rows[0].Cells[0].InsertParagraph("Year");
            table.Rows[0].Cells[1].InsertParagraph("Value");
            table.Rows[0].Cells[2].InsertParagraph("Remarks");

            table.Design = TableDesign.ColorfulList;
            
            report.Save();
            report.Dispose();
            
            
        
        }
    }
}
