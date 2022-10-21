﻿using CommunicationApp.Models;
using CommunicationApp.Repository;
using CommunicationApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationApp.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {
        private readonly ICategoryRepository _category;
        private readonly IPersonRepository _person;
        private readonly UserManager<Person> _userManager;

        public ProjectController(UserManager<Person> userManager, ICategoryRepository categoryRepository, IPersonRepository personRepository)
        {
            _category = categoryRepository;
            _person = personRepository;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
            var isAdminUser = User.IsInRole("Admin");

            var categories = _category.GetCategoriesForParticipant(null, userId, isAdminUser);

            var categoryViewModels = categories
                .Where(c => c.Type == BlogType.Education || c.Type == BlogType.Research)
                .OrderBy(c => c.Type)
                .ThenBy(c => c.Name)
                .Select(c => new CategoryViewModel { Id = c.Id, Name = c.Name, Type = c.Type, Creator = c.Creator });

            ViewData["InfoMessage"] = TempData["InfoMessage"]?.ToString();
            ViewData["ErrorMessage"] = TempData["ErrorMessage"]?.ToString();

            return View(categoryViewModels);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var categoryViewModel = new CategoryViewModel
            {
                Id = Guid.NewGuid()
            };

            return View(categoryViewModel);
        }

        public async Task<IActionResult> Create(CategoryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", model);
            }

            var categoryExists = await _category.GetAll();
            if (categoryExists.Where(c => c.Type == BlogType.Education && c.Type == BlogType.Research).Any(c => c.Name.ToLower() == model.Name.ToLower() && c.Type == model.Type))
            {
                var type = model.Type == BlogType.Education ? "Utbildning" : (model.Type == BlogType.Research ? "Forskning" : null);
                model.ErrorMessage = $"Det finns redan ett projekt med namnet '{model.Name}' under enhet '{type}'.";
                return View("Create", model);
            }

            var currentUser = await _userManager.GetUserAsync(User);
            var category = new Category
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Type = model.Type,
                Creator = currentUser,
                Participants = new List<Person>()
            };

            currentUser.Subscriber = true;

            await _category.Add(category);
            await _category.Save();

            TempData["InfoMessage"] = $"Projektet '{category.Name}' har skapats.";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var category = _category.FindById(id);
            if (category == null)
                return RedirectToAction("Index");

            var model = new EditCategoryViewModel
            {
                Id = category.Id,
                Name = category.Name,
                AllUsers = await GetAllUsers(category.Creator?.Id),
                Participants = GetCurrentParticipants(category)
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditCategoryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", model);
            }

            var category = _category.FindById(model.Id);
            if (category == null)
            {
                TempData["ErrorMessage"] = $"Kan ej ändra okänt projekt {category.Name}.";
                return RedirectToAction("Index");
            }

            var categories = await _category.GetAll();
            if (categories.Where(c => c.Type == BlogType.Education && c.Type == BlogType.Research).Any(c => c.Name.ToLower() == model.Name.ToLower() && c.Type == category.Type))
            {
                var type = category.Type == BlogType.Education ? "Utbildning" : (category.Type == BlogType.Research ? "Forskning" : null);
                model.ErrorMessage = $"Det finns redan ett projekt med namnet '{model.Name}' under enhet '{type}'.";
                return View("Edit", model);
            }

            category.Name = model.Name;
            category.Participants = GetUpdatedParticipants(model.ParticipantIds);

            await _category.Save();

            TempData["InfoMessage"] = $"Projektet '{category.Name}' har ändrats.";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var category = await _category.GetById(id);
            if (category != null)
            {
                if (_category.HasBlogPosts(category))
                {
                    TempData["ErrorMessage"] = $"Projektet {category.Name} används i bloggposter och kan inte raderas.";
                    return RedirectToAction("Index");
                }

                _category.Remove(category.Id);
                await _category.Save();
                TempData["InfoMessage"] = $"Projektet '{category.Name}' har raderats.";
            }

            return RedirectToAction("Index");
        }

        private async Task<List<SelectListItem>> GetAllUsers(string creatorUserId)
        {
            List<Person> persons = await _person.GetAll();
            return persons
                .Where(p => p.IsDeleted == false && p.Id != creatorUserId)
                .Select(u => new SelectListItem { Value = u.Id, Text = $"{u.FullUserName}" })
                .ToList();
        }

        private List<SelectListItem> GetCurrentParticipants(Category category)
        {
            return category.Participants
                .Select(u => new SelectListItem { Value = u.Id, Text = $"{u.FullUserName}" })
                .ToList();
        }

        private List<Person> GetUpdatedParticipants(IEnumerable<string> participantIds)
        {
            if (participantIds == null || !participantIds.Any())
                return new List<Person>();

            return _person.Where(p => participantIds.Contains(p.Id)).ToList();
        }
    }
}