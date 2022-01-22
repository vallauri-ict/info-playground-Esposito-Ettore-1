CREATE TABLE Attori (
	CodAttore int not null primary key identity(1, 1),
	Nome varchar(30) not null,
	AnnoNascita smallint not null,
	Nazionalita varchar(3) not null
);

CREATE TABLE Film (
	CodFilm int not null primary key identity(1, 1),
	Titolo varchar(30) not null,
	AnnoProduzione smallint not null,
	Nazionalita varchar(3) not null,
	Regista varchar(30) not null,
	Genere varchar(20) not null
);

CREATE TABLE Sale (
	CodSala int not null primary key identity(1, 1),
	Posti int not null,
	Nome varchar(30) not null,
	Citta varchar(30) not null
);

CREATE TABLE Recita (
	CodAttore int not null,
	CodFilm int not null,
	primary key (CodAttore, CodFilm),
	foreign key (CodAttore) references Attori(CodAttore),
	foreign key (CodFilm) references Film(CodFilm)
);

CREATE TABLE Proiezioni (
	CodProiezione int not null primary key identity(1, 1),
	CodFilm int not null,
	CodSala int not null,
	Incasso decimal(6, 2) not null,
	DataProiezione date not null,
	foreign key (CodFilm) references Film(CodFilm),
	foreign key (CodSala) references Sale(CodSala)
);