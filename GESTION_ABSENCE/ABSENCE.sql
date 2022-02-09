create database ABSENCE
use ABSENCE
--------------
create table Absence(
  NumAbs int primary key identity,
  DateAbs date,
  NumSe int foreign key references Seance(NumSe),
  NumM int foreign key references Motif(NumM),
  Cin varchar(20) foreign key references Inscription(Cin)
  ) 
--------------------
create table Annee(
  NumA int primary key,
  NomA varchar(50)
  )
-------------------------
create table Seance(
  NumSe int primary key identity,
  NomSe varchar(50),
  HeureD time,
  HeureF time
  )
-------------------------------
create table AnneeScolaire(
  NumAs int primary key,
  Libelle varchar(100)
  )
---------------------------
create table Groupe(
 NomG int primary key identity,
 Filiere varchar(50)
 )
--------------------------------
create table Inscription(
   Cin varchar(20) primary key ,
   NumA int foreign key references Annee(NumA),
   NumAs int foreign key references AnneeScolaire(NumAs),
   NomG int foreign key references Groupe(NomG),
   NbrSeanceA float ,
   NoteAssiduite float
   )
--------------------------------------
create table Motif(
   NumM int primary key identity,
   DossierM varbinary(max),
   JustificationM varchar(70)
   )
-----------------------------------------
create table Absence(
  NumAbs int primary key identity,
  DateAbs date,
  NumSe int foreign key references Seance(NumSe),
  NumM int foreign key references Motif(NumM),
  Cin varchar(20) foreign key references Inscription(Cin)
  )

