Select *
From USPresidents;

Alter Table USPresidents DROP Column "Image_Path";

Delete from USPresidents
Output deleted.id, deleted.Last_Name, deleted.First_Name
Where ID = 1;

Update USPresidents
Set Date_Left_Office = '2017-01-20'
Output deleted.Date_Left_Office, inserted.Date_Left_Office
Where Last_Name = 'Obama';

Insert Into USPresidents (id, Last_Name,First_Name, Middle_Name,Order_of_Presidency,Date_of_Birth, Town_or_County_of_Birth,State_of_Birth,Home_State,Party_Affiliation,Date_Took_Office, Assassination_Attempt, Assassinated, Religious_Affiliation)
Output inserted.id,inserted.Last_Name, inserted.First_Name
Values (45, 'Trump', 'Donald', 'John', 45, '1946-06-14', 'Queens', 'New York', 'New York', 'Republican','2017-01-20',0,0,'Christian');

Select CONCAT(Last_Name, ' ', First_Name) as President, DATEDIFF(Day, Date_Took_Office, Date_Left_Office) as DaysAsPresident
From USPresidents;

Select CONCAT(Last_Name, ' ', First_Name) as President, DATEDIFF(Year, Date_of_Birth, Date_Took_Office) as YearsOld
From USPresidents;

Select Party_Affiliation, Religious_Affiliation
From USPresidents
Order by Party_Affiliation;