using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunicationApp.Migrations
{
    public partial class _20210419090354_CreateIK207GTeam8Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27a4c2a8-5f28-493b-9ede-beeefa96286b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "313f91fb-5e4a-4f50-92de-6481fa87a47b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4552d1f7-1993-4c58-abac-5115e9626d72");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ed40ddb-0e60-4acd-b646-b68a0c7a8c79");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "742eac75-a7fe-4e4d-bce1-5b3f1b865167");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75fb1e30-ec0e-4753-a98d-8c085c707660");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f97da13-97a7-4046-945e-f13fbe2fef19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85c0b660-8a76-4ff3-ad13-1c078ab48093");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c8ce09e-f3bd-4ceb-9a4a-cc3b1f5be925");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9020a578-d3c2-4fd0-afce-fde55067f68e");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "75fb1e30-ec0e-4753-a98d-8c085c707660", 0, "6db9afb2-4de3-4d57-bfd3-1d0362620f2e", "Person", "user1@studentmail.oru.se", false, "user", false, "1", false, null, null, "user1@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAENlx0QBJSmHjnhtB4Hxkc3kRRTJo1uOJpXi+G6G1EMqtKd24vxIngyjSbXfszZlucQ==", null, false, "81b6b55b-6428-412d-bd5e-96bccec5de74", false, false, "user1@studentmail.oru.se" },
                    { "9020a578-d3c2-4fd0-afce-fde55067f68e", 0, "a5015ce8-6611-4116-80b2-ce29fc070893", "Person", "user2@studentmail.oru.se", false, "user", false, "2", false, null, null, "ALEWEH201@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAECUP4XhzRPbfOqgp1mHZtsNx+d2klR+mEwUAnoTyDcy4syg/WPPp+qTeoX2wB5deyA==", null, false, "d4ea5564-dfe1-4673-ab18-8e17248cf681", false, false, "user2@studentmail.oru.se" },
                    { "313f91fb-5e4a-4f50-92de-6481fa87a47b", 0, "d8849edd-c92a-428f-94b1-1352d578b481", "Person", "user3@studentmail.oru.se", false, "user", false, "3", false, null, null, "user3@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEKOUsAv07JbXJrg2Nfyo0Aq0hvhaJmDYRkhoGGpPYdr9mjKTexZJfF3gywoxp1Gp0Q==", null, false, "25fe4595-f3d6-4988-98f5-088dbd592b99", false, false, "user3@studentmail.oru.se" },
                    { "85c0b660-8a76-4ff3-ad13-1c078ab48093", 0, "7c2f983d-a4f9-4769-ba27-6c1bbd7a77cc", "Person", "user4@studentmail.oru.se", false, "user", false, "4", false, null, null, "user4@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEGhKDQClIrzQ7GV26yAQ8H85+NGri8y4UbCTYcZDHQ3sWlL4inmW3JT2UPJyo1kKFg==", null, false, "e215a957-515f-41cb-98f5-afef4cca7df9", false, false, "user4@studentmail.oru.se" },
                    { "6ed40ddb-0e60-4acd-b646-b68a0c7a8c79", 0, "362f6226-db7a-4712-ae9f-a857aefaaa18", "Person", "user5@studentmail.oru.se", false, "user", false, "5", false, null, null, "user5@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAELKJVRdD6irX8H14e/oRVtC3jQGwZyPTfvB+JekZt57ADtAs3NharFVcLBnIgS1sTA==", null, false, "5cc2f642-856f-4084-ba82-5eec20062db1", false, false, "user5@studentmail.oru.se" },
                    { "4552d1f7-1993-4c58-abac-5115e9626d72", 0, "4f939f1d-bc61-4e74-a9b2-8c821ea17fde", "Person", "user6@studentmail.oru.se", false, "user", false, "6", false, null, null, "user6@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAELAgJON7XyjY1EsKuglQcKGL5z6DzZ/g4qlh2lJmQNv5xMB21ZbbMXtslrnyL2Y2iw==", null, false, "e3cf1a8b-b6b3-419e-8bc1-400574727698", false, false, "user6@studentmail.oru.se" },
                    { "742eac75-a7fe-4e4d-bce1-5b3f1b865167", 0, "f835a7c4-747d-4c5b-b41f-d3ec141c227d", "Person", "user7@studentmail.oru.se", false, "user", false, "7", false, null, null, "user7@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEJ/bCF0vkxm52GVeIZwWDOS3LobdOGtCS7f/axwdepk2mTFTtc8qEGFxLJGJ8UAuBw==", null, false, "eca0e17d-f4dc-4109-bb10-b7229eab1d27", false, false, "user7@studentmail.oru.se" },
                    { "8c8ce09e-f3bd-4ceb-9a4a-cc3b1f5be925", 0, "ae45d04f-72d6-45de-a4c5-f5a35d14d518", "Person", "user8@studentmail.oru.se", false, "user", false, "8", false, null, null, "user8@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEB83Z1ovAZnrRpI558u7d+q9vVcgQ4KLxd1CoJTGZAz2ji1/RFcJjWPSxCA7ts3J9A==", null, false, "01c52292-c944-4c7e-8248-c798b1175466", false, false, "user8@studentmail.oru.se" },
                    { "7f97da13-97a7-4046-945e-f13fbe2fef19", 0, "c3090b25-60de-4a37-80e5-586c0ed5141f", "Person", "user9@studentmail.oru.se", false, "user", false, "9", false, null, null, "user9@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAENhvTDDxQQmwmBkGJRuY0J7OeNr6zlGVyCCloSy6BnxOkBW34BfXW4IA14YM5P5TLA==", null, false, "00863ca9-7827-44ca-8e4a-dcfb7c6dc97e", false, false, "user9@studentmail.oru.se" },
                    { "27a4c2a8-5f28-493b-9ede-beeefa96286b", 0, "5fcbb9ea-954f-42e3-8386-e6d2df66ade0", "Person", "user10@studentmail.oru.se", false, "user", false, "10", false, null, null, "user10@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEE9CajS4QWMQ1yLvZSyPtf8iYadFLjijqksg4imREM8/oLrQDUdU2KUevPQp3xKnYA==", null, false, "38c69be8-227b-4157-bfeb-d2357c89aa8d", false, false, "user10@studentmail.oru.se" }
                });
        }
    }
}
