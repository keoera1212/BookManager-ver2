using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;

namespace main
{
    class Data
    {
        static string con = @"server = DESKTOP-4868RC3\SQLEXPRESS; Integrated security=True; database = BookManager";

        //도서 추가 함수 MsDB에 접속하여 insert 구문을 쓴다.
        public static void Booksave(int Isbn, string Name, int Page, string Publisher)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"insert into Book(Book_idx, Isbn, Name, Page, Publisher)
                                values ((SELECT MAX(Book_idx)+1 FROM Book), @Isbn, @Name, @Page, @Publisher);";

            cmd.Parameters.Add(new SqlParameter("@isbn", SqlDbType.Int, 18));
            cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Page", SqlDbType.Int, 18));
            cmd.Parameters.Add(new SqlParameter("@Publisher", SqlDbType.VarChar, 50));

            cmd.Parameters["@isbn"].Value = Isbn;
            cmd.Parameters["@Name"].Value = Name;
            cmd.Parameters["@Page"].Value = Page;
            cmd.Parameters["@Publisher"].Value = Publisher;

            cmd.ExecuteNonQuery(); //위에서 지정한 퀴리문의 실행 DB프로그램의 F5번키 와 같다. 정수형 변수를 선언하면 
                                   //실행하며 영항받은 행의 갯수를 반환하여 변수에 저장한다 이 구문 앞에 int ex를 붙인다던가

            conn.Close();
        }

        //도서 삭제 함수 MsDB에 접속하여 delete 구문을 쓴다.
        public static void BookDelete(int Isbn, string Name, string Publisher, int Page)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"delete from Book
                              where Isbn = @Isbn and Name = @Name and PAge = @Page and Publisher = @Publisher;";

            cmd.Parameters.Add(new SqlParameter("@isbn", SqlDbType.Int, 18));
            cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Page", SqlDbType.Int, 18));
            cmd.Parameters.Add(new SqlParameter("@Publisher", SqlDbType.VarChar, 50));

            cmd.Parameters["@isbn"].Value = Isbn;
            cmd.Parameters["@Name"].Value = Name;
            cmd.Parameters["@Page"].Value = Page;
            cmd.Parameters["@Publisher"].Value = Publisher;

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //전체 도서수 라벨의 함수 MsDB에 접속하여 count함수 구문을 쓴다.
        public static string AllBooks()
        {
            string Books = "a";

            SqlConnection conn = new SqlConnection(con);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"SELECT COUNT(*) FROM Book";
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Books = reader[0].ToString();
            }

            conn.Close();

            return Books;
            
        }
        //전체 유저수 라벨의 함수 MsDB에 접속하여 count함수 구문을 쓴다.
        public static string Allusers()
        {
            string Users = "a";

            SqlConnection conn = new SqlConnection(con);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"SELECT COUNT(*) FROM Customer";
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Users = reader[0].ToString();
            }

            conn.Close();
            return Users;
        }

        //대여도서수 라벨의 함수 MsDB에 접속하여 count함수 구문을 쓴다.  
        public static string Borrowed()
        {
            string Borrowed = "a";

            SqlConnection conn = new SqlConnection(con);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"SELECT COUNT(isBorrowed) FROM Book
                                WHERE isBorrowed = 'true'";
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Borrowed = reader[0].ToString();
            }

            conn.Close();

            return Borrowed;
        }

        //연체도서수 라벨의 함수 MsDB에 접속하여 count함수 구문을 쓴다.
        public static string OverBorrowed()
        {
            string over = "a";

            SqlConnection conn = new SqlConnection(con);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"SELECT COUNT(BorrowedDt) FROM Book
                                WHERE isBorrowed = 'TRUE' AND SYSDATETIME() > DATEADD(D, 7, BorrowedDt);";
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                over = reader[0].ToString();
            }

            conn.Close();

            return over;
        }

        //반납버튼 함수 MsDB에 접속하여 update 구문을 쓴다.
        public static void ReturnBook(int Isbn, string Name, string User)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = @"UPDATE Book SET isBorrowed = 'false' , UserId = null , BorrowedDt = null , UserName = null
                                WHERE isbn = @isbn AND Name = @Name AND UserId = @User;";
            cmd.Parameters.Add(new SqlParameter("@isbn", SqlDbType.Int,18));
            cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@User", SqlDbType.VarChar, 50));

            cmd.Parameters["@isbn"].Value = Isbn;
            cmd.Parameters["@Name"].Value = Name;
            cmd.Parameters["@User"].Value = User;

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //대여버튼 함수 MsDB에 접속하여 update 구문을 쓴다.
        public static void BorrowedBook(int Isbn, string Name, String User)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"UPDATE Book SET isBorrowed = 'true', BorrowedDt = GetDate(), UserId = @User, UserName = b.Name
                                FROM Book as a, Customer as b
                                WHERE isbn = @isbn AND a.Name = @Name AND b.ID = @User";

            cmd.Parameters.Add(new SqlParameter("@isbn", SqlDbType.Int, 18));
            cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@User", SqlDbType.VarChar, 50));

            cmd.Parameters["@isbn"].Value = Isbn;
            cmd.Parameters["@Name"].Value = Name;
            cmd.Parameters["@User"].Value = User;

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //도서 수정버튼 함수 MsDB에 접속하여 update 구문을 쓴다.
        public static void UpdateBook(int Text, int Isbn, string Name, string Publisher, int Page)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"UPDATE Book SET Isbn = @isbn, Name = @Name, Publisher = @Publisher, Page = @Page
                                WHERE isbn = @Text;";

            cmd.Parameters.Add(new SqlParameter("@isbn", SqlDbType.Int, 18));
            cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Publisher", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Page", SqlDbType.Int, 18));
            cmd.Parameters.Add(new SqlParameter("@Text", SqlDbType.Int, 18));

            cmd.Parameters["@isbn"].Value = Isbn;
            cmd.Parameters["@Name"].Value = Name;
            cmd.Parameters["@Publisher"].Value = Publisher;
            cmd.Parameters["@Page"].Value = Page;
            cmd.Parameters["@Text"].Value = Text;

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //유저 추가 버튼 함수 MsDB에 접속하여 insert 구문을 쓴다.
        public static void AddUser(string Id, string Name)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"INSERT INTO Customer(User_idx, Id, Name)
                                VALUES((SELECT MAX(User_idx)+1 FROM Customer), @Id , @Name);";

            cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 50));

            cmd.Parameters["@Id"].Value = Id;
            cmd.Parameters["@Name"].Value = Name;

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //유저 수정버튼 함수 MsDB에 접속하여 update 구문을 쓴다.
        public static void UpdateUser(string Find, string Id, string Name)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"UPDATE Customer SET Id = @Id, Name = @Name
                                WHERE Id = @Find;";

            cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Find", SqlDbType.VarChar, 50));

            cmd.Parameters["@Id"].Value = Id;
            cmd.Parameters["@Name"].Value = Name;
            cmd.Parameters["@Find"].Value = Find;

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //유저삭제 버튼 함수 MsDB에 접속하여 delete 구문을 쓴다.
        public static void DeleteUser(string Id, string Name)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"DELETE FROM Customer
                                WHERE Id = @Id AND Name = @Name;";

            cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 50));

            cmd.Parameters["@Id"].Value = Id;
            cmd.Parameters["@Name"].Value = Name;

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
