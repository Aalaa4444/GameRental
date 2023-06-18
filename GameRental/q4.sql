

WITH lmgame as (select * from rent 
where s_date between '2022-04-01' and '2022-04-30')
select vendor from game where Game_ID IN (select game_id from lmgame
group by game_id 
having count(ACC_ID) = (select max(x.High) from (select count(*) as High from lmgame 
Group by GAME_ID 
)as x))

