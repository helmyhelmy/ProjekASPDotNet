using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace TrainingASPDotNet.PencapaianProgram
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            const string sql = @"
                INSERT INTO PencapaianProgram (KodProgram, TarikhProgram, BilanganHari, Lulus)
                VALUES (@KodProgram, @TarikhProgram, @BilanganHari, @Lulus)";

            //get connection string from web.config
            var connection = ConfigurationManager.ConnectionStrings["Database"].ToString();
            

            //buka connection
            using (var c = new SqlConnection(connection))
            {
                var pencapaianProgram = new Entities.PencapaianProgram
                {
                    KodProgram = KodProgram.Text,
                    TarikhProgram = DateTime.Parse(TarikhProgram.Text),
                    BilanganHari = int.Parse(BilanganHari.Text),
                    Lulus = Lulus.Checked                    
                };

                c.Execute(sql, pencapaianProgram);
            }

            Response.Redirect("List.aspx");
        }
    }
}