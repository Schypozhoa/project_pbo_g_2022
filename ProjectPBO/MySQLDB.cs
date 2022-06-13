using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPBO
{
    public class MySQLDB
    {
        public string argument = "server=localhost; userid=root; password=; database=project_pbo";

        public string getArg()
        {
            return argument;
        }
    }
}
