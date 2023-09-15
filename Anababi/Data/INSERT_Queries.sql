USE AnababiLMS

-- Insert the library
INSERT INTO dbo.[Libraries] (Name)
VALUES ('Anababi');

-- Insert creators
INSERT INTO dbo.[Creators] (FirstName, LastName)
VALUES
    ('William', 'Shakespeare'),
    ('Jane', 'Austen'),
    ('Charles', 'Dickens'),
    ('Leo', 'Tolstoy'),
    ('George', 'Orwell'),
    ('J.K.', 'Rowling'),
    ('Mark', 'Twain'),
    ('F. Scott', 'Fitzgerald'),
    ('Gabriel García', 'Márquez'),
    ('Harper', 'Lee');

-- Insert references (10 digital and 10 physical)
-- Digital References
INSERT INTO dbo.[References] (Title, PublishedOn, ISBN, Type, Genre, CreatorId, Description, Discriminator, LibraryId)
VALUES
    ('Harry Potter and the Sorcerer''s Stone', '1997-01-01', '978-0590353427', 1, 3, 6, 'The first book in the beloved wizarding world saga by J.K. Rowling. Follow the journey of a young wizard, Harry Potter, as he discovers his magical abilities and uncovers the mysteries of his past.', 'DigitalReference', 1),
    ('Harry Potter and the Deathly Hallows', '2007-01-01', '978-0545139700', 1, 3, 6, 'The thrilling and epic conclusion to the Harry Potter series. Join Harry, Ron, and Hermione as they face their ultimate challenge: defeating the dark wizard, Voldemort.', 'DigitalReference', 1),
    ('The Adventures of Huckleberry Finn', '1884-01-01', '978-0142437179', 1, 4, 7, 'Mark Twain''s timeless American novel that follows the adventures of a young boy, Huckleberry Finn, as he travels down the Mississippi River with his friend Jim, an escaped slave, and explores themes of freedom and morality.', 'DigitalReference', 1),
    ('The Adventures of Tom Sawyer', '1876-01-01', '978-0486400778', 1, 4, 7, 'A classic coming-of-age story by Mark Twain, featuring the mischievous Tom Sawyer and his adventures in a small American town along the Mississippi River.', 'DigitalReference', 1),
    ('The Great Gatsby', '1925-01-01', '978-0743273565', 1, 2, 8, 'F. Scott Fitzgerald''s iconic Jazz Age novel that delves into the world of wealth, excess, and the American Dream. Follow the enigmatic Jay Gatsby and his obsession with the elusive Daisy Buchanan.', 'DigitalReference', 1),
    ('Tender Is the Night', '1934-01-01', '978-0684801544', 1, 2, 8, 'A novel of decadence and romance by F. Scott Fitzgerald. Explore the lives of the wealthy and glamorous as they grapple with love, ambition, and the consequences of their choices.', 'DigitalReference', 1),
    ('One Hundred Years of Solitude', '1967-01-01', '978-0060883287', 1, 1, 9, 'Gabriel García Márquez''s magical realist masterpiece that tells the multi-generational story of the Buendía family in the fictional town of Macondo. Experience a world where reality and fantasy intertwine.', 'DigitalReference', 1),
    ('Love in the Time of Cholera', '1985-01-01', '978-0307389732', 1, 6, 9, 'A tale of enduring love by Gabriel García Márquez. Follow the lifelong romance between Florentino Ariza and Fermina Daza amidst the backdrop of Colombia''s changing society.', 'DigitalReference', 1),
    ('To Kill a Mockingbird', '1960-01-01', '978-0061120084', 1, 1, 10, 'Harper Lee''s classic of American literature that explores themes of racial injustice, morality, and compassion in the racially divided town of Maycomb, Alabama.', 'DigitalReference', 1),
    ('Go Set a Watchman', '2015-01-01', '978-0062409850', 1, 1, 10, 'A follow-up to "To Kill a Mockingbird" by Harper Lee. Discover the later life of Scout Finch as she returns to her hometown and confronts the complexities of her past and present.', 'DigitalReference', 1);

