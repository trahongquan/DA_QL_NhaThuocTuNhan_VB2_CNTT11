--BC Doanh số nhân viên-
drop proc m_DoanhSoNV
create proc m_DoanhSoNV
(
@Tungay datetime,
@Denngay datetime
)
as
select E_ID, Fullname, 0 as SLHDB, 0 as DSo
from Employee where E_ID not in (select E_ID from Sale where Sale.SAL_Time between @Tungay and @Denngay)
union all
select distinct Sale.E_ID, Employee.Fullname, Count(Sale.SAL_ID) as SLHDB, Sum(Sale.SAL_Total) as DSo
from Sale inner join Employee on Employee.E_ID = Sale.E_ID
where Sale.SAL_Time between @Tungay and @Denngay
group by Sale.E_ID, Employee.Fullname
order by E_ID

m_DoanhSoNV '09-16-2023', '09-30-2023'