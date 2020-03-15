alphabet = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
		    'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z']

def encrypt():
	key = input("What is the key for the Caesar shift? ")
	key = key.upper()										#Everything is processed uppercase
	keyindex = alphabet.index(key)
	
	plaintext = input("Enter your plaintext: \n")
	plaintext = plaintext.upper()
	
	for x in plaintext:										#Each letter is shifted by the distance
		letterindex = alphabet.index(x)						#between the key and the letter A 
		if (letterindex + keyindex) > 25:
			letterindex = letterindex + keyindex - 26
			print (alphabet[letterindex], end = '')
		else:
			letterindex += keyindex
			print (alphabet[letterindex], end = '')
	print()

def decrypt():
	ciphertext = input("Enter your ciphertext: \n")			#All possible solutions are printed
	ciphertext = ciphertext.upper()
	for x in alphabet:
		keyindex = alphabet.index(x)
		print (keyindex, ":", end = '')
		for y in ciphertext:
			letterindex = alphabet.index(y)						
			if (letterindex + keyindex) > 25:
				letterindex = letterindex + keyindex - 26
				print (alphabet[letterindex], end = '')
			else:
				letterindex += keyindex
				print (alphabet[letterindex], end = '')
		print()
		

print("Welcome to the Caesar Cipher!")
task = input("Would you like to (E)ncrypt or (D)ecrypt? ")
task = task.upper()

if task == 'E':
	encrypt()

elif task == 'D':
	decrypt()

else:
	print ("Perhaps next time")

