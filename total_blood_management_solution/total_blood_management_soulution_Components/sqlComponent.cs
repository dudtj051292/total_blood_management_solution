using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace total_blood_management_soulution_Components
{
    public class SqlComponent : Component
    {
        public class SqlData
        {
            public List<string> m_sqlList;
            public List<List<string>> m_sqlParam;

            public SqlData()
            {
                m_sqlList = new List<string>();
                m_sqlParam = new List<List<string>>();
            }

            public void Clear()
            {
                m_sqlList.Clear();
                m_sqlParam.Clear();
            }
        }



    }

}
