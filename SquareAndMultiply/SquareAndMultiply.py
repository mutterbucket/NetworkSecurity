
a = int(input("Enter the base number: "))
b = int(input("Enter the exponent: "))
c = int(input("Enter the mod value: "))

exp = bin(b)[2:]
result = 1

print(exp)
for x in range(len(exp)):
    print("Round", x, ": ", exp[x], ": " , end="")
    result = (result * result) % c
    if exp[x] == '1':
        result = (result * a) % c
    print(result)
  

