SELECT Contact_name, service_name, Appointment_Date
FROM Service join appointment on service.service_ID=appointment.Service_ID join Client on client.Client_ID=appointment.Client_ID join contact on contact.Contact_ID=client.Contact_ID
WHERE Service_Price < (SELECT AVG(Service_Price) From Service) ;