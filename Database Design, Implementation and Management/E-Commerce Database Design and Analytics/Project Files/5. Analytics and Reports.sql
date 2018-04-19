Create View Recency as 
SELECT 
        `order`.`Customer_ID` AS `Customer_ID`,
        MAX(`order`.`Order_Date`) AS `Recency`
    FROM
        `order`
    GROUP BY `order`.`Customer_ID`;
    
    
Create View Frequency as 
SELECT 
        `order`.`Customer_ID` AS `Customer_ID`, COUNT(0) AS `Frequency`
    FROM
        (`customer`
        JOIN `order`)
    WHERE
        (`customer`.`Customer_ID` = `order`.`Customer_ID`)
    GROUP BY `order`.`Customer_ID`;

Create View MostValue as
Select Customer_ID, max(order_per_product.Order_Per_Prod_Quantity*order_per_product.Order_Per_Prod_Price) as MonetaryValue
From `order` join order_per_product on `order`.Order_ID=order_per_product.Order_ID
Group by Customer_ID;

Create View RFMView as 
Select CONCAT(Customer.Customer_FName, " ",Customer.Customer_Lname) as Customer_Name, frequency.Frequency, recency.recency, mostvalue.MonetaryValue
From Customer, frequency, recency, mostvalue
where Customer.Customer_ID=frequency.Customer_ID and Customer.Customer_ID=recency.Customer_ID and Customer.Customer_ID=mostvalue.Customer_ID
Group by Customer_Name, Frequency, recency, MonetaryValue;

Create view RFM_Mean as Select 
avg(rfmview.Frequency) as mean_freq,
avg(rfmview.recency) as mean_rec,
avg(rfmview.MonetaryValue) as mean_val
from rfmview;

Create view RFM_SCORING AS SELECT 
        Customer_Name,
        (Case 
        when rfmview.Frequency > rfm_mean.mean_freq then 1
        else  0
        End) as Freq,
        (Case 
        when rfmview.recency > rfm_mean.mean_rec then 1
        else 0 
        end) as Recent,
        (Case 
        when rfmview.MonetaryValue > rfm_mean.mean_val then 1
        else 0 
        end) as Valuable
        from rfmview, rfm_mean
        group by Customer_Name, freq, recent, valuable;
        
Create view FinalRFMScore as 

SELECT Customer_Name, (recent+freq+valuable) as RFM_Score
from rfm_scoring
order by RFM_Score desc;

