Select Distinct Vendor  from Game Where Vendor Not IN 
(Select Distinct Vendor From Game
where Game_ID IN (Select Game_ID From Rent Where S_Date between '2022-04-01' and '2022-04-30'))