namespace Libry.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedBooksAndAuthorsTables : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Authors (FirstName, LastName, Phone, Email) VALUES ('John', 'Steinbeck', '1234567890', 'john@theworld.com')");
            Sql("INSERT INTO Authors (FirstName, LastName, Phone, Email) VALUES ('John', 'Irving', '2207855800', 'lurving@irving.com')");
            Sql("INSERT INTO Authors (FirstName, LastName, Phone, Email) VALUES ('Ursula', 'LeGuin', '221432353', 'lefthand@anthropofic.com')");
            Sql("INSERT INTO Authors (FirstName, LastName, Phone, Email) VALUES ('Madeleine', 'LEngle', '2342352522', 'manywaters@wrinkle.time')");


            Sql("INSERT INTO Books (Title, Genre) VALUES ('East of Eden', 'Nove | Romance | Fiction | Film Criticism')");
            Sql("INSERT INTO Books (Title, Genre) VALUES ('Grapes of Wrath', 'Fiction | Prose | Poetry')");
            Sql("INSERT INTO Books (Title, Genre) VALUES ('Of Mice and Men', 'Poetry | Fiction | Tragedy')");
            Sql("INSERT INTO Books (Title, Genre) VALUES ('The Left Hand of Darkness', 'Science Fiction | Fantasy | Anthropological Fiction')");
            Sql("INSERT INTO Books (Title, Genre) VALUES ('A Wizard of Earthsea', 'Fantasy | Fiction')");
            Sql("INSERT INTO Books (Title, Genre) VALUES ('The World According to Garp', 'Humor | Romance | Fiction')");
            Sql("INSERT INTO Books (Title, Genre) VALUES ('A Wrinkle in Time', 'Fiction | Fantasy')");
            Sql("INSERT INTO Books (Title, Genre) VALUES ('A Wind in The Door', 'Fiction | Fantasy')");
            Sql("INSERT INTO Books (Title, Genre) VALUES ('A Swiftly Tilting Planet', 'Fiction | Fantasy')");
            Sql("INSERT INTO Books (Title, Genre) VALUES ('Many Waters', 'Fiction | Fantasy')");

        }

        public override void Down()
        {
        }
    }
}
