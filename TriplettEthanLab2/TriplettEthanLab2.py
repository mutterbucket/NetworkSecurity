alphabet = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
		    'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z']

def encrypt():
    key = input("What is the key for the Vigenere cipher? ")
    key = key.upper()									#Everything is processed uppercase
    y = 0
    keyindex = alphabet.index(key[y])
   

    plaintext = input("Enter your plaintext: \n")
    plaintext = plaintext.upper()

    for x in plaintext:										#Each letter is shifted by the distance
        keyindex = alphabet.index(key[y])
        letterindex = alphabet.index(x)						#between the key and the letter A 
        if (letterindex + keyindex) > 25:
            letterindex = letterindex + keyindex - 26
            print (alphabet[letterindex], end = '')
        else:
            letterindex += keyindex
            print (alphabet[letterindex], end = '')
        if (y >= len(key) - 1):
            y = 0;
        else:
            y += 1
    

print("Welcome to the Vigenere Cipher!")
task = input("Would you like to (E)ncrypt some text? ")
task = task.upper()

if task == 'E':
    encrypt()
    print()

else:
	print ("Perhaps next time")


