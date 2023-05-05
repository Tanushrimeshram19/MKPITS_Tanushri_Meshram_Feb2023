
create table stores1(store_id int primary key,store_name varchar(20),phone int,email varchar(20),street varchar(20),
city varchar(20),state varchar(20),zipcode int)

insert into stores1 values(1234,'Haldiram',5678,'haldiram.com','Nagpur road','Nagpur','Maharashtra',441107)


create table categorie(category_id int primary key,category_name varchar(20))

insert into categorie values(4789,'sweet')


create table brand1(brand_id int primary key,brand_name varchar(20))

insert into brand1 values(143,'Haldiram')

create table product1(product_id int primary key,product_name varchar(20),brand_id int,category_id int,
model_year int,list_price int,constraint p1 foreign key(brand_id) references brand1(brand_id),
constraint p2 foreign key(category_id) references categorie(category_id))

insert into product1 values(45,'gulabjamun',777,1234,1990,600)


create table stock(store_id int,product_id int,quantity int,constraint p3 foreign key(store_id) references
stores1(store_id),constraint p4 foreign key(product_id) references product1(product_id))

insert into stock values(4566,45,4)


create table customer(customer_id int primary key,first_name varchar(20),last_name varchar(20),phone int,email varchar(10),
city varchar(20),state varchar(20),zip_code int)

insert into customer values(235,'sanskruti','meshram',45678,'sanugmail','pune','Maharashtra',12345)

create table staff1(staff_id int primary key,first_name varchar(20),last_name varchar(20),email varchar(20),
phone int,active varchar(20),store_id int,manager_id int,constraint t1 foreign key(store_id)references stores1(store_id))
insert into staff1 values(11,'tanu','jadhav','tanu@',6789,'present',4367,60)

create table orders(order_id int primary key,cutomer_id int,order_status varchar(20),order_date int,required_date int,shipped_date
int,store_id int,staff_id int,constraint or1 foreign key(customer_id)references  customer(customer_id),constraint
o4 foreign key(store_id)references stores1(store_id),constraint o5 foreign key(staff_id)references staff1(staff_id))
insert into orders values(77,111,'done',19-2-2002,13-3-23,1-8-23,6789,30)

create table oder_item(order_id int,item_id int,product_id int,quantity int,lait_price int,discount float
constraint i1 foreign key(order_id)references orders(order_id),constraint i2 foreign key(product_id)references product1(product_id))
insert into oder_item values(77,34,45,3,800,0.10)

