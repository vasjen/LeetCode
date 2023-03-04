/*
607. Sales Person
https://leetcode.com/problems/sales-person/description/
Write an SQL query to report the names of all the salespersons 
who did not have any orders related to the company with the name "RED".
*/
SELECT SalesPerson.name
FROM SalesPerson
WHERE sales_id NOT IN
    (SELECT Orders.sales_id 
    FROM Orders WHERE com_id NOT IN
        (SELECT Company.com_id
        FROM Company
        RIGHT JOIN Orders
        ON Company.com_id = Orders.com_id
        WHERE Company.name!='RED'))