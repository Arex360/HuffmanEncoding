using System;
using System.Collections;
using HuffmanEncodiong;
namespace huffman
{
    class Program
    {
        static void Main(string[] args)
        {
            string testStr = "This is a dummy text";
            string outFile = "output.jelly";
            CompressionInfo encodedFile = HuffmanCompressor.Encode(testStr, outFile);
            Console.WriteLine($"Successfully created : {encodedFile}");
            Console.WriteLine("Decoding..");
            string decodedText = HuffmanCompressor.Decode(outFile);
             Console.WriteLine(decodedText);
        }
    }
}
