using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class CommentsDB : IDatabase
    {
        public string MsgText { get; set; } = "";
        public string MsgCaption { get; set; } = "";

        public bool Upload(object obj, SqlConnection sqlConnection)
        {
            return true;
        }

        public bool Delete(object obj, SqlConnection sqlConnection)
        {
            return true;
        }
    }
}
