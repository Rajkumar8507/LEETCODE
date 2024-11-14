/* Write your T-SQL query statement below */
SELECT top 1 customer_number from Orders
group by customer_number
order by Count(order_number) desc;