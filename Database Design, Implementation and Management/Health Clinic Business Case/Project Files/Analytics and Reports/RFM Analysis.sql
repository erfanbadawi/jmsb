Create View Recency as
SELECT 
        `Appointment`.`Client_ID` AS `Client_ID`,
        MAX(`Appointment`.`Appointment_Date`) AS `Recency`
    FROM
        `Appointment`
    GROUP BY `Appointment`.`Client_ID`;

Create view Frequency as 
SELECT 
        `Appointment`.`Client_ID` AS `Client_ID`, COUNT(0) AS `Frequency`
    FROM
        (`Client`
        JOIN `Appointment`)
    WHERE
        (`Client`.`Client_ID` = `Appointment`.`Client_ID`)
    GROUP BY `Appointment`.`Client_ID`;

Create View MostValue as
Select 
Client_ID,
max(Service_Price) as MonetaryValue
From 
Appointment join Service on Appointment.Service_ID=Service.Service_ID
Group by Client_ID;

Create View RFMView as 
Select Contact_Name, frequency.Frequency, recency.recency, mostvalue.MonetaryValue
From Client join Contact on Client.Contact_ID=Contact.Contact_ID, frequency, recency, mostvalue
where Client.Client_ID=frequency.Client_ID and Client.Client_ID=recency.Client_ID and Client.Client_ID=mostvalue.Client_ID
Group by Contact_Name, Frequency, recency, MonetaryValue;

Create view RFM_Mean as 
Select 
avg(rfmview.Frequency) as mean_freq,
avg(rfmview.recency) as mean_rec,
avg(rfmview.MonetaryValue) as mean_val
from rfmview;

Create view RFM_SCORING AS SELECT 
        Contact_Name,
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
        group by Contact_Name, freq, recent, valuable;


Create view FinalRFMScore as 

SELECT Contact_Name, (recent+freq+valuable) as RFM_Score
from rfm_scoring
order by RFM_Score desc;

