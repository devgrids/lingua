/*
  Author: Yordy Leonidas MV

  This script creates a table named 'profile' to store user language proficiency information and inserts sample data into it.

  Table Structure:
    - profile_id:           Primary key, auto-incremented integer
    - user_id:              ID of the user (foreign key referencing '[user]' table)
    - english_level:        English language level (1: Beginner, 2: Intermediate, 3: Advanced)
    - grammar_level:        Grammar level in English (1: Beginner, 2: Intermediate, 3: Advanced)
    - writing_level:        Writing level in English (1: Beginner, 2: Intermediate, 3: Advanced)
    - listening_level:      Listening level in English (1: Beginner, 2: Intermediate, 3: Advanced)
    - speaking_level:       Speaking level in English (1: Beginner, 2: Intermediate, 3: Advanced)
    - learned_vocabulary:   Learned vocabulary size in English
    - study_time_per_day:   Time dedicated to English study per day in minutes
    - vocabulary_size:      Vocabulary size in English
    - profile_picture:      Profile picture (VARBINARY(MAX))

*/

-- Create profile table
CREATE TABLE profile (
    profile_id INT IDENTITY(1,1) PRIMARY KEY,
    user_id INT,
    FOREIGN KEY (user_id) REFERENCES [user](user_id),
    english_level TINYINT, -- 1: Beginner, 2: Intermediate, 3: Advanced
    grammar_level TINYINT, -- 1: Beginner, 2: Intermediate, 3: Advanced
    writing_level TINYINT, -- 1: Beginner, 2: Intermediate, 3: Advanced
    listening_level TINYINT, -- 1: Beginner, 2: Intermediate, 3: Advanced
    speaking_level TINYINT, -- 1: Beginner, 2: Intermediate, 3: Advanced
    learned_vocabulary INT, -- Learned vocabulary size in English
    study_time_per_day INT, -- Time dedicated to English study per day in minutes
    vocabulary_size INT, -- Vocabulary size in English
    profile_picture VARBINARY(MAX) -- Profile picture
);

-- Insert sample data into profile table
INSERT INTO profile (user_id, english_level, grammar_level, writing_level, listening_level, speaking_level, learned_vocabulary, study_time_per_day, vocabulary_size, profile_picture)
VALUES (1, 2, 2, 2, 2, 2, 500, 60, 2500, NULL);

INSERT INTO profile (user_id, english_level, grammar_level, writing_level, listening_level, speaking_level, learned_vocabulary, study_time_per_day, vocabulary_size, profile_picture)
VALUES (2, 1, 1, 1, 1, 1, 300, 30, 1000, NULL);

INSERT INTO profile (user_id, english_level, grammar_level, writing_level, listening_level, speaking_level, learned_vocabulary, study_time_per_day, vocabulary_size, profile_picture)
VALUES (3, 3, 3, 3, 3, 3, 700, 90, 5000, NULL);

INSERT INTO profile (user_id, english_level, grammar_level, writing_level, listening_level, speaking_level, learned_vocabulary, study_time_per_day, vocabulary_size, profile_picture)
VALUES (4, 2, 2, 2, 2, 2, 400, 45, 2000, NULL);

INSERT INTO profile (user_id, english_level, grammar_level, writing_level, listening_level, speaking_level, learned_vocabulary, study_time_per_day, vocabulary_size, profile_picture)
VALUES (5, 2, 2, 2, 2, 2, 600, 60, 3000, NULL);

INSERT INTO profile (user_id, english_level, grammar_level, writing_level, listening_level, speaking_level, learned_vocabulary, study_time_per_day, vocabulary_size, profile_picture)
VALUES (6, 1, 1, 1, 1, 1, 200, 20, 500, NULL);

INSERT INTO profile (user_id, english_level, grammar_level, writing_level, listening_level, speaking_level, learned_vocabulary, study_time_per_day, vocabulary_size, profile_picture)
VALUES (7, 3, 3, 3, 3, 3, 800, 120, 6000, NULL);

INSERT INTO profile (user_id, english_level, grammar_level, writing_level, listening_level, speaking_level, learned_vocabulary, study_time_per_day, vocabulary_size, profile_picture)
VALUES (8, 2, 2, 2, 2, 2, 350, 40, 1500, NULL);

INSERT INTO profile (user_id, english_level, grammar_level, writing_level, listening_level, speaking_level, learned_vocabulary, study_time_per_day, vocabulary_size, profile_picture)
VALUES (9, 2, 2, 2, 2, 2, 450, 50, 1800, NULL);

INSERT INTO profile (user_id, english_level, grammar_level, writing_level, listening_level, speaking_level, learned_vocabulary, study_time_per_day, vocabulary_size, profile_picture)
VALUES (10, 2, 2, 2, 2, 2, 550, 55, 2200, NULL);

-- Display profile table data
SELECT * FROM profile;