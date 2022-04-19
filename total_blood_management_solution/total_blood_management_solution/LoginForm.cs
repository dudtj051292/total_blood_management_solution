using Oracle.ManagedDataAccess.Client;
using OraConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using total_blood_management_solution_Utils;

namespace total_blood_management_solution
{
    public partial class LoginForm : Form
    {
        public bool isLoggin { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OracleConnection conn = myOraConnection.getConnection();

            string id = bld_tID.Text;
            string pw = bld_tPW.Text;

            if (Utils.getObjectToString(id) == "")
            {
                MessageBox.Show("아이디를 입력해주세요.");
            }

            if (Utils.getObjectToString(pw) == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
            }

            string sql = 
                  " SELECT A.ST_ID, A.ST_PASSWORD, C.ST_ROLE          \n"
                + "   FROM BLD_USER A ,BLD_USERROLE B, BLD_ROLE C     \n"
                + "  WHERE A.ST_ID       = B.ST_ID                    \n"
                + "    AND B.ST_ROLE     = C.ST_ROLE                  \n"
                + "    AND A.ST_ID       = '" + id + "'               \n"
                ; 

            DataTable dt = OraConnection.myOraConnection.execute(sql);

            if(dt.Rows.Count ==0)
            {
                MessageBox.Show("아이디혹은 비밀번호가 틀립니다.");
                return;
            }
            else
            {
                String password = Utils.getObjectToString(dt.Rows[0]["ST_PASSWORD"]) ;
                if(Utils.passwordVerified(pw, password))
                {
                    //MAinForm 오픈
                    this.Close();
                    isLoggin = true;
                    
                     
                }
            }

        }

        private void bld_tID_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void bld_tPW_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void bld_tID_Validating(object sender, CancelEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            bld_tID.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode== Keys.Enter)
            {
                OracleConnection conn = new OracleConnection((sender as TextBox).Text);
            }
        }


        private void bld_tPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }

        }
    }
}
