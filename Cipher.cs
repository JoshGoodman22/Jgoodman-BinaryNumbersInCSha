public class Cipher
{

    private int shift;

    /// <summary>
    /// Constructs a shift cipher with the specified shift.
    /// </summary>
    /// <param name="shift">The amount to shift to be applied during encryption and decryption</param>
    public Cipher(int shift)
    {
        this.shift = shift;
    }

    /// <summary>
    /// Given an encrypted message, returns the result of decrypting it with this Cipher.
    /// </summary>
    /// <param name="message">The message to decrypt</param>
    /// <returns>The decrypted message</returns>
    public string Decrypt(string message)
    {
        string newMessage = string.Empty;
        foreach (char c in message)
        {
            newMessage += (char)(c - shift);
        }
        return newMessage;
    }

    /// <summary>
    /// Given a message, returns the result of encrypting it with this Cipher
    /// </summary>
    /// <param name="message">The message to encrypt</param>
    /// <returns>The encrypted message</returns>
    public string Encrypt(string message)
    {
        string newMessage = string.Empty;
        foreach (char c in message)
        {

            newMessage += (char)(c + shift);



        }
        return newMessage;
    }


}