SELECT*FROM movies1;

CREATE TABLE cutomers(
id int primary key identity(1,1),
movie_id VARCHAR(MAX) NULL,
seat_id VARCHAR(MAX) NULL,
available_movie VARCHAR(MAX) NULL,
TOTALPRICE fLOAT,
foods VARCHAR(MAX) NULL,
drinks VARCHAR(MAX) NULL,
amount FLOAT,
change1 FLOAT,
status1 VARCHAR(MAX) NULL,
date_buy VARCHAR(MAX) NULL

)
 

CREATE TABLE butticket(
id int primary key identity(1,1),
movie_id VARCHAR(MAX) NULL,
seat_id VARCHAR(MAX) NULL,
seat_number  int,
price float null,
status1 VARCHAR(MAX) NULL,
created_at DATE
) 

SELECT* FROM butticket;

SELECT capacity 
FROM movies1 
WHERE delete_date IS NULL 
AND status1 != ' Delete';

SELECT* FROM movies1;


 drop table butticket;
 
 SELECT COUNT(id) FROM movies1 WHERE status1 = 'Vailabale';

 SELECT* FROM users;
