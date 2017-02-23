
create proc [dbo].[themnhanvien]
		   @NhanvienID int,
           @Ten nvarchar(50),
           @Gioitinh nvarchar(50),
           @SoCMND int,
           @Ngaysinh datetime,
           @Noisinh nvarchar(50),
           @Dienthoai varchar(20),
           @Hokhau nvarchar(50),
           @Choohiennay nvarchar(100),
           @Ngayvaolam datetime,
           @SotheATM varchar(20),
           @DantocID int,
           @TongiaoID int,
           @PhongbanID int,
           @ChucvuID int,
           @BaohiemID varchar(50),
           @Ghichu nvarchar(500)
AS
begin 
	INSERT INTO NhanVien values (   @NhanvienID ,
									@Ten ,
									@Gioitinh,
									@SoCMND ,
									@Ngaysinh ,
									@Noisinh ,
									@Dienthoai ,
									@Hokhau ,
									@Choohiennay ,
									@Ngayvaolam ,
									@SotheATM ,
									@DantocID ,
									@TongiaoID ,
									@PhongbanID ,
									@ChucvuID ,
									@BaohiemID ,
									@Ghichu )
end
GO
