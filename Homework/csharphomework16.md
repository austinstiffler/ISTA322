# C# Chapter 16 Homework
## Austin Stiffler
### 03 March, 2021


1. 
	* **The NOT (~) operator:** in 32 bits, 204 is 0b0_00000000_00000000_00000000_11001100, so in C#, ~204 is 0b0_11111111_11111111_11111111_00110011 
	* **The left-shift (<<) operator:** 204 decimal is 0b0_11001100, and shifting it left by two places yields 0b0_00110000, or 48 decimal
	* **The OR (|) operator:** 204 | 24 has the value 220 (204 is 0b0_11001100, 24 is 0b0_00011000, and 220 is 0b0_11011100)
	* **The AND (&) operator:** 204 & 24 is 8 (204 is 0b0_11001100, 24 is 0b0_00011000, and 8 is 0b0_00001000)
	* **The XOR (^) operator:** 204 ^ 24 is 212 (0b0_11001100 ^ 0b0_00011000 is 0b0_11010100)
	
1. Yes, it will right-shift the bits accessed by a value.

1.  1 is shifted left by whatever the value of index is. Whatever 1's match between bits and the expression will be returned.

1. 1 is shifted left by whatever the value of index is. Whatever 1's are input between bits or the expression will be returned.

1. 1 is shifted left by whatever the value of index is. Whatever 1's are input between bits and the expression will be returned.

1. The value of n is true.

1. The value of n is false.

1. 
	a. None
	b. read
	c. write
	d. read and write
	e. execute
	f. read and execute
	g. write and execute
	h. read, write and execute
	
1. 
	a. 0
	b. 0001
	c. 0010
	d. 0011
	e. 0100
	f. 0101
	g. 0110
	h. 0111