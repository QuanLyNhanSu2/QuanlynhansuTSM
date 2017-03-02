using Quanlynhansu.Model;
using Quanlynhansu.Helper;

namespace Quanlynhansu.Controller
{
    class UserController
    {
        public ErrType Login(User user)
        {
            // return DataAccess.Query("Login", new SqlParameter("Username", user.Username), new SqlParameter("Username", user.Username)) != null;
            return ErrType.thanhcong;
        }
        
        public ErrType ThemNguoidung(User user)
        {
            //DataAccess.Query("Register",
            //            new SqlParameter("Username", user.Username),
            //            new SqlParameter("Password", user.Password)
            //    );
            return ErrType.thanhcong;
        }
        public ErrType SuaNguoidung(User user)
        {
            return ErrType.thanhcong;
        }

        public ErrType XoaNguoidung(int id)
        {
            return ErrType.thanhcong;
        }

        public ErrType SuaMatkhau(User user)
        {
            return ErrType.thanhcong;
        }
    }
}