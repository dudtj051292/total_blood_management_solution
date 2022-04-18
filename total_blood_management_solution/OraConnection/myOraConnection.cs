using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace OraConnection
{
    public class myOraConnection
    {

        static OracleConnection conn = null;
        static public myOraConnection oracle = new myOraConnection();

        private  myOraConnection()
        {
            
        }
        public static OracleConnection getConnection()
        {
            if (conn == null)
            {

                // Add connect descriptors and net service names entries.
                OracleConfiguration.OracleDataSources.Add("orcl_high", "(description= (retry_count=20)(retry_delay=3)(address=(protocol=tcps)(port=1522)(host=adb.ap-seoul-1.oraclecloud.com))(connect_data=(service_name=g21d97f7712585e_orcl_high.adb.oraclecloud.com))(security=(ssl_server_cert_dn=\"CN = adb.ap - seoul - 1.oraclecloud.com, OU = Oracle ADB SEOUL, O = Oracle Corporation, L = Redwood City, ST = California, C = US\")))");

                // Set default statement cache size to be used by all connections.
                OracleConfiguration.StatementCacheSize = 25;

                // Disable self tuning by default.
                OracleConfiguration.SelfTuning = false;

                // Bind all parameters by name.
                OracleConfiguration.BindByName = true;

                // Set default timeout to 60 seconds.
                OracleConfiguration.CommandTimeout = 60;

                // Set default fetch size as 1 MB.
                OracleConfiguration.FetchSize = 1024 * 1024;
                conn = new OracleConnection("user id=PROJ_BLD; password=aldwlTkfkd1!; data source=orcl_high");
                conn.WalletLocation = @"C:\Users\dudtj\OneDrive\OracleCloud\Wallet_orcl";
            }
            return conn;
        }

        public static Boolean executeNonQuery( string sql)
        {
            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.BindByName = true;
            int i = cmd.ExecuteNonQuery();
            return i < 0 ? true : false;
        }

        public static DataTable execute(string sql)
        {
            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(sql, conn);
            DataTable dt = new DataTable();

            oracleDataAdapter = new OracleDataAdapter(sql, conn);
            oracleDataAdapter.Fill(dt);

            return dt;
        }

        public static void closeObj()
        {
            conn.Dispose();
            conn.Close();
        }


    }
}
