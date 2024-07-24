namespace DATennis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedPlayers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            SET IDENTITY_INSERT Tournaments ON
            INSERT INTO Tournaments (Id) VALUES
            (1)
            SET IDENTITY_INSERT Tournaments OFF");

            Sql(@"
            SET IDENTITY_INSERT Groups ON
            INSERT INTO Groups (Id, Tournament_Id) VALUES
            (1, 1),
            (2, 1)
            SET IDENTITY_INSERT Groups OFF");

            Sql(@"
            SET IDENTITY_INSERT Players ON
            INSERT INTO Players (Id, Group_Id, DobYear, DobMonth, DobDay, Name, Country, Ranking, TurnedProYear, Weight, Height, Birthplace, Residence, Plays, Coach, Singlestitles) VALUES
            (1, 1, 1987, 5, 22, 'Novak Djokovic', 'SRB', 1, 2003, '77kg', '188cm', 'Belgrade, Serbia', 'Monte Carlo, Monaco', 'Right-Handed, Two-Handed Backhand', 'Marian Vajda, Goran Ivanisevic', 84),
            (2, 2, 1986, 6, 3, 'Rafael Nadal', 'ESP', 3, 2001, '85kg', '185cm', 'Manacor, Mallorca, Spain', 'Manacor, Mallorca, Spain', 'Left-Handed, Two-Handed Backhand', 'Carlos Moya, Francisco Roig', 88),
            (3, 2, 1993, 9, 3, 'Dominic Thiem', 'AUT', 4, 2011, '79kg', '185cm', 'Wiener Neustadt, Austria', 'Lichtenworth, Austria', 'Right-Handed, One-Handed Backhand', 'Nicolas Massu', 17),
            (4, 1, 1996, 2, 11, 'Daniil Medvedev', 'RUS', 2, 2014, '83kg', '198cm', 'Moscow, Russia', 'Monte Carlo, Monaco', 'Right-Handed, Two-Handed Backhand', 'Gilles Cervara', 10),
            (5, 1, 1997, 4, 20, 'Alexander Zverev', 'GER', 6, 2013, '90kg', '198cm', 'Hamburg, Germany', 'Monte Carlo, Monaco', 'Right-Handed, Two-Handed Backhand', 'Alexander Zverev Sr.', 15),
            (6, 2, 1981, 8, 8, 'Roger Federer', 'SUI', 8, 1998, '85kg', '185cm', 'Basel, Switzerland', 'Switzerland', 'Right-Handed, One-Handed Backhand', 'Ivan Ljubicic, Severin Luthi', 103),
            (7, 1, 1998, 8, 12, 'Stefanos Tsitsipas', 'GRE', 5, 2016, '89kg', '193cm', 'Athens, Greece', 'Monte Carlo, Monaco', 'Right-Handed, One-Handed Backhand', 'Apostolos Tsitsipas', 7),
            (8, 2, 1992, 8, 16, 'Diego Schwartzman', 'ARG', 10, 2010, '64kg', '170cm', 'Buenos Aires, Argentina', 'Buenos Aires, Argentina', 'Right-Handed, Two-Handed Backhand', 'Juan Ignacio Chela, Alejandro Fabbri', 4),
            (9, 2, 1996, 4, 12, 'Matteo Berrettini', 'ITA', 9, 2015, '95kg', '196cm', 'Rome, Italy', 'Monte Carlo, Monaco', 'Right-Handed, Two-Handed Backhand', 'Vincenzo Santopadre, Marco Gulisano, Umberto', 4),
            (10, 1, 1997, 10, 20,  'Andrey Rublev', 'RUS', 7, 2014, '75kg', '188cm', 'Moscow, Russia', 'Moscow, Russia', 'Right-Handed, Two-Handed Backhand', 'Fernando Vicente', 8)
            SET IDENTITY_INSERT Players OFF");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Players");
            Sql("DELETE FROM Groups");
            Sql("DELETE FROM Tournaments");
        }
    }
}
