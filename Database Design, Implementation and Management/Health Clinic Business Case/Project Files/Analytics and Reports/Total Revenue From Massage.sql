SELECT Sum(Service_Price) as 'Total Revenue from Massage', count(service_ID) as 'Total Number of Appointments', avg(Service_Price) as 'The average revenue per each appointment'
FROM service 
WHERE Service_ID in (SELECT appointment.Service_ID From appointment join service on appointment.service_ID=service.service_ID Where Service_Type='Massage');