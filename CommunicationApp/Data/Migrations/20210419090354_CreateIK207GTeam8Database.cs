using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunicationApp.Migrations
{
    public partial class CreateIK207GTeam8Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subscriber = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DatePublished = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEdited = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BlogType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogPosts_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CreatorId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_AspNetUsers_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BlogPostId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FileUpload",
                columns: table => new
                {
                    Url = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogPostId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileUpload", x => x.Url);
                    table.ForeignKey(
                        name: "FK_FileUpload_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostCategory",
                columns: table => new
                {
                    BlogPostsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostCategory", x => new { x.BlogPostsId, x.CategoriesId });
                    table.ForeignKey(
                        name: "FK_BlogPostCategory_BlogPosts_BlogPostsId",
                        column: x => x.BlogPostsId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogPostCategory_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryPerson",
                columns: table => new
                {
                    CategoryAccessListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParticipantsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPerson", x => new { x.CategoryAccessListId, x.ParticipantsId });
                    table.ForeignKey(
                        name: "FK_CategoryPerson_AspNetUsers_ParticipantsId",
                        column: x => x.ParticipantsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryPerson_Categories_CategoryAccessListId",
                        column: x => x.CategoryAccessListId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeetingDatePerson",
                columns: table => new
                {
                    AttendeesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MeetingDateRequestsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingDatePerson", x => new { x.AttendeesId, x.MeetingDateRequestsId });
                    table.ForeignKey(
                        name: "FK_MeetingDatePerson_AspNetUsers_AttendeesId",
                        column: x => x.AttendeesId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeetingPerson",
                columns: table => new
                {
                    MeetingRequestsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipientsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingPerson", x => new { x.MeetingRequestsId, x.RecipientsId });
                    table.ForeignKey(
                        name: "FK_MeetingPerson_AspNetUsers_RecipientsId",
                        column: x => x.RecipientsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeetingPerson1",
                columns: table => new
                {
                    NonAttendersId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NotAttendingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingPerson1", x => new { x.NonAttendersId, x.NotAttendingId });
                    table.ForeignKey(
                        name: "FK_MeetingPerson1_AspNetUsers_NonAttendersId",
                        column: x => x.NonAttendersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meetings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalDateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HostId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meetings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meetings_AspNetUsers_HostId",
                        column: x => x.HostId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MeetingDates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MeetingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeetingDates_Meetings_MeetingId",
                        column: x => x.MeetingId,
                        principalTable: "Meetings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Subscriber", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "75fb1e30-ec0e-4753-a98d-8c085c707660", 0, "6db9afb2-4de3-4d57-bfd3-1d0362620f2e", "Person", "user1@studentmail.oru.se", false, "user", false, "1", false, null, null, "user1@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAENlx0QBJSmHjnhtB4Hxkc3kRRTJo1uOJpXi+G6G1EMqtKd24vxIngyjSbXfszZlucQ==", null, false, "81b6b55b-6428-412d-bd5e-96bccec5de74", false, false, "user1@studentmail.oru.se" },
                    { "9020a578-d3c2-4fd0-afce-fde55067f68e", 0, "a5015ce8-6611-4116-80b2-ce29fc070893", "Person", "user2@studentmail.oru.se", false, "user", false, "2", false, null, null, "user2@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAECUP4XhzRPbfOqgp1mHZtsNx+d2klR+mEwUAnoTyDcy4syg/WPPp+qTeoX2wB5deyA==", null, false, "d4ea5564-dfe1-4673-ab18-8e17248cf681", false, false, "user2@studentmail.oru.se" },
                    { "313f91fb-5e4a-4f50-92de-6481fa87a47b", 0, "d8849edd-c92a-428f-94b1-1352d578b481", "Person", "user3@studentmail.oru.se", false, "user", false, "3", false, null, null, "user3@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEKOUsAv07JbXJrg2Nfyo0Aq0hvhaJmDYRkhoGGpPYdr9mjKTexZJfF3gywoxp1Gp0Q==", null, false, "25fe4595-f3d6-4988-98f5-088dbd592b99", false, false, "user3@studentmail.oru.se" },
                    { "85c0b660-8a76-4ff3-ad13-1c078ab48093", 0, "7c2f983d-a4f9-4769-ba27-6c1bbd7a77cc", "Person", "user4@studentmail.oru.se", false, "user", false, "4", false, null, null, "user4@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEGhKDQClIrzQ7GV26yAQ8H85+NGri8y4UbCTYcZDHQ3sWlL4inmW3JT2UPJyo1kKFg==", null, false, "e215a957-515f-41cb-98f5-afef4cca7df9", false, false, "user4@studentmail.oru.se" },
                    { "6ed40ddb-0e60-4acd-b646-b68a0c7a8c79", 0, "362f6226-db7a-4712-ae9f-a857aefaaa18", "Person", "user5@studentmail.oru.se", false, "user", false, "5", false, null, null, "user5@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAELKJVRdD6irX8H14e/oRVtC3jQGwZyPTfvB+JekZt57ADtAs3NharFVcLBnIgS1sTA==", null, false, "5cc2f642-856f-4084-ba82-5eec20062db1", false, false, "user5@studentmail.oru.se" },
                    { "4552d1f7-1993-4c58-abac-5115e9626d72", 0, "4f939f1d-bc61-4e74-a9b2-8c821ea17fde", "Person", "user6@studentmail.oru.se", false, "user", false, "6", false, null, null, "user6@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAELAgJON7XyjY1EsKuglQcKGL5z6DzZ/g4qlh2lJmQNv5xMB21ZbbMXtslrnyL2Y2iw==", null, false, "e3cf1a8b-b6b3-419e-8bc1-400574727698", false, false, "user6@studentmail.oru.se" },
                    { "742eac75-a7fe-4e4d-bce1-5b3f1b865167", 0, "f835a7c4-747d-4c5b-b41f-d3ec141c227d", "Person", "user7@studentmail.oru.se", false, "user", false, "7", false, null, null, "user7@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEJ/bCF0vkxm52GVeIZwWDOS3LobdOGtCS7f/axwdepk2mTFTtc8qEGFxLJGJ8UAuBw==", null, false, "eca0e17d-f4dc-4109-bb10-b7229eab1d27", false, false, "user7@studentmail.oru.se" },
                    { "8c8ce09e-f3bd-4ceb-9a4a-cc3b1f5be925", 0, "ae45d04f-72d6-45de-a4c5-f5a35d14d518", "Person", "user8@studentmail.oru.se", false, "user", false, "8", false, null, null, "user8@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEB83Z1ovAZnrRpI558u7d+q9vVcgQ4KLxd1CoJTGZAz2ji1/RFcJjWPSxCA7ts3J9A==", null, false, "01c52292-c944-4c7e-8248-c798b1175466", false, false, "user8@studentmail.oru.se" },
                    { "7f97da13-97a7-4046-945e-f13fbe2fef19", 0, "c3090b25-60de-4a37-80e5-586c0ed5141f", "Person", "user9@studentmail.oru.se", false, "user", false, "9", false, null, null, "user9@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAENhvTDDxQQmwmBkGJRuY0J7OeNr6zlGVyCCloSy6BnxOkBW34BfXW4IA14YM5P5TLA==", null, false, "00863ca9-7827-44ca-8e4a-dcfb7c6dc97e", false, false, "user9@studentmail.oru.se" },
                    { "27a4c2a8-5f28-493b-9ede-beeefa96286b", 0, "5fcbb9ea-954f-42e3-8386-e6d2df66ade0", "Person", "user10@studentmail.oru.se", false, "user", false, "10", false, null, null, "user10@STUDENTMAIL.ORU.SE", "AQAAAAEAACcQAAAAEE9CajS4QWMQ1yLvZSyPtf8iYadFLjijqksg4imREM8/oLrQDUdU2KUevPQp3xKnYA==", null, false, "38c69be8-227b-4157-bfeb-d2357c89aa8d", false, false, "user10@studentmail.oru.se" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostCategory_CategoriesId",
                table: "BlogPostCategory",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_AuthorId",
                table: "BlogPosts",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CreatorId",
                table: "Categories",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPerson_ParticipantsId",
                table: "CategoryPerson",
                column: "ParticipantsId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogPostId",
                table: "Comments",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_FileUpload_BlogPostId",
                table: "FileUpload",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingDatePerson_MeetingDateRequestsId",
                table: "MeetingDatePerson",
                column: "MeetingDateRequestsId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingDates_MeetingId",
                table: "MeetingDates",
                column: "MeetingId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingPerson_RecipientsId",
                table: "MeetingPerson",
                column: "RecipientsId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingPerson1_NotAttendingId",
                table: "MeetingPerson1",
                column: "NotAttendingId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_FinalDateId",
                table: "Meetings",
                column: "FinalDateId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_HostId",
                table: "Meetings",
                column: "HostId");

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingDatePerson_MeetingDates_MeetingDateRequestsId",
                table: "MeetingDatePerson",
                column: "MeetingDateRequestsId",
                principalTable: "MeetingDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingPerson_Meetings_MeetingRequestsId",
                table: "MeetingPerson",
                column: "MeetingRequestsId",
                principalTable: "Meetings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingPerson1_Meetings_NotAttendingId",
                table: "MeetingPerson1",
                column: "NotAttendingId",
                principalTable: "Meetings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_MeetingDates_FinalDateId",
                table: "Meetings",
                column: "FinalDateId",
                principalTable: "MeetingDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_AspNetUsers_HostId",
                table: "Meetings");

            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_MeetingDates_FinalDateId",
                table: "Meetings");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BlogPostCategory");

            migrationBuilder.DropTable(
                name: "CategoryPerson");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "FileUpload");

            migrationBuilder.DropTable(
                name: "MeetingDatePerson");

            migrationBuilder.DropTable(
                name: "MeetingPerson");

            migrationBuilder.DropTable(
                name: "MeetingPerson1");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MeetingDates");

            migrationBuilder.DropTable(
                name: "Meetings");
        }
    }
}
