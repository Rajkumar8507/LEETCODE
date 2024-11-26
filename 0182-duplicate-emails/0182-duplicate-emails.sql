SELECT distinct K.Email AS Email
FROM person k,person m
where 
k.email=m.email and k.id != m.id;


