SELECT p.NameProduct, c.NameCategory
FROM Products p JOIN 
ProductDetails pd
ON p.id = od.Product_Id
RIGHT JOIN Category c
ON c.Id = pd.Category_Id