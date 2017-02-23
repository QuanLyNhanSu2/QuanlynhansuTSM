create proc TimkiemNhanvien
@NhanvienID int
as begin
	select * from Nhanvien where NhanvienID = @NhanvienID
end
exec TimkiemNhanvien 1
create proc XoaNhanvien
@NhanvienID int
as begin
	delete from Nhanvien where NhanvienID=@NhanvienID
end
exec XoaNhanvien 4