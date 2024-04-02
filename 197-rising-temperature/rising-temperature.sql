select w2.id AS Id
from Weather AS w1
join Weather AS w2 
ON w1.temperature < w2.temperature
    and w1.recordDate = w2.recordDate - interval '1 day'