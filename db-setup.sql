USE customerratr;

-- CREATE TABLE customer (
--     id int NOT NULL AUTO_INCREMENT,
--     name VARCHAR(255) NOT NULL,
--     img VARCHAR(255) NOT NULL,
--     rating int DEFAULT 0,
--     unhinged TINYINT,
--     description VARCHAR(3000),
--     PRIMARY KEY (id)
-- );

INSERT INTO customer 
(name, img, rating, unhinged, description)
VALUES
("Karen", "https://i.kym-cdn.com/entries/icons/facebook/000/027/963/karenimg.jpg", 1 , 0 , "A very rude customer!")