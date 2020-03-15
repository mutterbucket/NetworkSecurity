
a = input("Enter your first number: ")
b = input("Enter your second number: ")

a1 = 1
a2 = 0
a3 = int(a)

b1 = 0
b2 = 1
b3 = int(b)

while (b3 != 0) and (b3 != 1):
    q = a3//b3
    t1 = a1 - (q * b1)
    t2 = a2 - (q * b2)
    t3 = a3 - (q * b3)

    a1 = b1
    a2 = b2
    a3 = b3

    b1 = t1
    b2 = t2
    b3 = t3

    print(a1 , " " , a2 , " " , a3 , " " , b1 , " " , b2 , " " , b3 , "\n")

if b3 == 1:
    print("Inverse: " , b1)
    print("GCD: ", b3)

if b3 == 0:
    print("No inverse")
    print("GCD: ", a3)

