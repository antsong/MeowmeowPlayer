using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCartWin
{
    public class Member
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        public string UserName { get; set; }

        public string PassWord{ get; set; }

        public string LoginState { get; set; }

        public string CartSate { get; set; }

        public bool IsSel { get; set; }

    }
}
