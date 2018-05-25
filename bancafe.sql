create database bancafe
use bancafe

create table nhacc(
mancc nvarchar(10) primary key,
tenncc nvarchar(50) null,
diachi nvarchar(50) null,
sdt varchar(15) 
)

create table loai(
maloai nvarchar(10) primary key,
tenloai nvarchar(50)
)

create table khachhang (
makh nvarchar(10) primary key,
tenkh nvarchar(50)
)

create table sanpham(
masp nvarchar(10) primary key,
tensp nvarchar(50),
maloai nvarchar(10) references loai(maloai),
giaban float,
soluong float
)

create table nhanvien(
manv nvarchar(10) primary key,
tennv nvarchar(50) ,
diachi nvarchar(50) null,
gioitinh nvarchar(10) null,
ns date null,
sdt char(15) null
)

create table hoadonnhap(
mahdn nvarchar(10) primary key,
ngaynhap date,
tongtien float,
manv nvarchar(10) references nhanvien(manv),
mancc nvarchar(10) references nhacc(mancc)

)

create table hoadonban(
mahdb nvarchar(10) primary key,
ngayban date,
tongtien float,
manv nvarchar(10) references nhanvien(manv),
makh nvarchar(10) references khachhang(makh)
)

create table ct_hoadonnhap( 
mahdn nvarchar(10) references hoadonnhap(mahdn),
masp nvarchar(10) references sanpham(masp),
soluong float,
dongia float,
thanhtien float

)

create table ct_hoadonban( 
mahdb nvarchar(10) references hoadonban(mahdb),
masp nvarchar(10) references sanpham(masp),
soluong float,
thanhtien float,
dongia float
)

insert into loai(maloai,tenloai)
values('L1',N'Trà')
insert into loai(maloai,tenloai)
values('L2',N'Cafe truyền thống')
insert into loai(maloai,tenloai)
values('L3',N'Cafe hiện đại')


insert into nhacc(mancc,tenncc,diachi,sdt)
values('NCC1',N'Trung nguyên',N'Buôn Ma Thuột','0902190123')
insert into nhacc(mancc,tenncc,diachi,sdt)
values('NCC2',N'NesCafe',N'Hồ Chí Minh','0902690678')
insert into nhacc(mancc,tenncc,diachi,sdt)
values('NCC3',N'VinaCafe',N'Biên Hòa','0906308789')



insert into sanpham(masp,tensp,maloai,giaban)
values('SP1',N'Cafe sữa đá','L2',30000)
insert into sanpham(masp,tensp,maloai,giaban)
values('SP2',N'Cafe sữa nóng','L2',30000)
insert into sanpham(masp,tensp,maloai,giaban)
values('SP3',N'Cafe đen đá','L2',35000)
insert into sanpham(masp,tensp,maloai,giaban)
values('SP4',N'Cafe đen','L2',35000)



insert into nhanvien(manv,tennv,diachi,gioitinh,ns,sdt)
VALUES ('NV1',N'Nguyễn Đức Nam',N'Hà Nội',N'Nam','19950708','0869957997'),
('NV2',N'Đỗ Khánh Hà',N'Hà Nội',N'Nữ','19940608','0869952154'),
('NV3',N'Đỗ Khánh Nam',N'Hà Nội',N'Nam','19960607','0864452154'),
('NV4',N'Đỗ Khánh Thành',N'Hà Nội',N'Nam','19960609','0800852154')
insert into khachhang(makh,tenkh)
values('KH1',N'Nguyễn Thị Mai'),
('KH2',N'Nguyễn Hải Long'),
('KH3',N'Nguyễn Hải Nam'),
('KH4',N'Nguyễn Hải Sơn'),
('KH5',N'Nguyễn Hải Long'),
('KH6',N'Nguyễn Hải Triều')




insert into hoadonban(mahdb,makh,manv,ngayban,tongtien)
values('HDB1','KH2','NV1','20180506',30000),
('HDB2','KH3','NV1','20180516',30000),
('HDB3','KH4','NV2','20180516',35000),
('HDB4','KH5','NV3','20180517',35000),
('HDB5','KH6','NV2','20180516',35000)

insert into hoadonnhap(mahdn,mancc,manv,ngaynhap,tongtien)
values('HDN1','NCC1','NV2','20180403',10000000),
('HDN2','NCC2','NV3','20180413',20000000),
('HDN3','NCC3','NV1','20180503',40000000),
('HDN4','NCC1','NV2','20180515',20000000),
('HDN5','NCC2','NV4','20180520',30000000)


INSERT INTO ct_hoadonnhap(mahdn,masp,dongia,soluong,thanhtien)
VALUES('HDN1','SP1',30000,100,''),
('HDN2','SP2',30000,150,''),
('HDN3','SP3',35000,120,''),
('HDN4','SP2',30000,110,''),
('HDN5','SP3',35000,120,'')

INSERT INTO ct_hoadonban(mahdb,masp,dongia,soluong,thanhtien)
VALUES('HDB1','SP1',30000,1,''),
('HDB2','SP2',30000,2,''),
('HDB3','SP3',35000,1,''),
('HDB4','SP4',35000,2,''),
('HDB5','SP3',35000,2,'')
