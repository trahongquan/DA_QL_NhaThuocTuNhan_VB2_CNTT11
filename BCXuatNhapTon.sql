--BC Nhập - Xuất - Tồn
drop proc m_XuatNhapTon
create procedure m_XuatNhapTon
(
@Tungay datetime,
@Denngay datetime
)
as
select tb1.M_ID, tb1.M_Name, tb1.M_BasicUnit as DVT, Sum(tb1.SLTonDK) as TonDK, Sum(tb1.SLNhapTK) as NhapTK, Sum(tb1.SLXuatTK) as XuatTK, Sum(tb1.SLTonCK) as TonCK
from 
(
--Nhập đầu kỳ
select m.M_ID, m.M_Name, m.M_BasicUnit, a.M_Quantity*a.M_GTQD as SLTonDK, 0 as SLNhapTK, 0 as SLXuatTK, 0 as SLTonCK
from DetailImpFromSupp as a inner join Medicine as m on a.M_ID = m.M_ID inner join ImpFromSupp as b on a.IFS_ID = b.IFS_ID
where b.IFS_Time < @Tungay
union all
--Xuất đầu kỳ
--bán
select m.M_ID, m.M_Name, m.M_BasicUnit, (-1)*(c.M_QuantitySale) as SLTonDK, 0 as SLNhapTK, 0 as SLXuatTK, 0 as SLTonCK
from DetailSale as c inner join Medicine as m on c.M_ID = m.M_ID inner join Sale as d on c.SAL_ID = d.SAL_ID
where d.SAL_Time < @Tungay
union all
--trả
select m.M_ID, m.M_Name, m.M_BasicUnit, (-1)*(e.M_QuantityReturn*m.M_GTQD) as SLTonDK, 0 as SLNhapTK, 0 as SLXuatTK, 0 as SLTonCK
from Medicine as m inner join DetailReturnSupplier as e on e.M_ID = m.M_ID inner join ReturnSupplier as f on e.RS_ID = f.RS_ID
where f.RS_Time < @Tungay
union all
--Nhập trong kỳ
select m.M_ID, m.M_Name, m.M_BasicUnit, 0 as SLTonDK, a.M_Quantity*a.M_GTQD as SLNhapTK, 0 as SLXuatTK, 0 as SLTonCK
from DetailImpFromSupp as a inner join Medicine as m on a.M_ID = m.M_ID inner join ImpFromSupp as b on a.IFS_ID = b.IFS_ID
where b.IFS_Time between @Tungay and @Denngay
union all
--Xuất trong kỳ
--bán
select m.M_ID, m.M_Name, m.M_BasicUnit, 0 as SLTonDK, 0 as SLNhapTK, c.M_QuantitySale as SLXuatTK, 0 as SLTonCK
from DetailSale as c inner join Medicine as m on c.M_ID = m.M_ID inner join Sale as d on c.SAL_ID = d.SAL_ID
where d.SAL_Time between @Tungay and @Denngay
union all
--trả
select m.M_ID, m.M_Name, m.M_BasicUnit, 0 as SLTonDK, 0 as SLNhapTK, e.M_QuantityReturn*m.M_GTQD as SLXuatTK, 0 as SLTonCK 
from Medicine as m inner join DetailReturnSupplier as e on e.M_ID = m.M_ID inner join ReturnSupplier as f on e.RS_ID = f.RS_ID
where f.RS_Time between @Tungay and @Denngay
union all
--Nhập cuối kỳ
select m.M_ID, m.M_Name, m.M_BasicUnit, 0 as SLTonDK, 0 as SLNhapTK, 0 as SLXuatTK, a.M_Quantity*a.M_GTQD as SLTonCK
from DetailImpFromSupp as a inner join Medicine as m on a.M_ID = m.M_ID inner join ImpFromSupp as b on a.IFS_ID = b.IFS_ID
where b.IFS_Time <= @Denngay
union all
--Xuất cuối kỳ
--bán
select m.M_ID, m.M_Name, m.M_BasicUnit, 0 as SLTonDK, 0 as SLNhapTK, 0 as SLXuatTK, (-1)*(c.M_QuantitySale) as SLTonCK
from DetailSale as c inner join Medicine as m on c.M_ID = m.M_ID inner join Sale as d on c.SAL_ID = d.SAL_ID
where d.SAL_Time <= @Denngay
union all
--trả
select m.M_ID, m.M_Name, m.M_BasicUnit, 0 as SLTonDK, 0 as SLNhapTK, 0 as SLXuatTK, (-1)*(e.M_QuantityReturn*m.M_GTQD) as SLTonCK
from Medicine as m inner join DetailReturnSupplier as e on e.M_ID = m.M_ID inner join ReturnSupplier as f on e.RS_ID = f.RS_ID
where f.RS_Time <= @Denngay
)tb1
group by tb1.M_ID, tb1.M_Name, tb1.M_BasicUnit

m_XuatNhapTon '09-01-2023', '09-16-2023'