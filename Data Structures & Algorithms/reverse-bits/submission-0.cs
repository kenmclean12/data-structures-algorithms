public class Solution
{
    public uint ReverseBits(uint n)
    {
        uint result = 0;
        for (int i = 0; i < 32; i++)
        {
            result <<= 1;         // Make room for the next bit
            result |= n & 1;      // Add least significant bit of n
            n >>= 1;              // Shift n to get next bit
        }
        return result;
    }
}