create  table admins(
 Id int not null primary key,
 Passwords varchar(255) NOT NULL ,
 username varchar(255) NOT NULL ,
 dep_num int not null,
 foreign key (dep_num) references departments (dept_num),
 );
 create table customer(
 firstName varchar(255),
 lastName varchar(255),
 PhoneNumber int  Primary key  NOT NULL,
 );
 CREATE TABLE buy
(
  serial_number INT NOT NULL,
  phoneNumber INT NOT NULL,
  Tdate datetime  NOT NULL,
  PRIMARY KEY (serial_number, phoneNumber,Tdate),
  FOREIGN KEY (serial_number) REFERENCES Product(serial_number),
  FOREIGN KEY (phoneNumber) REFERENCES customer(phoneNumber),
);
CREATE TABLE Product
(
  serial_number INT NOT NULL,
  name VARCHAR(50) NOT NULL,
  price FLOAT NOT NULL,
  quantity float NOT NULL, 
  production_date datetime NOT NULL,
  expire_date datetime NOT NULL,
  dept_num INT NOT NULL,
  Id int not null,
  PRIMARY KEY(serial_number),
  FOREIGN KEY(dept_num) REFERENCES departments(dept_num),
  FOREIGN KEY(Id) REFERENCES admins(Id),
);
 create table departments(
name varchar(255) NOT NULL,
dept_num int NOT NULL,
primary key(dept_num),
);