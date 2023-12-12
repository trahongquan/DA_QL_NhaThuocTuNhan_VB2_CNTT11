select a.IFS_ID, a.IFS_Time, a.IFS_Total,
c.Fullname, d.S_Name, d.S_Address, d.S_Phonenumber from ImpFromSupp as a, Employee as c, Supplier as d
where a.IFS_ID = 'PN000001' and c.E_ID = a.E_ID and d.S_ID = a.S_ID

select b.M_ID, b.M_Name, b.M_ImUnit, b.M_Quantity, b.M_ImPrice, b.DIFS_Total 
from DetailImpFromSupp as b
where b.IFS_ID = 'PN000002'

select a.IFS_ID, a.IFS_Time, a.IFS_Total, b.M_ID, b.M_Name, b.M_ImUnit, b.M_Quantity, b.M_ImPrice*b.M_GTQD as Dongia, b.DIFS_Total,
c.Fullname, d.S_Name, d.S_Address, d.S_Phonenumber from ImpFromSupp as a, DetailImpFromSupp as b, Employee as c, Supplier as d
where a.IFS_ID = 'PN000002' and a.IFS_ID = b.IFS_ID and c.E_ID = a.E_ID and d.S_ID = a.S_ID

select a.SAL_ID, a.SAL_Total, b.M_Name, b.M_Unit, b.M_QuantitySale, b.M_Price, b.DS_Total,
c.Fullname, d.C_Fullname, d.C_Age, d.C_Gender, d.C_Address, d.C_Phonenumber from Sale as a, DetailSale as b, Employee as c, Customer as d
where a.SAL_ID = 'HDB0000003' and a.SAL_ID = b.SAL_ID and c.E_ID = a.E_ID and d.C_ID = a.C_ID

select a.RS_ID, a.RS_Total, a.S_ID, b.M_ID, b.M_Name, b.M_Unit, b.M_QuantityReturn, b.M_ImPrice, b.DRS_Total,
c.Fullname, d.S_Name, d.S_Address, d.S_Phonenumber from ReturnSupplier as a, DetailReturnSupplier as b, Employee as c, Supplier as d
where a.RS_ID = 'PTNCC0002' and a.RS_ID = b.RS_ID and c.E_ID = a.E_ID and a.S_ID = d.S_ID
--BC doanh thu
;with k as (
Select m.M_ID, m.M_Name, m.M_BasicUnit, mg.MG_Name from Medicine m
join MedicineGroup mg on mg.MG_ID = m.M_IDG),
n as (
Select M_ID, Sum(M_QuantitySale) as SLBan, Sum(DS_Total) as DoanhThu
From DetailSale a
Join Sale b on a.SAL_ID = b.SAL_ID
where b.SAL_Time between '08/01/2023' and '08/31/2023'
Group by M_ID)

select k.*, SLBan, DoanhThu
from n
join k on k.M_ID = n.M_ID
--
Select m.M_ID, m.M_Name, m.M_BasicUnit, m.M_IDG, mg.MG_Name from Medicine m
join MedicineGroup mg on mg.MG_ID = m.M_IDG
--Trả NCC
with tb1 as(
select M_ID as ID from DetailImpFromSupp a join ImpFromSupp b on a.IFS_ID = b.IFS_ID where b.S_ID = 'NCC002' group by M_ID),
tb2 as (Select M_ID as ID, M_Name as NameM, M_Dat as Dat, M_ImUnit as Unit, M_GTQD as QD, M_Quantity as SL, M_ImPrice as Price from Medicine)
select tb2.* from tb1 join tb2 on tb2.ID = tb1.ID
--Doanh số NV
select distinct Sale.E_ID, Employee.Fullname, Count(Sale.SAL_ID) as SLHDB, Sum(Sale.SAL_Total) as DSo
from Sale inner join Employee on Employee.E_ID = Sale.E_ID
where Sale.SAL_Time between '09/01/2023' and '09/30/2023'
group by Sale.E_ID, Employee.Fullname
order by Sale.E_ID


--DS thuốc dưới định mức tồn
select M_ID as Ma, M_Name as Ten, M_BasicUnit as DV, M_DMT as DM, M_Quantity as SLThucTe, ABS(M_Quantity - M_DMT) as ChenhLech
from Medicine
where M_Quantity > M_DMT
--DS thuốc săp hết hạn
select M_ID as Ma, M_Name as Ten, M_BasicUnit as DV, M_Batch as TenLo, M_Dat as HSD, M_Quantity as SLCon, M_ImPrice as GiaNhap, (M_Quantity*M_ImPrice) as TriGia, DATEDIFF(day, getdate(), M_Dat) as SoNgayConHan
from Medicine
where DATEDIFF(day, getdate(), M_Dat) > 60
--Tồn đến ngày
select tb1.M_ID, tb1.M_Name, Sum(SLTon) as TongSLTon
from
(
select m.M_ID, m.M_Name, a.M_Quantity*a.M_GTQD as SLTon
from DetailImpFromSupp as a inner join Medicine as m on a.M_ID = m.M_ID inner join ImpFromSupp as b on a.IFS_ID = b.IFS_ID
where b.IFS_Time <= getdate()
union all
select m.M_ID, m.M_Name, (-1)*(c.M_QuantitySale + e.M_QuantityReturn*m.M_GTQD) as SLTon
from DetailSale as c inner join Medicine as m on c.M_ID = m.M_ID inner join Sale as d on c.SAL_ID = d.SAL_ID
inner join DetailReturnSupplier as e on e.M_ID = m.M_ID inner join ReturnSupplier as f on e.RS_ID = f.RS_ID
where d.SAL_Time <= getdate() and f.RS_Time <= getdate()
)tb1
group by tb1.M_ID, tb1.M_Name

---
select E_ID, Fullname, 0 as SLHDB, 0 as DSo
from Employee where E_ID not in (select E_ID from Sale)
union all
select distinct Sale.E_ID, Employee.Fullname, Count(Sale.SAL_ID) as SLHDB, Sum(Sale.SAL_Total) as DSo
from Sale inner join Employee on Employee.E_ID = Sale.E_ID
where Sale.SAL_Time between '09/01/2023' and '09/30/2023'
group by Sale.E_ID, Employee.Fullname
order by E_ID
