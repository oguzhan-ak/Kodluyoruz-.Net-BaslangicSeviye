# Binary Search Tree

Kodluyoruz Binary Search Tree Projesi

## Aşamalar

[7, 5, 1, 8, 3, 6, 0, 9, 4, 2]

```
1-                                        5
2-                          3                           7
3-                1                4             6              8
4-          0          2                                              9
```

root 5'tir.
3; 5'ten küçük olduğu için 5'in solundadır.
1; 3'ten küçük olduğu için 3'ün solundadır.
4; 5'ten küçük ve 3'ten büyük olduğu için 3'ün sağındadır.
0; 1,3 ve 5'ten küçük olduğu için 1'in solundadır.
2; 3 ve 5'ten küçük olduğu için ve 1'den büyük olduğu için 1'in sağındadır.
7; 5'ten büyük olduğu için 5'in sağındadır.
6; 5'ten büyük olduğu için ve 7'den küçük olduğu için 7'nin solundadır.
8; 5 ve 7'den büyük olduğu için 7'nin sağındadır.
9; 5,7, ve 8'den büyük olduğu için 8'in sağındadır.
