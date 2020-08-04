using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vektorel.DAL;

namespace OkulApp.Models
{
            public class Classroom
        {
            public int ClassroomId { get; set; }
            public string ClassroomName { get; set; }
            public int Capacity { get; set; }
        
        }
    
}
