select
car.name, cat.categoryName
from car car LEFT JOIN category cat
ON car.categoryID=cat.id