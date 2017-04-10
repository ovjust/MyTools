using System;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Soap;

namespace DotNet_Utilities
{

    #region 序列化
    public class Serialize
    {
        #region 序列化到Memory
        /// <summary>
        /// 序列化对象
        /// </summary>
        /// <param name="objname"></param>
        /// <param name="obj"></param>
        public static MemoryStream SerialMemory(object obj)
        {
            try
            {
                MemoryStream ms = new MemoryStream();

                {
                    // 用二进制格式序列化
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(ms, obj);
                    return ms;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 从二进制文件中反序列化
        /// </summary>
        /// <param name="objname"></param>
        /// <returns></returns>
        public static object DeSerialMemory(MemoryStream ms)
        {
            System.Runtime.Serialization.IFormatter formatter = new BinaryFormatter();
            //二进制格式反序列化
            object obj;

            obj = formatter.Deserialize(ms);


            return obj;

        }
        #endregion

        #region 二进制序列化到临时文件
        /// <summary>
        /// 序列化对象
        /// </summary>
        /// <param name="objname"></param>
        /// <param name="obj"></param>
        public static void BinarySerialize(string objname, object obj)
        {
            try
            {
                string filename = objname + ".Binary";
                if (System.IO.File.Exists(filename))
                    System.IO.File.Delete(filename);
                using (FileStream fileStream = new FileStream(filename, FileMode.Create))
                {
                    // 用二进制格式序列化
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(fileStream, obj);
                    fileStream.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 从二进制文件中反序列化
        /// </summary>
        /// <param name="objname"></param>
        /// <returns></returns>
        public static object BinaryDeserialize(string objname)
        {
            System.Runtime.Serialization.IFormatter formatter = new BinaryFormatter();
            //二进制格式反序列化
            object obj;
            string filename = objname + ".Binary";
            if (!System.IO.File.Exists(filename))
                throw new Exception("在反序列化之前,请先序列化");
            using (Stream stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                obj = formatter.Deserialize(stream);
                stream.Close();
            }
            //using (FileStream fs = new FileStream(filename, FileMode.Open))
            //{
            //    BinaryFormatter formatter = new BinaryFormatter();
            //    object obj = formatter.Deserialize(fs);
            //}
            return obj;

        }

        #endregion

    }
    #endregion
}

