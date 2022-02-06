create database shopping;
create table CUSTOMER(
ID int primary key,
NAME varchar(15),
);
create table ORDER(
ID int primary key,
DATEOPER date,
CUSTOMER_ID int foreign key references CUSTOMER(ID),
AMOUNT real,
);
select SUM(AMOUNT), CUSTOMER_ID from ORDERS group by CUSTOMER_ID;
select * from CUSTOMER;