using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PO_PRO.Operations
{
    public static class Operations
    {
        public static byte[] ObjectToByteArray(object obj)
        {
            if (obj == null)
                return null;
            var bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }
        public static object ByteArrayToObject(byte[] arrBytes)
        {
            using (MemoryStream memoryStream1 = new MemoryStream())
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                memoryStream1.Write(arrBytes, 0, arrBytes.Length);
                memoryStream1.Seek(0L, SeekOrigin.Begin);
                MemoryStream memoryStream2 = memoryStream1;
                return binaryFormatter.Deserialize((Stream)memoryStream2);
            }
        }
    }
}