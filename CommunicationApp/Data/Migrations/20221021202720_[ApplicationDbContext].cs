using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunicationApp.Migrations
{
  
    public partial class ApplicationDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a4fe8fa-c827-48a8-b4d7-3bba23b06548");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f187431-2dee-46b8-a559-fcb5736077e0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ab11aa9-37d8-4aba-a327-19e3ce92a3fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b6dcf7b-f128-4aed-8c63-8192833639a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67fd83b5-2cae-4eb2-9d43-f68df08d4734");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75849fb1-b846-49dd-9b04-8f6065c9d93f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8503dc61-5c8e-4b27-a239-28ffd5847bf4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4c4a7dc-9d4f-41bd-b9e9-9f4744ba7a51");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3599de8-dbfd-4b9e-9120-3a19d3ca53b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f69707cb-d000-4907-866c-52c6060e702e");

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("4af51ec2-9ada-43b7-ad16-ba2d7c506d55"));

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("b712906a-a519-4c36-b1f8-3a8c62281edb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("05405ec8-cda9-485c-a342-5c3d0ca9bef0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f9303bd-f62a-4ba1-9104-c2c883af89c7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("661a5d18-bde6-4c94-b153-5a3497b90303"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6ab3f87a-1f1d-4584-9247-4a770687c1b1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79067b6d-c268-4924-a05b-df499a0f8a86"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("864b9d02-1b18-4e50-8792-7f048ca8e9d6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a4d5c8c5-880e-4fad-80e3-5a5888f1f3a8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a7c18d0b-0e21-4d02-9997-9bd76ce01c3b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1bbdf6f-33b5-4439-84ce-e325c58c20a8"));

            migrationBuilder.DeleteData(
                table: "MeetingDates",
                keyColumn: "Id",
                keyValue: new Guid("2e52bfb3-dc39-446b-84dc-33ccc44641ac"));

            migrationBuilder.DeleteData(
                table: "MeetingDates",
                keyColumn: "Id",
                keyValue: new Guid("7ceff100-fdf8-4fa0-8381-ae41e4c05450"));

            migrationBuilder.DeleteData(
                table: "MeetingDates",
                keyColumn: "Id",
                keyValue: new Guid("f5b53f49-a606-4794-9f18-b44b00ea2dc9"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("5eb847e2-a67d-48ab-aa4f-772a408c3d1f"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("a97d0734-654e-4179-88c5-ebfb120dcf10"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("ac61c8af-79cf-4138-88ba-2ba9974a33fd"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Subscriber", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e4aa1fa9-ac88-4127-b291-558fd027bac6", 0, "19542ebd-0724-4017-99a2-4628934b070e", "Person", "user10@studentmail.oru.se", false, "user", false, "10", false, null, null, "user10@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEIjeVlA2vQqVRil1vXYr+5TmjVI3yIX8dzxPfiY3ir2KnYObRvygtyJLDmnu84GkDg==", null, false, "c977e07d-cfbd-4ccf-a3ed-ebc2e8e168c0", false, false, "user10@studentmail.oru.se" },
                    { "8d860640-1ff0-45cc-9596-bc82493c4a1a", 0, "8803042a-c605-4f6c-8724-2d781cbdd246", "Person", "user8@studentmail.oru.se", false, "user", false, "8", false, null, null, "user8@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEBvdwiva9F2wYsHx3jQldfsZEH0RKLHsGWVUy5+SP0TbyfGIvWADAPYGd6O9G4o5XA==", null, false, "5ffb7d06-7afe-4faf-ad4d-acfb9bbedef6", false, false, "user8@studentmail.oru.se" },
                    { "4985540b-eac3-40c8-94ff-020051f2b808", 0, "e9619e01-3578-4664-87af-918cffed0df1", "Person", "user7@studentmail.oru.se", false, "user", false, "7", false, null, null, "user7@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEAkBF1qjgQ90DnJQjA35C6k1pMF1gB6Vf48Iq+kWtUnBmkoQa22vhCpzuG4MLJmGIA==", null, false, "56a83bc7-d664-4425-8de8-d5b029cc5b11", false, false, "user7@studentmail.oru.se" },
                    { "21445020-6f4a-4a38-99b2-21892e6cc5fb", 0, "0af49405-d357-4b37-9e44-6d033126dbba", "Person", "user6@studentmail.oru.se", false, "user", false, "6", false, null, null, "user6@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAENlTrraurqL35fXOWLbIH3UNbUa5KB3+nKfPx9EHB5Ghv/RpnNQIK9dTwTA1AZvrPg==", null, false, "156080a3-5200-4bbd-a78d-75d5f3f8a53c", false, false, "user6@studentmail.oru.se" },
                    { "d8ec9b2a-edcd-433e-8ecb-edee10e2ed8b", 0, "cc002be4-d559-43f1-bfbc-052a1d9f439f", "Person", "user5@studentmail.oru.se", false, "user", false, "5", false, null, null, "user5@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEBexCWJ0c86SMjBaD2xRvUha6ftrofLwTzC4b5R4f2T3h/UG5vy4K5zugQyMSQOjmA==", null, false, "4dee980d-f5d3-4a7c-ae4a-58a628d8c23a", false, false, "user5@studentmail.oru.se" },
                    { "41d78fa5-9650-426e-95f8-252e6ffc108c", 0, "9158dd94-1412-465f-9225-f67fb9509781", "Person", "user4@studentmail.oru.se", false, "user", false, "4", false, null, null, "user4@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEOx9oirlE/tku43haIX3VbCu/VZNrVQd3YEA88ef0QKWVTwV4O5v+/21zb16FdnBSA==", null, false, "b484860d-a994-48b8-9fbd-e5a5865738c9", false, false, "user4@studentmail.oru.se" },
                    { "bfc4c47b-1517-4be3-a5f5-d0bacf699909", 0, "3b8c79d9-02f2-4033-976b-c3f878b51ce1", "Person", "user3@studentmail.oru.se", false, "user", false, "3", false, null, null, "user3@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEM5wShWWW9BSTwxyjcnwyWVII/wl+Lcp/K73RsJWSWcZFwkoFWdxe5nR/Wu3FCupZw==", null, false, "48eb4792-d16d-4dfa-987b-6d50ab9bf524", false, false, "user3@studentmail.oru.se" },
                    { "cf6a7409-7149-4422-977b-d38aa3a03197", 0, "21890633-92f3-4e4f-aabf-91c45b6d82d9", "Person", "user2@studentmail.oru.se", false, "user", false, "2", false, null, null, "user2@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAECt7JTm9ntDZsk8CKlfr/4yONMm6qjIJQn/vK5VfHxlsN3Kdn3iFKQr/uPA+ORMSrg==", null, false, "c56e5149-a9ba-4269-91f2-8e7de3ad080b", false, false, "user2@studentmail.oru.se" },
                    { "a0dbf17d-65d0-4f61-9168-a5fe7c5d2296", 0, "2aab45e1-3051-4669-bf3e-c205a1473f75", "Person", "user1@studentmail.oru.se", false, "user", false, "1", false, null, null, "user1@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAENr6gRwTdnKWc4nbrydg990iP2EbNJHAgTPrLJdVI2oJ3l18XegR+PGtIGGdAOSAKA==", null, false, "2b238c92-2fd8-4224-812e-d969135ccc89", false, false, "user1@studentmail.oru.se" },
                    { "ec399df9-5709-462d-b978-97a9026d8b57", 0, "61628662-90bb-4405-ae60-01e471fd58ce", "Person", "user9@studentmail.oru.se", false, "user", false, "9", false, null, null, "user9@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEChGCcepFlxpQco4TYeyWJWLhUvn+g9IqxhRSQveWGYf771cCt9Y6l1wrNg2YxH4Qg==", null, false, "3568e99d-4372-4e1e-a477-a57981edeeb9", false, false, "user9@studentmail.oru.se" }
                });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "BlogType", "DateEdited", "DatePublished", "Text", "Title" },
                values: new object[,]
                {
                    { new Guid("0d767fee-760d-43e3-a4c6-3f11d6fdd983"), null, 3, new DateTime(2021, 4, 21, 13, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 13, 46, 0, 0, DateTimeKind.Unspecified), "Text...", "Rubrik" },
                    { new Guid("a87585b2-6752-467e-ae9f-9d78a8580982"), null, 0, new DateTime(2021, 4, 19, 13, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 19, 13, 46, 0, 0, DateTimeKind.Unspecified), "Tack alla för en riktigt underbar AW i helgen! Detta får vi allt göra om. 🍻", "Helgens AW" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatorId", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("f08b5d86-a628-4bb7-82c3-5ef8b2e1c666"), null, "Datavetenskap", 3 },
                    { new Guid("1a85e9f6-0d9a-4dfa-8d7c-19465d426f9f"), null, "Informatik", 3 },
                    { new Guid("e89697a7-b87f-4fe0-a92f-1f89cfb1542a"), null, "HT2021-IK201G", 2 },
                    { new Guid("b5d404b9-e031-40ce-8286-b2cbfafcb75a"), null, "VT2022-IK207G", 2 },
                    { new Guid("8fe4bd84-cdfb-42a1-89da-cf8d8efbb772"), null, "Information gällande Covid-19", 1 },
                    { new Guid("8d301dc7-8c14-4655-b389-346ff46016a9"), null, "Nya kurser", 1 },
                    { new Guid("44da6fdd-428e-4450-9804-bd3867c10bd0"), null, "Resor", 0 },
                    { new Guid("697b5d41-f9de-4cca-8197-8872d11d572a"), null, "AfterWork", 0 },
                    { new Guid("5f5e58ac-78d9-4df9-a97a-d1c561d56cab"), null, "Användning av IT i verksamhetskontexter", 3 }
                });

            migrationBuilder.InsertData(
                table: "MeetingDates",
                columns: new[] { "Id", "End", "MeetingId", "Start" },
                values: new object[,]
                {
                    { new Guid("ab3990b6-c4b1-4a06-a497-0db69a513760"), new DateTime(2021, 5, 4, 13, 15, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 5, 4, 12, 15, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7f95a22c-f091-408d-af44-2817be3643d8"), new DateTime(2021, 5, 15, 16, 15, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 5, 15, 13, 30, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("34a6dbb6-7e5a-4c53-8e32-74082be1c12c"), new DateTime(2021, 5, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 5, 20, 14, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "Description", "FinalDateId", "HostId", "Subject" },
                values: new object[,]
                {
                    { new Guid("57277503-c868-45e2-aca9-13f4ed93ed14"), "Denna dagen kör vi så det ryker! Vi ska allt se till att bli klara med detta projektet nu!", null, null, "Parprogrammering" },
                    { new Guid("d74f451b-c9b4-4b11-b58f-a547fc89d96c"), "Vi kör en genomgång tillsamman om vad detta skrum är för något.", null, null, "Scrum information" },
                    { new Guid("b4df8725-a6f0-45f8-a4b1-848be2b31209"), "Oj, så roligt vi ska ha!", null, null, "Programmering tillsammans!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21445020-6f4a-4a38-99b2-21892e6cc5fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41d78fa5-9650-426e-95f8-252e6ffc108c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4985540b-eac3-40c8-94ff-020051f2b808");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d860640-1ff0-45cc-9596-bc82493c4a1a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0dbf17d-65d0-4f61-9168-a5fe7c5d2296");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bfc4c47b-1517-4be3-a5f5-d0bacf699909");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf6a7409-7149-4422-977b-d38aa3a03197");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8ec9b2a-edcd-433e-8ecb-edee10e2ed8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4aa1fa9-ac88-4127-b291-558fd027bac6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec399df9-5709-462d-b978-97a9026d8b57");

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("0d767fee-760d-43e3-a4c6-3f11d6fdd983"));

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("a87585b2-6752-467e-ae9f-9d78a8580982"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a85e9f6-0d9a-4dfa-8d7c-19465d426f9f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("44da6fdd-428e-4450-9804-bd3867c10bd0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5f5e58ac-78d9-4df9-a97a-d1c561d56cab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("697b5d41-f9de-4cca-8197-8872d11d572a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8d301dc7-8c14-4655-b389-346ff46016a9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8fe4bd84-cdfb-42a1-89da-cf8d8efbb772"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b5d404b9-e031-40ce-8286-b2cbfafcb75a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e89697a7-b87f-4fe0-a92f-1f89cfb1542a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f08b5d86-a628-4bb7-82c3-5ef8b2e1c666"));

            migrationBuilder.DeleteData(
                table: "MeetingDates",
                keyColumn: "Id",
                keyValue: new Guid("34a6dbb6-7e5a-4c53-8e32-74082be1c12c"));

            migrationBuilder.DeleteData(
                table: "MeetingDates",
                keyColumn: "Id",
                keyValue: new Guid("7f95a22c-f091-408d-af44-2817be3643d8"));

            migrationBuilder.DeleteData(
                table: "MeetingDates",
                keyColumn: "Id",
                keyValue: new Guid("ab3990b6-c4b1-4a06-a497-0db69a513760"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("57277503-c868-45e2-aca9-13f4ed93ed14"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("b4df8725-a6f0-45f8-a4b1-848be2b31209"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("d74f451b-c9b4-4b11-b58f-a547fc89d96c"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Subscriber", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c3599de8-dbfd-4b9e-9120-3a19d3ca53b4", 0, "41fdf692-6532-45ff-9843-7826200be3bc", "Person", "user10@studentmail.oru.se", false, "user", false, "10", false, null, null, "user10@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEFTxROfdvtsVwhaoilpLxMths24egR1L94Z0rEdG36SWcA9AmYsOiOFxwlQFL2Io9Q==", null, false, "95bbeded-1275-4f51-a564-d7773692c81c", false, false, "user10@studentmail.oru.se" },
                    { "f69707cb-d000-4907-866c-52c6060e702e", 0, "a0be89e9-df17-44fb-96b0-c171d67f2d3a", "Person", "user8@studentmail.oru.se", false, "user", false, "8", false, null, null, "user8@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEHwxXJnB/PrwsU4D0ywvt0Q66VAzZ1XTeYzHBu4Iz5v9hzvCJBzj2WIwQShL9AlGXQ==", null, false, "9d2eccd9-d640-44c4-8c8e-4994a0090b50", false, false, "user8@studentmail.oru.se" },
                    { "5b6dcf7b-f128-4aed-8c63-8192833639a2", 0, "c06a465b-0928-4620-adaf-9bf360aaab39", "Person", "user7@studentmail.oru.se", false, "user", false, "7", false, null, null, "user7@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEFfPEUhGTcSJKO7OQIOgoetskDnriezW14TcYYZMOVfWp2kIpF873G6nl//aMDNTgA==", null, false, "1aa05827-932e-40a3-9478-2050e97a1bd1", false, false, "user7@studentmail.oru.se" },
                    { "2a4fe8fa-c827-48a8-b4d7-3bba23b06548", 0, "84105bb0-c050-4d8e-b0ea-248b68c156dc", "Person", "user6@studentmail.oru.se", false, "user", false, "6", false, null, null, "user6@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEOTx9UEtO8jKU1rh2YiLwfIeuOzpeoaITxn0NDrEmp1SGtVN/j6wx9KvObYJbAnd6Q==", null, false, "c9e0efaa-6129-4895-b0b4-0dde3b864743", false, false, "user6@studentmail.oru.se" },
                    { "67fd83b5-2cae-4eb2-9d43-f68df08d4734", 0, "581d6f51-5ab1-46d7-87af-46f236a48395", "Person", "user5@studentmail.oru.se", false, "user", false, "5", false, null, null, "user5@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEPDOMtSqvSA5nYt6ljP9uRD6OLpsXGh1tp2BhDC2EV1wumkgBN5ZInAigZUpASy1uQ==", null, false, "ddb8c866-3397-4fa4-b5c6-065954df5cdb", false, false, "user5@studentmail.oru.se" },
                    { "4ab11aa9-37d8-4aba-a327-19e3ce92a3fd", 0, "d051fb11-1082-4a0b-9dd3-4cb82afc3c0b", "Person", "user4@studentmail.oru.se", false, "user", false, "4", false, null, null, "user4@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEEdwtA4xAPbE3lIFPfjtvSffknfENwPzEMlzCabmzSF6PJsO2c1dxY0f/3BYl+Tk6w==", null, false, "fe860642-42b3-4305-8da6-3a4a180e3580", false, false, "user4@studentmail.oru.se" },
                    { "3f187431-2dee-46b8-a559-fcb5736077e0", 0, "d085aea8-a60d-4d3c-9409-791f983d97d6", "Person", "user3@studentmail.oru.se", false, "user", false, "3", false, null, null, "user3@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEJyH70DGM9fBOsyR59C9i0BEIoeHDS4/K5MICM0SMsFRtoCKIdO0HK2X4cxFLIzaJA==", null, false, "29e3379f-4b56-40ba-a68d-116610da4123", false, false, "user3@studentmail.oru.se" },
                    { "8503dc61-5c8e-4b27-a239-28ffd5847bf4", 0, "01ea7603-69a8-42f9-b1f6-87588d3e9197", "Person", "user2@studentmail.oru.se", false, "user", false, "2", false, null, null, "user2@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEEfGf+ddJIZKv7XIV1wJ5zdfk2vr1WGpB7i2tmAPfYRGQuNNXHq1rfz/kbcQegi2hg==", null, false, "98a62292-9843-410d-933b-d65d009e8ccd", false, false, "user2@studentmail.oru.se" },
                    { "75849fb1-b846-49dd-9b04-8f6065c9d93f", 0, "b24963d4-4e12-4415-8223-ba2723cd8e42", "Person", "user1@studentmail.oru.se", false, "user", false, "1", false, null, null, "user1@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAECR+SkIEqfIrhKd19gDjON0ff8Zw3Lqk+HgPpQS241c/YNsaiG2NXeKF7PQ8utq2Ng==", null, false, "5e06e880-3a61-4194-abc0-02b4b352f3ea", false, false, "user1@studentmail.oru.se" },
                    { "b4c4a7dc-9d4f-41bd-b9e9-9f4744ba7a51", 0, "709017bb-55ca-40e9-b3fe-e8aca6906d24", "Person", "user9@studentmail.oru.se", false, "user", false, "9", false, null, null, "user9@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEIt7rHW6H1IwQ/bP3ecW8mkjqfZFKfqGLQEIX53wNcwL/JV+Fa02C/vL8+E9OCBHWw==", null, false, "84257111-474e-4b13-8f71-a2074e1ffbf7", false, false, "user9@studentmail.oru.se" }
                });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "BlogType", "DateEdited", "DatePublished", "Text", "Title" },
                values: new object[,]
                {
                    { new Guid("4af51ec2-9ada-43b7-ad16-ba2d7c506d55"), null, 3, new DateTime(2021, 4, 21, 13, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 13, 46, 0, 0, DateTimeKind.Unspecified), "Text...", "Rubrik" },
                    { new Guid("b712906a-a519-4c36-b1f8-3a8c62281edb"), null, 0, new DateTime(2021, 4, 19, 13, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 19, 13, 46, 0, 0, DateTimeKind.Unspecified), "Tack alla för en riktigt underbar AW i helgen! Detta får vi allt göra om. 🍻", "Helgens AW" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatorId", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("c1bbdf6f-33b5-4439-84ce-e325c58c20a8"), null, "Datavetenskap", 3 },
                    { new Guid("79067b6d-c268-4924-a05b-df499a0f8a86"), null, "Informatik", 3 },
                    { new Guid("3f9303bd-f62a-4ba1-9104-c2c883af89c7"), null, "HT2021-IK201G", 2 },
                    { new Guid("6ab3f87a-1f1d-4584-9247-4a770687c1b1"), null, "VT2022-IK207G", 2 },
                    { new Guid("864b9d02-1b18-4e50-8792-7f048ca8e9d6"), null, "Information gällande Covid-19", 1 },
                    { new Guid("661a5d18-bde6-4c94-b153-5a3497b90303"), null, "Nya kurser", 1 },
                    { new Guid("05405ec8-cda9-485c-a342-5c3d0ca9bef0"), null, "Resor", 0 },
                    { new Guid("a4d5c8c5-880e-4fad-80e3-5a5888f1f3a8"), null, "AfterWork", 0 },
                    { new Guid("a7c18d0b-0e21-4d02-9997-9bd76ce01c3b"), null, "Användning av IT i verksamhetskontexter", 3 }
                });

            migrationBuilder.InsertData(
                table: "MeetingDates",
                columns: new[] { "Id", "End", "MeetingId", "Start" },
                values: new object[,]
                {
                    { new Guid("7ceff100-fdf8-4fa0-8381-ae41e4c05450"), new DateTime(2021, 5, 4, 13, 15, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 5, 4, 12, 15, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f5b53f49-a606-4794-9f18-b44b00ea2dc9"), new DateTime(2021, 5, 15, 16, 15, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 5, 15, 13, 30, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2e52bfb3-dc39-446b-84dc-33ccc44641ac"), new DateTime(2021, 5, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 5, 20, 14, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "Description", "FinalDateId", "HostId", "Subject" },
                values: new object[,]
                {
                    { new Guid("5eb847e2-a67d-48ab-aa4f-772a408c3d1f"), "Denna dagen kör vi så det ryker! Vi ska allt se till att bli klara med detta projektet nu!", null, null, "Parprogrammering" },
                    { new Guid("ac61c8af-79cf-4138-88ba-2ba9974a33fd"), "Vi kör en genomgång tillsamman om vad detta skrum är för något.", null, null, "Scrum information" },
                    { new Guid("a97d0734-654e-4179-88c5-ebfb120dcf10"), "Oj, så roligt vi ska ha!", null, null, "Programmering tillsammans!" }
                });
        }
    }
}
