## EncryptionDecryptionUtility

### 📖 Overview  
EncryptionDecryptionUtility is a .NET Framework v4.7.2 console-based utility designed to perform symmetric encryption and decryption of textual data using the AES algorithm. 
The tool provides a simple menu-driven interface that allows users to securely encrypt sensitive information or decrypt previously encrypted data. 
This utility is ideal for scenarios where quick and local encryption of data is required without relying on external tools or libraries.

---
<br />



### 🔐 Definition
✅  Encryption & decryption are used to protect sensitive data, like passwords, credit card num, or confidential files. <br />
✅  Encryption - The process of converting plain text into unreadable text (cipher text) using an algorithm and a key.  <br />
✅  Decryption - Th eprocess of converting cipher text back into readable plain text using the same (or a related) key. <br />

---
<br />



### 🎯 Algorithms Used
```
1. AES Encryption (Symmetric Key Encryption) : 
   🔹 It stands for Advanced Encryption Standard.
   🔹 It uses only one secret key to both encrypt and decrypt data.
   🔹 It uses IV (Initialization Vector) - Even if the same key and same plain text are used, IV ensures that the result is different each time.
   🔹 Useful in encrypting passwords, tokens in a DB

2. RSA Encryption (Asymmetric Key Encryption) :
   🔹 It uses two keys - a public key to encrypt and a private key to decrypt.
   🔹 Only someone with the private key can decrypt what was encrypted with the public key.
   🔹 With symmetric keys (like AES), we have to share the key, which can be risky. RSA removes this risk: you give out the public key, but never share the private key.
   🔹 Useful when sending secure data over the internet to someone (e.g., SSL, JWT) or Secure communication between untrusted parties.

3. File Encryption using AES :
   🔹 Same as AES, but used to encrypt entire files instead of strings.
   🔹 AES is fast and secure — good for large data (like files).
   🔹 It use the same AES key and IV here too.
   🔹 Useful in encrypting personal documents (PDFs, reports) on disk.
   
```

---
<br />




### 🚀 Features  
✅ It uses the secure AES (Advanced Encryption Standard) algorithm to encrypt and decrypt text data. <br />
✅ Menu-driven UI makes it easy to choose between encryption, decryption, or exit operations. <br />
✅ Self-contained and Lightweight - runs as a standalone console application targeting .NET Framework 4.7.2. <br />
✅ Uses a predefined 128-bit key and IV for consistent encryption and decryption (for demonstration). <br />
✅ Handles decryption failures gracefully with user-friendly messages for invalid input or formatting. <br />

---
<br />



### 📁 Project Structure
```
EncryptionDecryptionUtility
│
├── bin\ 
├── obj\ 
├── Properties\
├── App.config
├── Program.cs              → Main menu and user interaction
├── AES_EncryptDecrypt.cs   → AES encryption/decryption
├── RSA_EncryptDecrypt.cs   → RSA encryption/decryption
└── File_EncryptDecrypt.cs  → AES-based file encryption
```

---
<br />




### 💡 Future Enhancements
1️⃣ Allow user-defined keys or save encrypted data to a file. <br />
2️⃣ Add RSA support for asymmetric encryption. <br />
3️⃣ Encrypt configuration values or passwords securely. <br />

---
<br />



### 🤝 Contribution
Pull requests are welcome! To contribute:

1️⃣ Fork the repo <br />
2️⃣ Create a feature branch (git checkout -b feature-xyz) <br />
3️⃣ Commit changes (git commit -m "Added feature xyz") <br />
4️⃣ Push to your branch (git push origin feature-xyz) <br />
5️⃣ Create a pull request 

---
<br />
<br />



















