/* Write your T-SQL query statement below */
/* Write your T-SQL query statement below */
select
    MGR.name as Employee
from
    Employee k, Employee MGR
where
    k.id=MGR.managerid
    And
    k.salary<MGR.salary;
