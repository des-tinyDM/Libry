namespace Libry.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConnectBooks : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO BookAuthors (AuthorId, BookId) VALUES (10, 5)");
            Sql("INSERT INTO BookAuthors (AuthorId, BookId) VALUES (10, 6)");
            Sql("INSERT INTO BookAuthors (AuthorId, BookId) VALUES (10, 7)");
            Sql("INSERT INTO BookAuthors (AuthorId, BookId) VALUES (11, 10)");
            Sql("INSERT INTO BookAuthors (AuthorId, BookId) VALUES (12, 8)");
            Sql("INSERT INTO BookAuthors (AuthorId, BookId) VALUES (12, 9)");
            Sql("INSERT INTO BookAuthors (AuthorId, BookId) VALUES (13, 11)");
            Sql("INSERT INTO BookAuthors (AuthorId, BookId) VALUES (13, 12)");
            Sql("INSERT INTO BookAuthors (AuthorId, BookId) VALUES (13, 13)");
            Sql("INSERT INTO BookAuthors (AuthorId, BookId) VALUES (13, 14)");
        }

        public override void Down()
        {
        }
    }
}
