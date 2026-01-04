# Project Features

This document outlines the implemented features of the Library Management System (Quan Ly Thu Vien).

## 1. System & Security
- **Authentication**:
  - Secure Login with Username/Password.
  - Role-Based Access Control (RBAC) (Admin vs. Staff).
  - Logout functionality.
- **User Account Management**:
  - Create, Update, Lock/Unlock User Accounts.
  - Reset Passwords.
  - Assign Roles (Admin/Staff).
- **Data Security**:
  - Encryption for sensitive Member data (Full Name).
  - Password hashing.
- **System Logging**:
  - Records important actions (Login, Add/Edit/Delete records).
  - Viewable System Diary (`QuanLiNhatKy`).

## 2. Book Management (`QuanLiSach`)
- **CRUD Operations**:
  - **Add**: Create new books with auto-generated ID. Validates input (Title, Quantity, Price, etc.).
  - **Edit**: Modify book details and stock levels.
  - **Delete**: Remove books (with validation for existing loans).
- **Search & Filter**:
  - Search books by Title or ID.
- **Inventory Control**:
  - Track "Quantity In Stock".
  - Manage Book Status (Available, Out of Stock, Discontinued).
- **Metadata Management**:
  - Manage Authors (`QuanLiTacGia`).
  - Manage Categories (`Category`).
  - Manage Publishers (`FormPublisher`).

## 3. Member (Reader) Management (`FormMember`)
- **Reader Profiles**:
  - Manage personal information (Encrypted Name, Phone, Email, Address).
- **Membership Status**:
  - Track Card Expiry Date.
  - Lock/Unlock Member cards.

## 4. Circulation (Loans & Returns) (`FormLoan`)
- **Borrowing (Loans)**:
  - **Smart Validation**:
    - Check if Member is Active.
    - Check if Membership is Expired.
    - Check for Unpaid Fines.
    - Check for Overdue Books.
    - Enforce Max 5 Books limit.
  - **Process**:
    - Auto-add books to an existing active loan or create a new one.
    - Auto-calculate Due Date (Default +14 days).
- **Returning**:
  - **Condition Check**: Assess book condition (Good, Damaged, Lost) via `FormConditionCheck`.
  - **Fines**: Integrated with Fine Management (`FormFine`) for late returns or damages.
- **History & Tracking**:
  - View detailed history of borrowed books per loan.
  - Filter loans by Member.

## 5. Staff Management (`FormStaff`)
- Manage Staff profiles.
- Track Staff positions/roles.

## 6. Fines & Penalties (`FormFine`)
- Calculate fines based on Late Returns or Book Condition (Lost/Damaged).
- Track Payment Status (Paid/Unpaid).
- Process Fine Payments.

## 7. Reporting & Analytics (`FormReport`)
- **Date Filtering**: Generate reports for specific time ranges.
- **Available Reports**:
  - **Most Borrowed Books**: Top 20 popular books.
  - **Active Members**: Top 20 readers with most activity.
  - **Category Statistics**: Distribution of books and loans by genre.
  - **Fine Revenue**: Financial report on collected and pending fines.
  - **Inventory Status**: Stock levels with **Low Stock** (<=5) and **Out of Stock** alerts.

## 8. User Interface (UI)
- **Modern Design**: Utilizing Guna.UI2 framework.
- **MDI Layout**: Tab/Container-based navigation.
- **Responsive Controls**: Search bars, DataGrids with sorting/filtering, validation feedback.
