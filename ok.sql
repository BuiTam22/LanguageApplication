create table AppUser(
  id varchar(10) primary key,
  userName varchar(10) unique not null,
  passWord varchar(50) not null,
  name nvarchar2(50),
  email varchar(150) unique
);

create table Topic(
  id varchar(2) primary key,
  userNameCreated varchar(10),
  nameTopic nvarchar2(50),
  description nvarchar2(200),
  foreign key (userNameCreated) references AppUser(userName)
);

create table WordType(
  id varchar(2) primary key,
  nameWordType nvarchar2(50),
  description nvarchar2(200)
);

create table Vocabulary(
  id varchar(5) primary key,
  englishWord varchar(100),
  vietnamWord nvarchar2(150),
  transcription nvarchar2(100),
  idTopic varchar(2),
  idWordType varchar(2),
  foreign key (idTopic) references Topic(id),
  foreign key (idWordType) references WordType(id)
);


insert all
  into AppUser(id, userName, passWord, name, email) values('u01', 'tambui', '1', 'B�i V?n T�m', 'tamse22032004@gmail.com')
  into AppUser(id, userName, passWord, name, email) values('u02', 'thanhloc', '1', 'Nguy?n Th�nh L?c', 'thanhloc@gmail.com')
select * from dual;
select * from AppUser

insert all
  into Topic(id, userNameCreated, nameTopic, description) values('01', 'tambui', 'Technology', 'Topic n�y ch?a nh?ng t? li�n quan ??n l?nh v?c c�ng ngh?')
  into Topic(id, userNameCreated, nameTopic, description) values('02', 'thanhloc', 'Education', 'Topic n�y ch?a nh?ng t? li�n quan h?c t?p')
select * from dual;
select * from Topic

insert all
  into WordType(id, nameWordType, description) values('01', 'Adverd', 'Tr?ng t? b? ngh?a cho ??ng t?')
  into WordType(id, nameWordType, description) values('02', 'Noun', 'Danh t? th??ng l�m ch? ng?')
select * from dual;

insert all
  into Vocabulary(id, englishWord, vietnamWord, transcription, idTopic, idWordType) 
  values('01', 'Costly', '??t ??', '/?k??st.li/', '01', '02')

  into Vocabulary(id, englishWord, vietnamWord, transcription, idTopic, idWordType) 
  values('02', 'Prize', 'Gi?i th??ng', '/pra?z/', '02', '02')

select * from dual;

select * from Vocabulary;