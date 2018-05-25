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
values('NV1',N'Nguyễn Đức Nam',N'Hà Nội',N'Nam','19950708','0869957997')
insert into nhanvien(manv,tennv,diachi,gioitinh,ns,sdt)
values('NV2',N'Đỗ Khánh Hà',N'Hà Nội',N'Nữ','19940608','0869952154')

insert into khachhang(makh,tenkh)
values('KH1',N'Nguyễn Thị Mai')
insert into khachhang(makh,tenkh)
values('KH2',N'Nguyễn Hải Long')

insert into hoadonban(mahdb,makh,manv,ngayban,tongtien)
values('HDB1','KH2','NV1','20180506',30000)
insert into hoadonnhap(mahdn,mancc,manv,ngaynhap,tongtien)
values('HDN1','NCC1','NV2','20180403',10000000)