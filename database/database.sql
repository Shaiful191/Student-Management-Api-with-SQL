create database students;
use students;

create table students(
  Id int identity(1,1) primary key,
  Name varchar(50) not null,
  Gender varchar(10) not null,
  Age int not null,
  Class int not null,
  Father_Name varchar(50)
  );

insert into students(Name,Gender,Age,Class,Father_Name)
values
('Shaiful Islam','Male',24,12,'Shirajul Islam'),
('Sobuj Mia','Male',27,11,'Said Islam'),
('Said Islam','Male',15,8,'Rahoman'),
('Sohanur Rahman','Male',18,10,'Billal Hossain');

SELECT TOP (1000) [Id]
      ,[Name]
      ,[Gender]
      ,[Age]
      ,[Class]
      ,[Father_Name]
  FROM [students].[dbo].[students];