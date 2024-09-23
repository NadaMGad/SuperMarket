
Select top(1) serial_number,count(buy.serial_number) as counts From buy Group by buy.serial_number order by buy.serial_number desc
select* from Product where serial_number not in (select serial_number from buy where TDate between '2/3/2022' and '3/4/2022'
select* from customer where PhoneNumber  not in (select phoneNumber from buy where  TDate not  between '2023-04-30'   and '2022-04-30'
Select top(1) PhoneNumber,count(customer.PhoneNumber) as counts From customer Group by customer.PhoneNumber order by customer.PhoneNumber desc

Select Product.serial_number, Product.name, Product.quantity, Product.price, Product.production_date, Product.expire_date,count(Product.serial_number) as counts from (Product Inner join buy on Product.serial_number = buy.serial_number)
Group by Product.serial_number buy.phoneNumber,Product.serial_number,Product.name, Product.quantity, Product.price, Product.production_date, Product.expire_date order by counts
