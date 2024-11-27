/* Write your T-SQL query statement below */
delete from person
where ID not in(
    select MIN(id)
    from person 
    group by email
    
    );