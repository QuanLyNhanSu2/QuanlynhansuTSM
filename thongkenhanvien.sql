-- thong ke thong tin nhan vien
create proc thongkenhanvien 
as 
begin 
select CC.*,DD.Ten as loaihopdong from 
	(select AA.*, BB.Ngaybatdau , BB.Ngayketthuc , BB.HopdongID from
	(select A.*, B.ten as chucvu, C.Ten as dantoc, D.Ten as tongiao from NhanVien A, Chucvu B , Dantoc C, Tongiao D
	 where A.ChucvuID = B.ChucvuID 
		  and A.DantocID = C.DantocID
		  and A.TongiaoID = D.TongiaoID) AA
	INNER JOIN CTHopDong BB
	ON AA.NhanvienID = BB.NhanvienID ) CC
Inner join Hopdong DD
on CC.HopdongID = DD.HopdongID
end

exec thongkenhanvien

delete from Luong where LuongID =1