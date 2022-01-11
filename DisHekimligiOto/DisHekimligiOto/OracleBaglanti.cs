using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;



namespace DisHekimligiOto
{
   
    class OracleBaglanti
    {
      public OracleConnection orCon()
        {
            OracleConnection baglan = new OracleConnection("USER ID=SYSTEM;PASSWORD=123456789;DATA SOURCE=localhost:1521/XE");
            baglan.Open();
            return baglan;
        }
       //public OracleCommand komut = new OracleCommand();
        
    }
}
