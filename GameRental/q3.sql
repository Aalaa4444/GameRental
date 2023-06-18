select Username,ACC_ID from Account where ACC_ID IN (select ACC_ID from rent Group by ACC_ID having count(*)=(select max(rcount) from (select count(*) as rcount from rent where s_date between '2022-02-01' and '2022-04-30'group by ACC_ID)as y))

WITH lmgame as (select * from rent where s_date between '2022-04-01' and '2022-04-30') select vendor from game where Game_ID IN (select game_id from lmgame group by game_id having count(ACC_ID) = (select max(x.High) from (select count(*) as High from lmgame Group by GAME_ID )as x))
