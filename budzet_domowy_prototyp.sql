use baza_danych
create table kategoria
(
	id_kategoria  int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	nazwa varchar(50) NOT NULL,
	id_podkategoria int,
	typ varchar(50) check (typ='wydatek' or typ='przychod' ), 
	CONSTRAINT FK_kategoria_wydatku_typ_wydatku FOREIGN KEY (id_podkategoria) REFERENCES kategoria(id_kategoria)
)
create table forma_platnosci
(
	id_forma_platnosci int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	nazwa varchar NOT NULL
)
create table uzytkownicy
(
	id_uzytkownika int not null IDENTITY(1,1) PRIMARY KEY,
	imie  varchar(50) not null,
	nazwisko varchar(50) not null,
)

create table operacje
(
	id_operacji int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	data DATETIME not null,
	kwota decimal(10,2) NOT NULL,
	id_kategoria int not null,
	id_uzytkownika int not null,
	id_forma_platnosci int,
	opis varchar(200),
	CONSTRAINT FK_operacja_uzytkownik FOREIGN KEY (id_uzytkownika) REFERENCES uzytkownicy(id_uzytkownika), 
	CONSTRAINT FK_operacja_kategoria FOREIGN KEY (id_kategoria) REFERENCES kategoria(id_kategoria),
	CONSTRAINT FK_operacja_forma_platnosci FOREIGN KEY (id_forma_platnosci) REFERENCES forma_platnosci(id_forma_platnosci)
)
ALTER TABLE kategoria DROP CONSTRAINT FK_kategoria_wydatku_typ_wydatku
ALTER TABLE operacje DROP CONSTRAINT FK_operacja_uzytkownik
ALTER TABLE operacje DROP CONSTRAINT FK_operacja_kategoria
ALTER TABLE operacje DROP CONSTRAINT FK_operacja_forma_platnosci
drop table operacje
drop table uzytkownicy
drop table forma_platnosci
drop table kategoria