-- Insert physical reference locations
INSERT INTO dbo.[ReferenceLocation] (Floor, Section, Shelf)
VALUES
    (1, 2, 3),
    (2, 3, 4),
    (2, 4, 4),
    (1, 1, 2),
    (3, 1, 2),
    (2, 2, 3),
    (1, 5, 3),
    (3, 1, 1),
    (4, 2, 1),
    (2, 4, 1);

-- Physical References
INSERT INTO dbo.[References] (Title, PublishedOn, ISBN, Type, Genre, CreatorId, Description, Discriminator, LibraryId, LocationId, NumOfCopies, Available)
VALUES
    ('Romeo and Juliet', '1597-01-01', '978-0743477116', 1, 5, 1, 'A tragic love story that tells the tale of two young lovers, Romeo and Juliet, whose love defies the feuding families of Verona.', 'PhysicalReference', 1, 1, 3, 1),
    ('Hamlet', '1603-01-01', '978-0743477123', 1, 6, 1, 'A tragedy about a Danish prince, Hamlet, who seeks revenge against his uncle for murdering his father. It explores themes of madness, revenge, and mortality.', 'PhysicalReference', 1, 2, 2, 1),
    ('Pride and Prejudice', '1813-01-01', '978-1503290567', 1, 1, 2, 'A classic romance novel by Jane Austen that follows the life and love of Elizabeth Bennet and Mr. Darcy amidst societal expectations and prejudices.', 'PhysicalReference', 1, 3, 5, 1),
    ('Sense and Sensibility', '1811-01-01', '978-1503290567', 1, 1, 2, 'Jane Austen''s novel about the Dashwood sisters, Elinor and Marianne, as they navigate love and heartbreak in early 19th-century England.', 'PhysicalReference', 1, 4, 4, 0),
    ('Great Expectations', '1861-01-01', '978-1503290567', 1, 2, 3, 'Charles Dickens''s coming-of-age novel follows the life of Pip, an orphan who rises through society while facing personal challenges and moral dilemmas.', 'PhysicalReference', 1, 5, 6, 0),
    ('A Tale of Two Cities', '1859-01-01', '978-0486406510', 1, 4, 3, 'Charles Dickens''s historical novel set during the tumultuous times of the French Revolution, weaving the stories of characters in London and Paris.', 'PhysicalReference', 1, 6, 3, 1),
    ('War and Peace', '1869-01-01', '978-1400041801', 1, 3, 4, 'Leo Tolstoy''s epic Russian novel explores the lives of five aristocratic families during the Napoleonic era, delving into themes of history, love, and destiny.', 'PhysicalReference', 1, 7, 2, 1),
    ('Anna Karenina', '1877-01-01', '978-1853262715', 1, 5, 4, 'A tragic tale of love and society in Imperial Russia, where Anna Karenina enters a forbidden love affair that leads to personal and societal consequences.', 'PhysicalReference', 1, 8, 5, 0),
    ('1984', '1949-01-01', '978-0451524935', 1, 4, 5, 'George Orwell''s dystopian classic set in a totalitarian society where individuality is suppressed, and the government exerts control over every aspect of life.', 'PhysicalReference', 1, 9, 4, 0),
    ('Animal Farm', '1945-01-01', '978-0451526342', 1, 2, 5, 'George Orwell''s allegorical novella that satirizes the events leading up to the Russian Revolution of 1917 and the early years of the Soviet Union.', 'PhysicalReference', 1, 10, 6, 1);

-- Insert users
INSERT INTO [Users] (FirstName, LastName, Email, Username, [Password], IsAdmin, LibraryId)
VALUES
    ('Abebe', 'Kebede', 'abebe123@email.com', 'abebe123', 'password123', 1, 1), -- Admin user
    ('Mulu', 'Tadesse', 'mulu123@email.com', 'mulu123', 'mypassword', 1, 1), -- Admin user
    ('Sara', 'Girma', 'sara123@email.com', 'sara123', 'letmein', 0, 1), -- Regular user
    ('Daniel', 'Alemu', 'daniel123@email.com', 'daniel123', '12345', 0, 1); -- Regular user

DELETE FROM [References];