CREATE DATABASE SchoolDB;
GO
USE SchoolDB;
GO

-- Students Table
CREATE TABLE Students (
    student_id INT PRIMARY KEY IDENTITY(1,1),
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    age INT CHECK (age > 0),
    email VARCHAR(100) UNIQUE
);
GO

-- Departments Table
CREATE TABLE Departments (
    department_id INT PRIMARY KEY IDENTITY(1,1),
    department_name VARCHAR(100) NOT NULL,
    building VARCHAR(50),
    budget DECIMAL(10,2),
    phone VARCHAR(20)
);
GO

-- Teachers Table
CREATE TABLE Teachers (
    teacher_id INT PRIMARY KEY IDENTITY(1,1),
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    hire_date DATE,
    department_id INT,
    FOREIGN KEY (department_id) REFERENCES Departments(department_id)
);
GO

-- Courses Table
CREATE TABLE Courses (
    course_id INT PRIMARY KEY IDENTITY(1,1),
    course_name VARCHAR(100) NOT NULL,
    department_id INT,
    teacher_id INT,
    credits INT CHECK (credits > 0),
    FOREIGN KEY (department_id) REFERENCES Departments(department_id),
    FOREIGN KEY (teacher_id) REFERENCES Teachers(teacher_id)
);
GO

-- Enrollments Table (many-to-many between Students and Courses)
CREATE TABLE Enrollments (
    enrollment_id INT PRIMARY KEY IDENTITY(1,1),
    student_id INT,
    course_id INT,
    enrollment_date DATE DEFAULT GETDATE(),
    grade CHAR(2) CHECK (grade IN ('A', 'B', 'C', 'D', 'F', 'W')),
    FOREIGN KEY (student_id) REFERENCES Students(student_id),
    FOREIGN KEY (course_id) REFERENCES Courses(course_id)
);
GO
-- Insert more Departments
INSERT INTO Departments (department_name, building, budget, phone) VALUES
('Biology', 'Science Block', 350000, '555-9988'),
('History', 'Humanities Hall', 280000, '555-3344'),
('Philosophy', 'Humanities Hall', 200000, '555-7788'),
('Engineering', 'Tech Center', 600000, '555-1122');
GO
SELECT *FROM Departments
 
-- Insert more Teachers
INSERT INTO Teachers (first_name, last_name, hire_date, department_id) VALUES
('Richard', 'Feynman', '2005-09-05', 3),
('Isaac', 'Newton', '2000-01-15', 2),
('Ada', 'Lovelace', '2019-11-30', 1),
('Charles', 'Darwin', '2017-08-12', 5),
('Plato', 'Aristotle', '2016-05-20', 6),
('Nikola', 'Tesla', '2015-06-23', 4),
('Elon', 'Musk', '2020-03-12', 4);
GO
 SELECT *FROM Teachers

-- Insert more Courses
INSERT INTO Courses (course_name, department_id, teacher_id, credits) VALUES
('Evolutionary Biology', 5, 8, 3),
('Modern Philosophy', 6, 9, 4),
('Electrical Engineering', 4, 10, 5),
('Rocket Science', 4, 11, 5),
('Number Theory', 2, 6, 3),
('History of Ancient Civilizations', 6, 9, 3);
GO
SELECT *FROM Courses
 
-- Insert more Students
INSERT INTO Students (first_name, last_name, age, email) VALUES
('Alice', 'Johnson', 20, 'alice@example.com'),
('Bob', 'Williams', 22, 'bob@example.com'),
('Charlie', 'Brown', 21, 'charlie@example.com'),
('Diana', 'Adams', 23, 'diana@example.com'),
('Eve', 'Miller', 24, 'eve@example.com'),
('Frank', 'White', 19, 'frank@example.com'),
('Grace', 'Hopper', 22, 'grace@example.com'),
('Hank', 'Green', 25, 'hank@example.com'),
('Irene', 'Curie', 20, 'irene@example.com'),
('Jack', 'Sparrow', 26, 'jack@example.com'),
('Katie', 'Wright', 21, 'katie@example.com'),
('Leo', 'Messi', 24, 'leo@example.com'),
('Maria', 'Garcia', 23, 'maria@example.com'),
('Noah', 'Smith', 22, 'noah@example.com'),
('Olivia', 'Taylor', 21, 'olivia@example.com'),
('Paul', 'Walker', 25, 'paul@example.com'),
('Quincy', 'Jones', 23, 'quincy@example.com'),
('Rachel', 'Adams', 22, 'rachel@example.com'),
('Steve', 'Jobs', 27, 'steve@example.com'),
('Tony', 'Stark', 29, 'tony@example.com');
GO
SELECT *FROM Students
 
SELECT *FROM Courses

-- Insert more Enrollments (many-to-many between Students and Courses)
INSERT INTO Enrollments (student_id, course_id, enrollment_date, grade) VALUES
(1, 1, '2024-01-10', 'A'),
(1, 3, '2024-01-12', 'B'),
(2, 1, '2024-01-15', 'A'),
(2, 2, '2024-01-20', 'C'),
(3, 3, '2024-01-25', 'B'),
(4, 4, '2024-02-01', 'A'),
(5, 5, '2024-02-03', 'A'),
(6, 6, '2024-02-05', 'B'),
(7, 1, '2024-02-08', 'C'),
(8, 2, '2024-02-10', 'B'),
(9, 3, '2024-02-12', 'A'),
(10, 4, '2024-02-15', 'B'),
(11, 5, '2024-02-17', 'A'),
(12, 6, '2024-02-20', 'B'),
(13, 7, '2024-02-23', 'C'),
(14, 1, '2024-02-25', 'A'),
(15, 2, '2024-02-28', 'C'),
(16, 3, '2024-03-02', 'B'),
(17, 4, '2024-03-05', 'A'),
(18, 5, '2024-03-08', 'B'),
(19, 6, '2024-03-10', 'A'),
(20, 7, '2024-03-12', 'C'),
(1, 4, '2024-03-15', 'B'),
(2, 5, '2024-03-18', 'A'),
(3, 6, '2024-03-20', 'C'),
(4, 7, '2024-03-22', 'A'),
(5, 1, '2024-03-25', 'B'),
(6, 2, '2024-03-28', 'C'),
(7, 3, '2024-03-30', 'A'),
(8, 4, '2024-04-01', 'B'),
(9, 5, '2024-04-03', 'C'),
(10, 6, '2024-04-05', 'A'),
(11, 7, '2024-04-08', 'B'),
(12, 1, '2024-04-10', 'C'),
(13, 2, '2024-04-12', 'A'),
(14, 3, '2024-04-15', 'B'),
(15, 4, '2024-04-18', 'C'),
(16, 5, '2024-04-20', 'A'),
(17, 6, '2024-04-22', 'B'),
(18, 7, '2024-04-25', 'C'),
(19, 1, '2024-04-28', 'A'),
(20, 2, '2024-05-01', 'B');
GO

SELECT *FROM Enrollments