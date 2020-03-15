
alphabet = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
		    'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' ']


print("Welcome to the One Time Pad key finder!")
ciphertext = input("Enter your ciphertext: \n")		
ciphertext = ciphertext.upper()

plaintext = input("Enter the plaintext to find a key for: \n")
plaintext = plaintext.upper()
i = 0;

print("Plain:  ", plaintext)
print("Cipher: ", ciphertext)
print("Key:     ", end = '')
for x in plaintext:                             
    plainindex = alphabet.index(x)
    letterindex = alphabet.index(ciphertext[i])
    i += 1
    if (letterindex - plainindex) < 0:
        letterindex = letterindex - plainindex + 27
        print (alphabet[letterindex], end = '')
    else:
        letterindex -= plainindex
        print (alphabet[letterindex], end = '')
print()

