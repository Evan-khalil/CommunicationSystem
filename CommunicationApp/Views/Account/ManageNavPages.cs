﻿using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CommunicationApp.Views.Account
{
    public static class ManageNavPages
    {
        public static string Index => "Index";
        public static string Email => "Email";
        public static string ChangePassword => "ChangePassword";
        public static string DeleteUser => "DeleteUser";
        public static string Role => "Role";

        public static string IndexNavClass(ViewContext viewContext) => PageNavClass(viewContext, Index);
        public static string EmailNavClass(ViewContext viewContext) => PageNavClass(viewContext, Email);
        public static string ChangePasswordNavClass(ViewContext viewContext) => PageNavClass(viewContext, ChangePassword);
        public static string DeleteUserNavClass(ViewContext viewContext) => PageNavClass(viewContext, DeleteUser);
        public static string RoleNavClass(ViewContext viewContext) => PageNavClass(viewContext, Role);

        private static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string
                             ?? System.IO.Path.GetFileNameWithoutExtension(viewContext.ActionDescriptor.DisplayName);
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
        }
    }
}