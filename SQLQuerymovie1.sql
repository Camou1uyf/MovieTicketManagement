CREATE TABLE movies1(
id INT PRIMARY KEY IDENTITY(1,1),
movie_id VARCHAR(MAX) NULL,
movie_name VARCHAR(MAX) NULL,
genre VARCHAR(MAX) NULL,
price FLOAT NULL,
capacity INT NULL,
movie_image VARCHAR(MAX) NULL,
status1 VARCHAR(MAX) NULL,
date1 DATE NULL,
created_at  DATETIME NULL,
update_date DATE NULL,
delete_date DATE NULL
)

SELECT*FROM movies1;
 
SELECT capacity 
FROM movies1 
WHERE delete_date IS NULL 
AND status1 != 'Delete';