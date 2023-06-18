
select Title from game where GAME_ID IN(

select game_id from rent 
group by game_id 
having count(ACC_ID) = (select max(x.High) from (select count(*) as High from rent 
Group by GAME_ID )as x)
)
