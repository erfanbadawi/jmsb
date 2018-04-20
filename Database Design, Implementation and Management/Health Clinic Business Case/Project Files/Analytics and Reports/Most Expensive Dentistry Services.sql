SELECT Service_Name as 'Most Expensive Dentistry Services', Dentistry_Description as Description, Service_Price as Price
FROM dentistry_service join service on dentistry_service.service_ID=service.service_ID
WHERE Service_Price > (SELECT AVG(Service_Price) From Service Where Service_Type='Dentistry')
order by Service_Price desc;