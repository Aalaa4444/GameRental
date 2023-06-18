create database GAMES;
CREATE TABLE Account
(
  Password VARCHAR(55) NOT NULL,
  Username VARCHAR(55) NOT NULL,
  E_mail VARCHAR(55) NOT NULL,
  ACC_ID INT NOT NULL identity(1,1),
  Name VARCHAR(55) NOT NULL,
  PRIMARY KEY (ACC_ID)
);

CREATE TABLE Customer
(
  Age INT NOT NULL,
  Phone VARCHAR(55) NOT NULL,
  ACC_ID INT NOT NULL,
  PRIMARY KEY (ACC_ID),
  FOREIGN KEY (ACC_ID) REFERENCES Account(ACC_ID)
);

CREATE TABLE Admin
(
  ACC_ID INT NOT NULL,
  PRIMARY KEY (ACC_ID),
  FOREIGN KEY (ACC_ID) REFERENCES Account(ACC_ID)
);



CREATE TABLE Game
(
  Year INT NOT NULL,
  Category VARCHAR(55) NOT NULL,
  Game_ID INT NOT NULL identity(1,1),
  Title VARCHAR(55) NOT NULL,
  ACC_ID INT NOT NULL,
  PRIMARY KEY (Game_ID),
  vendor VARCHAR(55) NOT NULL,
  FOREIGN KEY (ACC_ID) REFERENCES Admin(ACC_ID)
);

CREATE TABLE Browsee
(
  indx INT NOT NULL identity(1,1),
  Game_ID INT NOT NULL,
  ACC_ID INT NOT NULL,
  PRIMARY KEY (indx),
  FOREIGN KEY (Game_ID) REFERENCES Game(Game_ID),
  FOREIGN KEY (ACC_ID) REFERENCES Customer(ACC_ID)
);

CREATE TABLE Rent
(
  S_Date DATE NOT NULL,
  E_Date DATE NOT NULL,
  rent_id INT NOT NULL identity(1,1),
  Game_ID INT NOT NULL,
  ACC_ID INT NOT NULL,
  PRIMARY KEY (rent_id),
  FOREIGN KEY (Game_ID) REFERENCES Game(Game_ID),
  FOREIGN KEY (ACC_ID) REFERENCES Customer(ACC_ID)
);

CREATE TABLE Returnn
(
  indx INT NOT NULL identity(1,1),
  Game_ID INT NOT NULL,
  ACC_ID INT NOT NULL,
  PRIMARY KEY (indx),
  FOREIGN KEY (Game_ID) REFERENCES Game(Game_ID),
  FOREIGN KEY (ACC_ID) REFERENCES Customer(ACC_ID)
);