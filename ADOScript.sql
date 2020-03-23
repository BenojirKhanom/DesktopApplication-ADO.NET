use master;
go

create database AspProject;
go
use AspProject;
go

create table Reg (Id int identity primary key, UserName varchar(20), Password varchar(12), ConfirmPassword varchar(12));

create table Student (StudentID int identity primary key, StudentName varchar(25));