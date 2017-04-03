--1. kiem tra dang nhap
create proc Dangnhap
	@tentaikhoan varchar(20),
	@matkhau varchar(20)
as
begin
	if not exists (select 1 from Taikhoan where Tentaikhoan=@tentaikhoan and Matkhau=@matkhau)
	begin
		select -1;
		return;
	end;
	select Nhanvien.NhanvienID from (select TaikhoanID from Taikhoan where Tentaikhoan=@tentaikhoan and Matkhau=@matkhau)A
			inner join Taikhoan_Nhanvien on Taikhoan_Nhanvien.TaikhoanID=A.TaikhoanID
			inner join Nhanvien on Taikhoan_Nhanvien.NhanvienID=Nhanvien.NhanvienID;
end;
go
--2. Dang nhap thanh cong, hien thi thong tin cua sinh vien
create proc Nhanvien_Thongtin
	@nhanvienID int
as
begin
	if not exists (select 1 from Nhanvien where NhanvienID=@nhanvienID)
	begin
		select -1;
		return;
	end;
	select Nhanvien.* from Nhanvien;
end;
go
--3. Proc them moi nhan vien
create proc Nhanvien_Themmoi
	@nhanvienID int, 
	@tennhanvien nvarchar(50),
	@gioitinh bit,
	@soCMND varchar(20),
	@ngaysinh datetime,
	@noisinh nvarchar(50),
	@dienthoai varchar(20),
	@dantoc nvarchar(50),
	@tongiao nvarchar(50),
	@ghichu nvarchar(200),
	@tenphongban nvarchar(50),
	@tenchucvu nvarchar(50)
as
	begin
		if exists (select 1 from Nhanvien where NhanvienID = @nhanvienID)
		begin
			select -1;
			return;
		end;
		declare @phongbanid int;
		SELECT  @phongbanid = ISNULL(( SELECT  PhongbanID
                                    FROM    dbo.Phongban
                                    WHERE   Tenphongban = @tenphongban
                                  ), -1);
		IF @phongbanid < 0
            BEGIN
                SELECT  -1;
                RETURN;
            END;
		declare @chucvuid int;
		SELECT  @chucvuid = ISNULL(( SELECT  ChucvuID
                                    FROM    dbo.Chucvu
                                    WHERE   Tenchucvu = @tenchucvu
                                  ), -1);
		IF @chucvuid < 0
            BEGIN
                SELECT  -1;
                RETURN;
            END;
		insert into Nhanvien 
					(NhanvienID,
					PhongbanID,
					ChucvuID,
					Tennhanvien,
					Gioitinh,
					SoCMND,
					Ngaysinh,
					Noisinh,
					Dienthoai,
					Dantoc,
					Tongiao,
					Ghichu)
			values (@nhanvienID,
					@phongbanid,
					@chucvuid,
					@tennhanvien,
					@gioitinh,
					@soCMND,
					@ngaysinh,
					@noisinh,
					@dienthoai,
					@dantoc,
					@tongiao,
					@ghichu);
		select @nhanvienID;
	end;
	go

	--4. sua thong tin nhan vien
create proc Nhanvien_Sua
		@nhanvienID int, 
		@tennhanvien nvarchar(50),
		@gioitinh bit,
		@soCMND varchar(20),
		@ngaysinh datetime,
		@noisinh nvarchar(50),
		@dienthoai varchar(20),
		@dantoc nvarchar(50),
		@tongiao nvarchar(50),
		@ghichu nvarchar(200),
		@tenphongban nvarchar(50),
		@tenchucvu nvarchar(50)
as
begin
		if not exists (select 1 from Nhanvien where NhanvienID=@nhanvienID)
		begin
			select -1;
			return;
		end;
		declare @phongbanid int;
		SELECT  @phongbanid = ISNULL(( SELECT  PhongbanID
                                    FROM    dbo.Phongban
                                    WHERE   Tenphongban = @tenphongban
                                  ), -1);
		IF @phongbanid < 0
            BEGIN
                SELECT  -1;
                RETURN;
            END;
		declare @chucvuid int;
		SELECT  @chucvuid = ISNULL(( SELECT  ChucvuID
                                    FROM    dbo.Chucvu
                                    WHERE   Tenchucvu = @tenchucvu
                                  ), -1);
		IF @chucvuid < 0
            BEGIN
                SELECT  -1;
                RETURN;
            END;
		update Nhanvien
		set		PhongbanID=@phongbanid,
				ChucvuID=@chucvuid,
				Tennhanvien=@tennhanvien,
				Gioitinh=@gioitinh,
				SoCMND=@soCMND,
				Ngaysinh=@ngaysinh,
				Noisinh=@noisinh,
				Dienthoai=@dienthoai,
				Dantoc=@dantoc,
				Tongiao=@tongiao,
				Ghichu=@ghichu
		where NhanvienID=@nhanvienID;
		select @nhanvienID;
end;
go
--5. lay ten cac phong ban
create proc Phongban_Load
as 
begin
	select Phongban.Tenphongban from Phongban;
end;
go
--6. lay ten cac chuc vu
create proc Chucvu_Load
as
begin
	select Chucvu.Tenchucvu from Chucvu;
end;
go
--7. xoa thong tin nhan vien
create proc Nhanvien_Xoa
	@nhanvienID int
as
begin
	if not exists (select 1 from Nhanvien where NhanvienID=@nhanvienID)
	begin
		select -1;
		return;
	end;
	if exists (select 1 from (select NhanvienID from Nhanvien where NhanvienID=@nhanvienID)A
						inner join Taikhoan_Nhanvien on Taikhoan_Nhanvien.NhanvienID=A.NhanvienID)
	begin
		select -1;
		return;
	end;
	delete from Nhanvien where NhanvienID=@nhanvienid;
end;
go
--8. tim kiem thng tin nhan vien
create proc Nhanvien_Timkiem
	@nhanvienID int
as
begin
	if not exists (select 1 from Nhanvien where NhanvienID=@nhanvienID)
	begin
		select -1;
		return;
	end;
	select Nhanvien.* from Nhanvien where NhanvienID=@nhanvienID;
end;
go
