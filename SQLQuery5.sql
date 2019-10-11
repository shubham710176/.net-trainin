

					 SELECT account_number,customer_master.customer_number,firstname,lastname,account_opening_date 
					 from customer_master,account_master 
					 where customer_master.customer_number=account_master.customer_number;
  
					 select count(*) as Cust_Count from customer_master where customer_city='Delhi'
					 	 
						 
				  SELECT account_number,customer_master.customer_number,firstname
					 from customer_master,account_master 
					 where customer_master.customer_number=account_master.customer_number and DAY(customer_date_of_birth)>15
					 order by customer_number,account_number

					 SELECT account_number,customer_master.customer_number,firstname,lastname,account_opening_date 
					 from customer_master,account_master 
					 where customer_master.customer_number=account_master.customer_number and account_status='TERMINATED';
					 
					 select t.transaction_type,COUNT(*) as Trans_Count 
from transaction_datails t, account_master a
where t.account_number=a.account_number and a.customer_number LIKE '%001'
group by transaction_type

select count(*) as Count_Customer 
from customer_master
where customer_number not in (select distinct customer_number from account_master )


select t.account_number ,sum(transaction_amount+a.opening_balance) 
from transaction_datails t join account_master a
on t.account_number=a.account_number
where transaction_type='DEPOSIT'
order by t.account_number,a.opening_balance