create proc TimkiemNhanvien
@NhanvienID int
as begin
	select * from Nhanvien where NhanvienID = @NhanvienID
end