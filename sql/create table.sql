
use GomaskoDP_exam

drop table products_in_order

drop table product
drop table store_order
drop table person

create table person(
	person_id int identity, 
	login varchar(20),
	password varchar(20),
	name varchar(30),
	email varchar(28),
	telephone_number nvarchar(11),

	primary key (person_id)
);

create table store_order(
	order_id int identity,
	person_id_f int, 
	address varchar(30),
	date date,

	primary key(order_id),
	foreign key (person_id_f) references person (person_id)
);

create table product(
	product_id int identity,
	name varchar(20),
	price int,

	primary key(product_id)
);

create table products_in_order(
	pio_id int identity,
	order_id_f int,
	product_id_f int,
	count int,
	primary key(pio_id),
	foreign key (product_id_f) references product (product_id),
	foreign key (order_id_f) references store_order (order_id)
);