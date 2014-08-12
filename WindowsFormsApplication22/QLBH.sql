create database QLBH

use QLBH

create table iuser
(
	id varchar(20) primary key,
	pass varchar(20) not null,
	itype bit
	
)

create table hoadon
(
	id varchar(20) primary key,
	makhach varchar(20) not null,
	manv varchar(20) not null,
	sohd varchar(30) not null,
	ng_hd datetime
)

create table sanpham
(
	masp varchar(20) primary key,
	tensp nvarchar(30) not null,
	gianhap varchar(20),
	giaxuat varchar(20),
	dvt varchar(20),
	vat varchar(20)
)

create table khachhang
(
	makhach varchar(20) primary key,
	tenkhach varchar(20) not null,
	diachi varchar(50),
	lienlac varchar(20)

)

create table chitiethoadon
(
	idhd varchar(20) primary key,
	masp varchar(20) not null,
	soluong int,
	giaxuat double,
	donvitinh varchar(10),
	vat float
)