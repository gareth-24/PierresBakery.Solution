<!-- README -->
Pseudocode / scratchwork:
```
Given: 
  Bread costs 5$ for single loaf
  Bread has buy 2 get 1 free deal, 3 breads costs 10$ (every 3rd loaf costs 0$)
  Pastry costs 2$
  Pastry has buy 3 get 1 free deal, 4 pastries costs 6$ (every 4th pastry costs 0$)

  -Build console app for the bakery
  -Test functionality for business logic of all models
  -Use 2 classes with auto-impelemented properties
  -create methods for determining the price of an order

Code:
say customer wants 7 loaves of bread...
7%3 = 1;
7/3 = 2.333 -> rounded to 2 because we are using 'int'

cost of first 6 loaves is 2 orders of (3 bread for $10)
cost of remaining loaf is a full $5

cost = (2*10) + (1*5) = $25;


```