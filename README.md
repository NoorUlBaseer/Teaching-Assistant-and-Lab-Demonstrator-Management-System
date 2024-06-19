# Teaching Assistant (TA) and Lab Demonstrator (LD) Management System

## Description
The Teaching Assistant (TA) and Lab Demonstrator (LD) Management System is a WinForms application developed in C# with a Microsoft SQL Server database. It aims to streamline the management of TAs and LDs within an educational institution, providing features for user authentication, course management, and user administration.

## Features
- **User Authentication:** Secure login system for administrators, faculty members, TAs, and LDs.
- **Admin Dashboard:** Manage users, courses, and departments efficiently through a robust interface.
- **Course Management:** Add, update, and view courses, assign faculty, and define course types.
- **User Management:** Add and manage students and faculty members, including linking users to their respective departments.
- **Department Management:** Manage departments and their faculties and courses.
- **Data Display:** Use DataGridView to display detailed information about students, faculty, and courses.
- **Error Handling:** Robust error handling and user prompts to ensure smooth user experience and data consistency.

## Technical Details
- **Programming Language:** C#
- **Framework:** .NET Framework for WinForms
- **Database:** Microsoft SQL Server
- **Development Environment:** Visual Studio
- **Key Technologies:** ADO.NET for database operations, WinForms for user interface design

## Installation

### Prerequisites
- Microsoft Visual Studio
- Microsoft SQL Server

### Setup
1. **Clone the repository:** Clone this repository to your local machine using Git:
   ```
   git clone https://github.com/NoorUlBaseer/Teaching-Assistant-and-Lab-Demonstrator-Management-System
   ```
2. **Open the project:** Open the project in Visual Studio or open its `.sln` file.
3. **Database Configuration:** Create a database in SQL Server and name it as `TA_and_Lab_Demonstrator_Management_System` to match the connection string configuration and setup the tables according to the schema provided below.
4. **Build and run the project.**

## Usage

### Administrator
- **Login:** Use the admin credentials to log in.
- **Dashboard:** Access the admin dashboard to manage users, courses, and departments.
- **View Details:** View personal admin details.
- **Add Students:**
  - Navigate to the "Add Student" tab.
  - Fill in the student details (username, password, name, email, department, GPA).
  - Click "Add Student".
- **Add Faculty:**
  - Navigate to the "Add Faculty" tab.
  - Fill in the faculty details (username, password, name, department).
  - Click "Add Faculty".
- **Add Courses:**
  - Navigate to the "Add Course" tab.
  - Fill in the course details (course name, faculty, department, strength, course type).
  - Click "Add Course".
- **View Faculty and Student Details:** Click the "Refresh Faculty" or "Refresh Students" button to view detailed information.
- **Logout:** Click the "Logout" button to return to the login screen.

### Faculty
- **Login:** Use the faculty credentials to log in.
- **Dashboard:** Access the faculty dashboard to view assigned courses and personal details.
- **View Details:** View personal faculty details.
- **Add and Remove TAs/LDs:**
  - Navigate to the appropriate section to add or remove TAs/LDs.
  - Fill in the details of the TA/LD to be added or removed.
- **Assign Tasks to TAs/LDs:**
  - Navigate to the task assignment section.
  - Assign tasks to the respective TAs and LDs.
- **View TA/LD Details:** View the details of assigned TAs and LDs.
- **Logout:** Click the "Logout" button to return to the login screen.

### TA and LD
- **Login:** Use the TA or LD credentials to log in.
- **Dashboard:** Access the TA/LD dashboard to view personal details and assigned tasks.
- **View Details:** View personal TA/LD details.
- **View Assigned Tasks:** View the tasks assigned by the faculty.
- **Update Task Progress:**
  - Navigate to the task update section.
  - Update the progress of the assigned tasks.
- **Logout:** Click the "Logout" button to return to the login screen.

## Database Schema
The database schema consists of the following tables:
1. **Credentials:** (`credential_id` (PK), `username`, `password`, `user_id` (FK))

2. **User:** (`user_id` (PK), `name`, `email_address`)

3. **Admin:** (`admin_id` (PK), `user_id` (FK))

4. **Faculty:** (`faculty_id` (PK), `department_id` (FK), `user_id` (FK))

5. **Student:** (`student_id` (PK), `department_id` (FK), `user_id` (FK))

6. **LabDemonstrator:** (`LD_id` (PK), `course_id` (FK), `student_id` (FK))

7. **TeacherAssistant:** (`TA_id` (PK), `course_id` (FK), `student_id` (FK))

8. **Transcript:** (`transcript_id` (PK), `gpa`, `student_id` (FK))

9. **Department:** (`department_id` (PK), `department_name`)

10. **CourseType:** (`course_type_id` (PK), `course_type_name`, `payment_per_student`)

11. **Course:** (`course_id` (PK), `course_name`, `strength`, `faculty_id` (FK), `course_type_id` (FK), `department_id` (FK))

12. **Task:** (`task_id` (PK), `task_type`, `quantity`, `priority_level`, `status`, `deadline`, `course_id` (FK), `faculty_id` (FK), `TA_id` (FK), `LD_id` (FK))

13. **Report:** (`report_id` (PK), `report_name`, `report_description`, `generation_date`, `admin_id` (FK), `faculty_id` (FK))

## Contributing
Contributions are welcome! Please fork the repository and create a pull request with your changes.
