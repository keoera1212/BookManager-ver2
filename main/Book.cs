using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Book
    {
        public string Isbn { get; set; } //Isbn = 국제표준도서번호
        public string Name { get; set; }
        public string Publisher { get; set; } //출판인 출판사
        public int Page { get; set; }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool isBorrowed { get; set; } //빌렸는지 여부
        public DateTime BorrowedAt { get; set; }
    }
}
