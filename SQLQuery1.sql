create database project;

create table student (
st_Id varchar(10) primary key,
st_name varchar(100) NOT NULL,
dob date NOT NULL,
gender varchar(10) NOT NULL,
st_address varchar(255),
contactNo varchar(15)
);

select * from student;