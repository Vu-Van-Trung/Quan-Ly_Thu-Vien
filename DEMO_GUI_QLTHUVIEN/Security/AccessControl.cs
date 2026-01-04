    using System;
using System.Collections.Generic;

namespace DoAnDemoUI.Security
{
    public static class AccessControl
    {
        public const string RoleAdmin = "Quản trị viên";
        public const string RoleLibrarianHead = "Thủ thư trưởng";
        public const string RoleLibrarian = "Thủ thư";
        public const string RoleStaff = "Nhân viên";
        public const string RoleIntern = "Thực tập sinh"; // Treat as Staff usually

        // Define permissions maps
        // Key: Menu/Feature Key. Value: List of allowed roles.
        // If a key is not in map, it acts as "Public" or "Admin Only" depending on policy. 
        // Let's assume strict allowlist.
        
        private static readonly Dictionary<string, List<string>> _permissions = new Dictionary<string, List<string>>
        {
            // Full Admin Capabilities
            { "ManageAccounts", new List<string> { RoleAdmin } },
            { "Settings", new List<string> { RoleAdmin } },
            { "ManageStaff", new List<string> { RoleAdmin } },
            
            // Librarian Level (includes Admin)
            { "ManageFines", new List<string> { RoleAdmin, RoleLibrarianHead, RoleLibrarian } },
            { "Reports", new List<string> { RoleAdmin, RoleLibrarianHead, RoleLibrarian } },
            { "ViewLogs", new List<string> { RoleAdmin, RoleLibrarianHead, RoleLibrarian } },
            
            // Staff Level (includes Admin/Librarian)
            { "ManageBooks", new List<string> { RoleAdmin, RoleLibrarianHead, RoleLibrarian, RoleStaff, RoleIntern } },
            { "ManageLoans", new List<string> { RoleAdmin, RoleLibrarianHead, RoleLibrarian, RoleStaff, RoleIntern } },
            { "ManageMembers", new List<string> { RoleAdmin, RoleLibrarianHead, RoleLibrarian, RoleStaff, RoleIntern } },
            { "ManagePublishers", new List<string> { RoleAdmin, RoleLibrarianHead, RoleLibrarian } }, // Usually Librarian task?
            { "ManageAuthors", new List<string> { RoleAdmin, RoleLibrarianHead, RoleLibrarian } }     // Usually Librarian task?
        };

        public static bool CanAccess(string featureKey, string userRole)
        {
            if (string.IsNullOrEmpty(userRole)) return false;
            
            // normalize role
            // userRole = userRole.Trim(); 
            
            if (_permissions.ContainsKey(featureKey))
            {
                return _permissions[featureKey].Contains(userRole);
            }
            
            // Default Deny if not listed
            return false; 
        }

        public static bool IsAdmin(string role) => role == RoleAdmin;
        public static bool IsLibrarian(string role) => role == RoleLibrarian || role == RoleLibrarianHead;
        public static bool IsStaff(string role) => role == RoleStaff || role == RoleIntern;
    }
}
