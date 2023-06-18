select distinct vendor from game where vendor not in 
(select distinct vendor from game where year = 2021 )