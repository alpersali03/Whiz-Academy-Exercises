USE FITNESSMANAGEMENTSYSTEM

INSERT INTO NUTRITIONPLANS
	VALUES (50, 20, 100),
       (2, 25, 120),
       (3, 30, 140),
       (4, 22, 110),
       (5, 35, 150),
       (6, 28, 130),
       (7, 40, 180),
       (8, 18, 90),
       (9, 26, 125),
       (10, 32, 135),
       (11, 38, 170),
       (12, 24, 115),
       (13, 29, 145),
       (14, 21, 105),
       (15, 27, 120);

INSERT INTO MEMBERS (MemberID, "Name", MembersAge, MembersGender, MembersPhoneNumber, JoinDate)
VALUES
(1, 'Alper', 21, 'male', 333333333, 2025-01-29),
(2, 'Ivan', 21, 'male', 343434343, 2025-01-20),
(3, 'Aleks', 21, 'male', 545454545, 2025-01-19),
(4, 'Goso', 21, 'male', 646464646, 2025-01-15),
(5, 'Miro', 21, 'male', 777777777, 2025-01-18),
(6, 'Serdar', 21, 'male', 999999999, 2025-01-17),
(7, 'Aleksey', 21, 'male', 666666666, 2025-01-14),
(8, 'Hakan', 21, 'male', 1010101010, 2025-01-03),
(9, 'Alpay', 21, 'male', 57635778997, 2025-01-09),
(10, 'Okay', 21, 'male', 3737373737, 2025-01-11);

INSERT INTO TRAINERS (TrainerID, "Name", Specialty, YearsOfExperience)
VALUES(1, 'Aylan', 'MMA', 4),
(2, 'James', 'Boxing', 6),
(3, 'Robert', 'Kickboxing', 5),
(4, 'Daniel', 'Weightlifting', 8),
(5, 'Michael', 'CrossFit', 7),
(6, 'Chris', 'Bodybuilding', 10),
(7, 'Anthony', 'Powerlifting', 9),
(8, 'David', 'Judo', 3),
(9, 'Joseph', 'Wrestling', 6),
(10, 'Benjamin', 'Calisthenics', 4);

INSERT INTO WORKOUTS ( WorkoutID, "Name", "Description" , Duration)
VALUES(1, 'Takedown', 'Training the takedowns', 60),
(2, 'Power Punch', 'Developing punching strength', 45),
(3, 'Grappling Drills', 'Practicing ground control', 50),
(4, 'Endurance Circuit', 'High-intensity workout', 60),
(5, 'Strength Training', 'Building muscle', 75),
(6, 'Speed & Agility', 'Improving movement speed', 40),
(7, 'Core Crusher', 'Focused ab and core', 30),
(8, 'Leg Day', 'Lower body strengthening', 55),
(9, 'Flexibility Flow', 'Stretching and mobility', 35),
(10, 'Cardio Blast', 'High-energy cardio', 50);

INSERT INTO NUTRITIONPLANS ( "Name", CalorieCount, ProteinIntake, MemberId)
VALUES('Lean Bulk Plan', 3200, 180, 1),
('Weight Loss Plan', 1800, 120, 2),
('High Protein Diet', 2500, 200, 3),
('Athlete Performance Plan', 3500, 220, 4),
('Vegan Muscle Gain', 2800, 150, 5),
('Keto Fat Burn', 2000, 130, 6),
('Endurance Fuel', 3000, 160, 7),
('Strength Gain Diet', 3300, 190, 8),
('Balanced Diet Plan', 2500, 140, 9),
('Recovery & Repair Plan', 2700, 170, 10);

INSERT INTO SESSIONSTABLE (SessionDate, AssignedTrainer, WorkoutRoutine, MemberId, TrainerId, WorkoutId)
VALUES (2025-01-29, 'Ivan', 'Strength Training', 1, 1, 4),
(2025-01-20, 'Alex', 'Kickboxing', 2, 2, 3),
(2025-01-19, 'Miro', 'Endurance Circuit', 3, 3, 5),
(2025-01-15, 'Daniel', 'Bodybuilding', 4, 4, 6),
(2025-01-18, 'Chris', 'Power Punch', 5, 5, 2),
(2025-01-17, 'Anthony', 'Core Crusher', 6, 6, 7),
(2025-01-14, 'David', 'Grappling Drills', 7, 7, 8),
(2025-01-03, 'Joseph', 'Flexibility Flow', 8, 8, 9),
(2025-01-09, 'Benjamin', 'Cardio Blast', 9, 9, 10),
(2025-01-11, 'James', 'Strength Gain Diet', 10, 10, 1);