

select game_id from game where game_id not in(select distinct GAME_ID from rent 
where S_Date between '2022-04-01' and '2022-04-30'
 ) 