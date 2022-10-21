using System;
using System.Collections.Generic;
using CommunicationApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CommunicationApp.Data
{
    public static class DatabaseSeeder
    {
        public static void SeedDatabase(this ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<Person>();


            Person personuser1 = new Person
            {
                UserName = "user1@studentmail.oru.se",
                NormalizedUserName = "user1@STUDENTMAIL.ORU.SE",
                Email = "user1@studentmail.oru.se",
                PasswordHash = hasher.HashPassword(null, "Hej123!!"),
                FirstName = "user",
                LastName = "1",
                Subscriber = false
            };
            Person personuser2 = new Person
            {
                UserName = "user2@studentmail.oru.se",
                NormalizedUserName = "user2@STUDENTMAIL.ORU.SE",
                Email = "user2@studentmail.oru.se",
                PasswordHash = hasher.HashPassword(null, "Hej123!!"),
                FirstName = "user",
                LastName = "2",
                Subscriber = false
            };
            Person personuser3 = new Person
            {
                UserName = "user3@studentmail.oru.se",
                NormalizedUserName = "user3@STUDENTMAIL.ORU.SE",
                Email = "user3@studentmail.oru.se",
                PasswordHash = hasher.HashPassword(null, "Hej123!!"),
                FirstName = "user",
                LastName = "3",
                Subscriber = false
            };
            Person personuser4 = new Person
            {
                UserName = "user4@studentmail.oru.se",
                NormalizedUserName = "user4@STUDENTMAIL.ORU.SE",
                Email = "user4@studentmail.oru.se",
                PasswordHash = hasher.HashPassword(null, "Hej123!!"),
                FirstName = "user",
                LastName = "4",
                Subscriber = false
            };
            Person personuser5 = new Person
            {
                UserName = "user5@studentmail.oru.se",
                NormalizedUserName = "user5@STUDENTMAIL.ORU.SE",
                Email = "user5@studentmail.oru.se",
                PasswordHash = hasher.HashPassword(null, "Hej123!!"),
                FirstName = "user",
                LastName = "5",
                Subscriber = false
            };
            Person personuser6 = new Person
            {
                UserName = "user6@studentmail.oru.se",
                NormalizedUserName = "user6@STUDENTMAIL.ORU.SE",
                Email = "user6@studentmail.oru.se",
                PasswordHash = hasher.HashPassword(null, "Hej123!!"),
                FirstName = "user",
                LastName = "6",
                Subscriber = false
            };
            Person personuser7 = new Person
            {
                UserName = "user7@studentmail.oru.se",
                NormalizedUserName = "user7@STUDENTMAIL.ORU.SE",
                Email = "user7@studentmail.oru.se",
                PasswordHash = hasher.HashPassword(null, "Hej123!!"),
                FirstName = "user",
                LastName = "7",
                Subscriber = false
            };
            Person personuser8 = new Person
            {
                UserName = "user8@studentmail.oru.se",
                NormalizedUserName = "user8@STUDENTMAIL.ORU.SE",
                Email = "user8@studentmail.oru.se",
                PasswordHash = hasher.HashPassword(null, "Hej123!!"),
                FirstName = "user",
                LastName = "8",
                Subscriber = false
            };
            Person personuser9 = new Person
            {
                UserName = "user9@studentmail.oru.se",
                NormalizedUserName = "user9@STUDENTMAIL.ORU.SE",
                Email = "user9@studentmail.oru.se",
                PasswordHash = hasher.HashPassword(null, "Hej123!!"),
                FirstName = "user",
                LastName = "9",
                Subscriber = false
            };
            Person personuser10 = new Person
            {
                UserName = "user10@studentmail.oru.se",
                NormalizedUserName = "user10@STUDENTMAIL.ORU.SE",
                Email = "user10@studentmail.oru.se",
                PasswordHash = hasher.HashPassword(null, "Hej123!!"),
                FirstName = "user",
                LastName = "10",
                Subscriber = false
            };

            modelBuilder.Entity<Person>().HasData(personuser1, personuser2, personuser3, personuser4, personuser5, personuser6, personuser7, personuser8, personuser9, personuser10);


            Category cat1 = new Category { Id = Guid.NewGuid(), Name = "AfterWork", Type = BlogType.Informal, Creator = null, BlogPosts = null, Participants = null };
            Category cat2 = new Category { Id = Guid.NewGuid(), Name = "Resor", Type = BlogType.Informal, Creator = null, BlogPosts = null, Participants = null };
            Category cat3 = new Category { Id = Guid.NewGuid(), Name = "Nya kurser", Type = BlogType.Formal, Creator = null, BlogPosts = null, Participants = null };
            Category cat4 = new Category { Id = Guid.NewGuid(), Name = "Information gällande Covid-19", Type = BlogType.Formal, Creator = null, BlogPosts = null, Participants = null };
            Category cat5 = new Category { Id = Guid.NewGuid(), Name = "VT2022-IK207G", Type = BlogType.Education, Creator = null, BlogPosts = null, Participants = null };
            Category cat6 = new Category { Id = Guid.NewGuid(), Name = "HT2021-IK201G", Type = BlogType.Education, Creator = null, BlogPosts = null, Participants = null };
            Category cat7 = new Category { Id = Guid.NewGuid(), Name = "Informatik", Type = BlogType.Research, Creator = null, BlogPosts = null, Participants = null };
            Category cat8 = new Category { Id = Guid.NewGuid(), Name = "Datavetenskap", Type = BlogType.Research, Creator = null, BlogPosts = null, Participants = null };
            Category cat9 = new Category { Id = Guid.NewGuid(), Name = "Användning av IT i verksamhetskontexter", Type = BlogType.Research, Creator = null, BlogPosts = null, Participants = null };

            modelBuilder.Entity<Category>().HasData(cat1, cat2, cat3, cat4, cat5, cat6, cat7, cat8, cat9);


            MeetingDate meetingDate1 = new MeetingDate
            {
                Id = Guid.NewGuid(),
                Attendees = null,
                Start = new DateTime(2021, 05, 04, 12, 15, 00),
                End = new DateTime(2021, 05, 04, 13, 15, 00)
            };
            MeetingDate meetingDate2 = new MeetingDate
            {
                Id = Guid.NewGuid(),
                Attendees = null,
                Start = new DateTime(2021, 05, 15, 13, 30, 00),
                End = new DateTime(2021, 05, 15, 16, 15, 00)
            };
            MeetingDate meetingDate3 = new MeetingDate
            {
                Id = Guid.NewGuid(),
                Attendees = null,
                Start = new DateTime(2021, 05, 20, 14, 30, 00),
                End = new DateTime(2021, 05, 20, 16, 30, 00)
            };

            modelBuilder.Entity<MeetingDate>().HasData(meetingDate1, meetingDate2, meetingDate3);


            Meeting meeting1 = new Meeting
            {
                Id = Guid.NewGuid(),
                Subject = "Parprogrammering",
                Description = "Denna dagen kör vi så det ryker! Vi ska allt se till att bli klara med detta projektet nu!",
                NonAttenders = new List<Person>(),
                Host = null,
                DateRequests = null,
                FinalDate = null,
                Recipients = null
            };
            Meeting meeting2 = new Meeting
            {
                Id = Guid.NewGuid(),
                Subject = "Scrum information",
                Description = "Vi kör en genomgång tillsamman om vad detta skrum är för något.",
                NonAttenders = new List<Person>(),
                Host = null,
                DateRequests = null,
                FinalDate = null,
                Recipients = null
            };
            Meeting meeting3 = new Meeting
            {
                Id = Guid.NewGuid(),
                Subject = "Programmering tillsammans!",
                Description = "Oj, så roligt vi ska ha!",
                NonAttenders = new List<Person>(),
                Host = null,
                DateRequests = null,
                FinalDate = null,
                Recipients = null
            };

            modelBuilder.Entity<Meeting>().HasData(meeting1, meeting2, meeting3);


            BlogPost blog1 = new BlogPost
            {
                Id = Guid.NewGuid(),
                BlogType = BlogType.Research,
                Comments = new List<Comment>(),
                DatePublished = new DateTime(2021, 04, 21, 13, 46, 00),
                DateEdited = new DateTime(2021, 04, 21, 13, 46, 00),
                Files = new List<FileUpload>(),
                Title = "Rubrik",
                Text = "Text..."
            };
            BlogPost blog2 = new BlogPost
            {
                Id = Guid.NewGuid(),
                BlogType = BlogType.Informal,
                Comments = new List<Comment>(),
                DatePublished = new DateTime(2021, 04, 19, 13, 46, 00),
                DateEdited = new DateTime(2021, 04, 19, 13, 46, 00),
                Files = new List<FileUpload>(),
                Title = "Helgens AW",
                Text = "Tack alla för en riktigt underbar AW i helgen! Detta får vi allt göra om. 🍻"
            };

            modelBuilder.Entity<BlogPost>().HasData(blog1, blog2);
        }
    }
}