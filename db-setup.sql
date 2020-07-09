USE customerratr;

CREATE TABLE customer (
    id int NOT NULL AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    img VARCHAR(255) NOT NULL,
    rating int DEFAULT 0,
    unhinged TINYINT,
    description VARCHAR(3000),
    PRIMARY KEY (id)
);