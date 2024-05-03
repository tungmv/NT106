create table Admin(
	ID varchar(5) primary key not null unique,
	Hashed varchar(64) check (length(Hashed) = 64),
	Salt varchar(50)
);