
create table stores(store_id int primary key,store_name varchar(20),phone int,email varchar(20),street varchar(20),
city varchar(20),state varchar(20),zipcode int)

insert into stores values(7895,'Haldiram',4567,'haldi@','Nagpur road','Nagpur','Maharashtra',1234)


create table categories(category_id int primary key,category_name varchar(20))

insert into categories values(1234,'sweet')


create table brands(brand_id int primary key,brand_name varchar(20))

insert into brands values(456,'Haldiram')


create table products(product_id int primary key,product_name varchar(20),brand_id int,category_id int,
model_year int,list_price int,constraint c1 foreign key(brand_id) references brands(brand_id),
constraint c2 foreign key(category_id) references categories(category_id))

insert into products values(50,'gulabjamun',456,6789,2000,600)

create table stocks(store_id int,product_id int,quantity int,constraint c3 foreign key(store_id) references
stores(store_id),constraint c4 foreign key(product_id) references products(product_id))

insert into stocks values(4566,45,4)


create table customers(customer_id int primary key,first_name varchar(20),last_name varchar(20),phone int,email varchar(10),
city varchar(20),state varchar(20),zip_code int)

insert into customers values(111,'prachi','meshram',312345,'prachi@','pune','Maharashtra',45678)

create table staff(staff_id int primary key,first_name varchar(20),last_name varchar(20),email varchar(20),
phone int,active varchar(20),store_id int,manager_id int,constraint t1 foreign key(store_id)references stores(store_id))

insert into staff values(33,'tanu','jadhav','tanu@gmail.com',66789,'present',9876,41)

create table orders(order_id int primary key,cutomer_id int,order_status varchar(20),order_date int,required_date int,shipped_date
int,store_id int,staff_id int,constraint or1 foreign key(customer_id)references  customers(customer_id),constraint
o4 foreign key(store_id)references stores(store_id),constraint o5 foreign key(staff_id)references staff(staff_id))
insert into orders values(77,111,'done',12-3-23,17-3-23,13-3-23,4566,33)

create table oder_item(order_id int,item_id int,product_id int,quantity int,lait_price int,discount float
constraint i1 foreign key(order_id)references orders(order_id),constraint i2 foreign key(product_id)references products(product_id))
insert into oder_item values(77,34,45,3,800,0.10)

