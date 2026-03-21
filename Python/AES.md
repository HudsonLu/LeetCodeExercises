# AES-128 Implementation

## AES Explained

AES is a symmetric block cipher (same key used for both encryption & decryption)
It uses 16-byte blocks (128 bits) for both plaintext and ciphertext with a key size of 16 bytes (for A-128)

AES-128 consists of 10 rounds of transformations with the following transformations:

- SubtituteBytes / InvSubBytes       ```Substitutes each byte using an S-box (lookup table) ```
- ShiftRows / InvShiftRows       ```Shifts the rows of the state by fixed offsets.```
- MixColumns / InvMixColumns       ```Mixes the bytes within each column using GF(2^8) arithmetic.```          
- AddRoundKey                        ```XOR the current state with the round key``` 

The initial transformation (round 0) has only AddRoundKey while the last round does not include mix column transformation.

AES-128 uses a 16-byte (128-bit) key. During key expansion, it generates 44 words from w0 to w43 (each word = 4 bytes). Each round key consists of 4 words, and AES-128 uses 11 round keys (1 initial + 10 rounds).

The key expansion algorithm expands one 16-byte key into all 11 AES-128 round keys using ```g``` function and XOR. The round constants are fixed at 
01, 02, 04, 08, 10, 20, 40, 80, 1B, 36

### Definitions

The ```S-box``` is a 16x16 lookup table used to substitute each byte with another byte. Each byte is represented using hexadecimal (1 byte = 2 hex digits).

The ```round constant (Rcon)``` is used in key expansion to ensure each round key is unique and to prevent patterns.

```Galois Field (finite field)``` refers to 1 byte (0–255) = 256 possible values, so GF(2^8)

```MIX_MATRIX``` is a fix MixColumns matrix that is multiplied with the state matrix

```G function``` is a fixed AES key expansion step that executes 
1. Rotate the bytes left by 1
2. Substitute each byte using the S-box
3. XOR the first byte with the round constant

## Security & Attacks
This algorithm hides the pattern (confusion) and spread information (diffusion) through those transformations. It is relatively simple to implement as it code compact and operate decently well in slow performance processors and consumes a limited amount of memory as it is very efficient.

It is strong against known attacks 
- brute-force attacks as the key space is 2^128 
- statistical attacks as the ciphertext appear random
- differential/linear/practical analysis attacks

However, we need to be careful on implementation issues like reusing keys, timing or cache attacks. We need to share the keys to both the sender and receiver securely.


## References:

https://www.youtube.com/watch?v=O4xNJsjtN6E&t=48s (AES overview)
https://www.youtube.com/watch?v=4KiwoeDJFiA (AES decryption/encryption)
https://www.youtube.com/watch?v=IpuvKyeCrvU (AES transformations)
