namespace SQL_RestApi_Client.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using SQL_RestApi_Client.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SQL_RestApi_Client.Models.ProsumerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SQL_RestApi_Client.Models.ProsumerContext context)
        {
            context.Addresses.AddOrUpdate(x => x.Id,
                new Address() { Id = 1, HouseNumber = "1", StreetName = "Centervej", City = "SmartiVille", ZipCode = "200000"},
                new Address() { Id = 2, HouseNumber = "2", StreetName = "Centervej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 3, HouseNumber = "3", StreetName = "Centervej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 4, HouseNumber = "4", StreetName = "Centervej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 5, HouseNumber = "5", StreetName = "Centervej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 6, HouseNumber = "7", StreetName = "Centervej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 7, HouseNumber = "9", StreetName = "Centervej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 8, HouseNumber = "11", StreetName = "Centervej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 9, HouseNumber = "13", StreetName = "Centervej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 10, HouseNumber = "15", StreetName = "Centervej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 11, HouseNumber = "17", StreetName = "Centervej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 12, HouseNumber = "19", StreetName = "Centervej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 13, HouseNumber = "21", StreetName = "Centervej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 14, HouseNumber = "23", StreetName = "Centervej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 15, HouseNumber = "25", StreetName = "Centervej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 16, HouseNumber = "27", StreetName = "Centervej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 17, HouseNumber = "29", StreetName = "Centervej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 18, HouseNumber = "31", StreetName = "Centervej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 19, HouseNumber = "33", StreetName = "Centervej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 20, HouseNumber = "35", StreetName = "Centervej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 21, HouseNumber = "1", StreetName = "Ydrevej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 22, HouseNumber = "2", StreetName = "Ydrevej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 23, HouseNumber = "3", StreetName = "Ydrevej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 24, HouseNumber = "4", StreetName = "Ydrevej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 25, HouseNumber = "5", StreetName = "Ydrevej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 26, HouseNumber = "6", StreetName = "Ydrevej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 27, HouseNumber = "8", StreetName = "Ydrevej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 28, HouseNumber = "10", StreetName = "Ydrevej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 29, HouseNumber = "12", StreetName = "Ydrevej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 30, HouseNumber = "14", StreetName = "Ydrevej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 31, HouseNumber = "16", StreetName = "Ydrevej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 32, HouseNumber = "18", StreetName = "Ydrevej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 33, HouseNumber = "20", StreetName = "Ydrevej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 34, HouseNumber = "1", StreetName = "Industrivej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 35, HouseNumber = "2", StreetName = "Industrivej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 36, HouseNumber = "3", StreetName = "Industrivej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 37, HouseNumber = "4", StreetName = "Industrivej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 38, HouseNumber = "5", StreetName = "Industrivej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 39, HouseNumber = "7", StreetName = "Industrivej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 40, HouseNumber = "9", StreetName = "Industrivej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 41, HouseNumber = "11", StreetName = "Industrivej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 42, HouseNumber = "13", StreetName = "Industrivej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 43, HouseNumber = "115", StreetName = "Landevej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 44, HouseNumber = "98", StreetName = "Landevej", City = "SmartiVille", ZipCode = "200000" },
                new Address() { Id = 45, HouseNumber = "11", StreetName = "Landevej", City = "SmartiVille", ZipCode = "200000" }
                );
            context.Prosumers.AddOrUpdate(x => x.Id,
                new Prosumer() { Id = 1, FirstName = "Jens", MiddleNames = "", LastName = "Hansen", AddressId = 45, Email = "Hansen1@post.dk", Telephone = "12345678", ProsumerType = "Landmand"},
                new Prosumer() { Id = 2, FirstName = "Peter", MiddleNames = "Jens", LastName = "Jensen", AddressId = 44, Email = "Jensen2@post.dk", Telephone = "12345670", ProsumerType = "Landmand" },
                new Prosumer() { Id = 3, FirstName = "Kim", MiddleNames = "", LastName = "Kristiansen", AddressId = 43, Email = "Kristiansen3@post.dk", Telephone = "12345671", ProsumerType = "Landmand" },
                new Prosumer() { Id = 4, FirstName = "Tobias", MiddleNames = "Kjær", LastName = "Henriksen", AddressId = 42, Email = "Henriksen4@post.dk", Telephone = "12345672", ProsumerType = "Virksomhed" },
                new Prosumer() { Id = 5, FirstName = "Lars", MiddleNames = "", LastName = "Johansen", AddressId = 41, Email = "Johansen5@post.dk", Telephone = "12345673", ProsumerType = "Virksomhed" },
                new Prosumer() { Id = 6, FirstName = "Jacob", MiddleNames = "Peter", LastName = "Mikkelsen", AddressId = 40, Email = "Mikkelsen6@post.dk", Telephone = "12345674", ProsumerType = "Virksomhed" },
                new Prosumer() { Id = 7, FirstName = "Mia", MiddleNames = "", LastName = "Larsen", AddressId = 39, Email = "Larsen7@post.dk", Telephone = "12345675", ProsumerType = "Virksomhed" },
                new Prosumer() { Id = 8, FirstName = "Nikolai", MiddleNames = "", LastName = "Kristensen", AddressId = 38, Email = "Kristensen8@post.dk", Telephone = "12345676", ProsumerType = "Virksomhed" },
                new Prosumer() { Id = 9, FirstName = "Line", MiddleNames = "", LastName = "Nicolajsen", AddressId = 37, Email = "Nicolajsen9@post.dk", Telephone = "12345677", ProsumerType = "Virksomhed" },
                new Prosumer() { Id = 10, FirstName = "Maja", MiddleNames = "Johanna", LastName = "Sørensen", AddressId = 36, Email = "Sørensen10@post.dk", Telephone = "22345678", ProsumerType = "Virksomhed" },
                new Prosumer() { Id = 11, FirstName = "Mikkel", MiddleNames = "", LastName = "Undergaard", AddressId = 35, Email = "Undergaard11@post.dk", Telephone = "32345678", ProsumerType = "Virksomhed" },
                new Prosumer() { Id = 12, FirstName = "Maiken", MiddleNames = "", LastName = "Flemmingsen", AddressId = 34, Email = "Flemmingsen@post.dk", Telephone = "42345678", ProsumerType = "Virksomhed" },
                new Prosumer() { Id = 13, FirstName = "Erik", MiddleNames = "", LastName = "Kartman", AddressId = 33, Email = "Kartman13@post.dk", Telephone = "52345678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 14, FirstName = "Johnny", MiddleNames = "B", LastName = "Goodie", AddressId = 32, Email = "Goddie14@post.dk", Telephone = "62345678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 15, FirstName = "Cook", MiddleNames = "", LastName = "Phoo", AddressId = 31, Email = "Phoo15@post.dk", Telephone = "72345678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 16, FirstName = "Hugh", MiddleNames = "E", LastName = "Rection", AddressId = 30, Email = "Rection16@post.dk", Telephone = "82345678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 17, FirstName = "Torben", MiddleNames = "", LastName = "Balle", AddressId = 29, Email = "Balle17@post.dk", Telephone = "92345678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 18, FirstName = "Mike", MiddleNames = "Overballe", LastName = "Birch", AddressId = 28, Email = "Birch18@post.dk", Telephone = "11345678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 19, FirstName = "Simon", MiddleNames = "", LastName = "Bundgård-Egeberg", AddressId = 27, Email = "Bundgård-Egeberg19@post.dk", Telephone = "13345678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 20, FirstName = "Emil", MiddleNames = "", LastName = "Celik", AddressId = 26, Email = "Celik20@post.dk", Telephone = "14345678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 21, FirstName = "Johnny", MiddleNames = "", LastName = "Bravo", AddressId = 25, Email = "Bravo21@post.dk", Telephone = "15345678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 22, FirstName = "Niels", MiddleNames = "", LastName = "Sondersen", AddressId = 24, Email = "Sondersen22@post.dk", Telephone = "16345678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 23, FirstName = "Kenn", MiddleNames = "Østergård", LastName = "Rasmussen", AddressId = 23, Email = "Rasmussen22@post.dk", Telephone = "17345678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 24, FirstName = "Gert", MiddleNames = "", LastName = "Nielsen", AddressId = 22, Email = "Nielsen24@post.dk", Telephone = "18345678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 25, FirstName = "Hans", MiddleNames = "Victor", LastName = "Rugbrødsen", AddressId = 21, Email = "Rugbrødsen25@post.dk", Telephone = "19345678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 26, FirstName = "Humme", MiddleNames = "", LastName = "Leth", AddressId = 20, Email = "Leth26@post.dk", Telephone = "10345678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 27, FirstName = "Baldur", MiddleNames = "", LastName = "Öjenskjol", AddressId = 19, Email = "Öjenskjol27@post.dk", Telephone = "12045678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 28, FirstName = "Karsten", MiddleNames = "", LastName = "Karstensen", AddressId = 18, Email = "Karstensen28@post.dk", Telephone = "12145678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 29, FirstName = "Bear", MiddleNames = "", LastName = "Grylls", AddressId = 17, Email = "Grylls29@post.dk", Telephone = "12245678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 30, FirstName = "John", MiddleNames = "", LastName = "Cena", AddressId = 16, Email = "Cena30@post.dk", Telephone = "12445678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 31, FirstName = "Sarah", MiddleNames = "", LastName = "Vilhelmsen", AddressId = 15, Email = "Vilhelmsen31@post.dk", Telephone = "12545678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 32, FirstName = "Michelle", MiddleNames = "", LastName = "True", AddressId = 14, Email = "True32@post.dk", Telephone = "12645678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 33, FirstName = "Victoria", MiddleNames = "", LastName = "Dallesen", AddressId = 13, Email = "Dallesen33@post.dk", Telephone = "12745678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 34, FirstName = "Elpose", MiddleNames = "Les", LastName = "Lammos", AddressId = 12, Email = "Lammos34@post.dk", Telephone = "12845678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 35, FirstName = "Angra", MiddleNames = "Mac", LastName = "Suresen", AddressId = 11, Email = "Suresen35@post.dk", Telephone = "12945678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 36, FirstName = "Mongo", MiddleNames = "", LastName = "Devvesen", AddressId = 10, Email = "Devvesen36@post.dk", Telephone = "12305678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 37, FirstName = "Melinda", MiddleNames = "", LastName = "Gates", AddressId = 9, Email = "Gates37@post.dk", Telephone = "12315678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 38, FirstName = "Steve", MiddleNames = "", LastName = "Jobs", AddressId = 8, Email = "Jobs38@post.dk", Telephone = "12325678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 39, FirstName = "Donald", MiddleNames = "J", LastName = "Tumpe", AddressId = 7, Email = "Tumpe39@post.dk", Telephone = "12335678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 40, FirstName = "Dank", MiddleNames = "Master", LastName = "Dankson", AddressId = 6, Email = "Dankson40@post.dk", Telephone = "12355678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 41, FirstName = "Mimi", MiddleNames = "", LastName = "Lord", AddressId = 5, Email = "Lord41@post.dk", Telephone = "12365678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 42, FirstName = "Zana", MiddleNames = "", LastName = "Krillson", AddressId = 4, Email = "Krillson42@post.dk", Telephone = "12375678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 43, FirstName = "Rare", MiddleNames = "", LastName = "Pepe", AddressId = 3, Email = "Pepe43@post.dk", Telephone = "12385678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 44, FirstName = "Vilma", MiddleNames = "", LastName = "Norsegod", AddressId = 2, Email = "Norsegod44@post.dk", Telephone = "12395678", ProsumerType = "Boligejer" },
                new Prosumer() { Id = 45, FirstName = "Pun", MiddleNames = "Puns", LastName = "Punny", AddressId = 1, Email = "Punny45@post.dk", Telephone = "12345678", ProsumerType = "Boligejer" }
                );
        }
    }
}
