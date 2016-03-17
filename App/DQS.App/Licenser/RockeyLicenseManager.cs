using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace DQS.App.Licenser
{
    public class RockeyLicenseManager
    {
        private byte[] _pin;
        private byte[] _pid;
        public IntPtr Handle { get; private set; }

        public string DecryptedContent { get; private set; }

        public RockeyLicenseManager(string pid, string pin)
        {
            _pid = Encoding.UTF8.GetBytes(pid);
            _pin = Encoding.UTF8.GetBytes(pin);
        }


        [DllImport("Rockey1S.dll")]
        private static extern int R1_Find(byte[] pid, ref long dwCount);

        public bool Find()
        {
            long keyCount = 0;
            int result = R1_Find(_pid, ref keyCount);
            return result == 0;
        }

        [DllImport("Rockey1S.dll")]
        private static extern int R1_Open(ref IntPtr handle, byte[] pid, int nIndex);

        public bool Open()
        {
            IntPtr handle = IntPtr.Zero;
            int retcode = R1_Open(ref handle, null, 0);
            if (retcode == 0)
            {
                byte[] pid = new byte[8];

                var getPid = R1_GetPID(handle, pid);
                if (getPid != 0)
                {
                    return false;
                }

                if (Convert.ToBase64String(pid) == Convert.ToBase64String(_pid))
                {
                    Handle = handle;
                    Version = GetVersion();
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool IsOpened
        {
            get { return Handle != IntPtr.Zero; }
        }

        [DllImport("Rockey1S.dll")]
        private static extern int R1_GetPID(IntPtr handle, byte[] pid);

        [DllImport("Rockey1S.dll")]
        private static extern int R1_Close(IntPtr handle);

        public bool Close()
        {
            if (IsOpened)
            {
                int result = R1_Close(Handle);
                return result == 0;
            }
            return true;
        }

        [DllImport("Rockey1S.dll")]
        private static extern int R1_GetVersion(IntPtr handle, ref byte bVersionMajor, ref byte bVersionMinor);

        public string Version { get; private set; }

        public string GetVersion()
        {
            byte bVersion = 0;
            byte bVersionMinor = 0;
            //获得版本
            int result = R1_GetVersion(Handle, ref bVersion, ref bVersionMinor);
            if (result == 0)
            {
                return bVersion.ToString("d") + "." + bVersionMinor.ToString("d");
            }
            return string.Empty;
        }

        [DllImport("Rockey1S.dll")]
        private static extern int R1_GetHID(IntPtr handle, byte[] hid);

        public string Hid
        {
            get
            {
                if (!IsOpened)
                {
                    return string.Empty;
                }
                byte[] hid = new byte[16];
                int result = R1_GetHID(Handle, hid);
                if (result == 0)
                {
                    return System.Text.ASCIIEncoding.UTF8.GetString(hid);
                }
                return string.Empty;
            }
        }
        [DllImport("Rockey1S.dll")]
        private static extern int R1_VerifyUserPin(IntPtr handle, byte[] pin, ref byte tryCount);

        public bool VerifyUserPin()
        {
            byte tryCount = 0;
            if (!IsOpened)
            {
                Open();
            }
            int result = R1_VerifyUserPin(Handle, _pin, ref tryCount);

            return result == 0;
        }

        [DllImport("Rockey1S.dll")]
        private static extern int R1_VerifySoPin(IntPtr handle, byte[] pin, ref byte tryCount);
        [DllImport("Rockey1S.dll")]
        private static extern int R1_GenRandom(IntPtr handle, byte[] buffer);
        [DllImport("Rockey1S.dll")]
        private static extern int R1_Read(IntPtr handle, short wOffset, short wLength, byte[] buf, ref short len, byte bType);

        public string Read()
        {
            if (!VerifyUserPin())
            {
                return "Pin 校验失败！";
            }
            var buffer = new byte[128];//清空buffer

            short len = 0;
            int result = R1_Read(Handle, 0, 128, buffer, ref len, (byte)0);
            if (result == 0)
            {
                return Encoding.UTF8.GetString(buffer);
            }
            return string.Empty;
        }

        public byte[] ReadBytes()
        {
            var buffer = new byte[128];//清空buffer
            if (!VerifyUserPin())
            {
                return buffer;
            }

            short len = 0;
            int result = R1_Read(Handle, 0, 128, buffer, ref len, (byte)0);
            if (result == 0)
            {
                return buffer;
            }
            return buffer;
        }
        [DllImport("Rockey1S.dll")]
        private static extern int R1_Write(IntPtr handle, short wOffset, short wLength, byte[] buf, ref short len, byte bType);

        public bool Write(string content)
        {
            if (!VerifyUserPin())
            {
                return false;
            }
            short len = 0;
            byte[] writeBytes = new byte[128];
            byte[] contentBytes = Encoding.UTF8.GetBytes(content);
            contentBytes.CopyTo(writeBytes, 0);
            int result = R1_Write(Handle, 0, 128, writeBytes, ref len, 0);
            return result == 0;
        }

        public bool Write(byte[] content)
        {
            if (!VerifyUserPin())
            {
                return false;
            }
            short len = 0;
            int result = R1_Write(Handle, 0, 128, content, ref len, 0);
            return result == 0;
        }

        [DllImport("Rockey1S.dll")]
        private static extern int R1_GenRSAKey(IntPtr handle, byte bFlag, byte id, string pubkey, string prikey);
        [DllImport("Rockey1S.dll")]
        private static extern int R1_SetRSAKey(IntPtr handle, byte bFlag, byte id, string pubkey, string prikey);

        [DllImport("Rockey1S.dll")]
        private static extern int R1_RSAEnc(IntPtr handle, byte bFlag, byte id, byte[] bBuf, int dwLen);

        public string RSAEncrypt(string content)
        {
            if (!VerifyUserPin())
            {
                return "Pin 校验失败！";
            }
            string encryptedContent = string.Empty;
            byte[] contentBytes = Encoding.UTF8.GetBytes(Convert.ToBase64String(Encoding.UTF8.GetBytes(content)));
            byte[] buffer = new byte[128];

            contentBytes.CopyTo(buffer, 2);

            var result = R1_RSAEnc(Handle, (byte)0, (byte)0, buffer, 128);

            encryptedContent = ByteHelper.ByteArrayToString(buffer);

            if (0 == result)
            {
                Write(buffer);
            }
            return encryptedContent;
        }

        [DllImport("Rockey1S.dll")]
        private static extern int R1_RSADec(IntPtr handle, byte bFlag, byte id, byte[] bBuf, int dwLen);

        public string RSADecrypt(string encryptedContent)
        {
            if (!VerifyUserPin())
            {
                return "Pin 校验失败！";
            }
            string content = string.Empty;
            byte[] contentBytes = Encoding.UTF8.GetBytes(encryptedContent);
            byte[] buffer = new byte[contentBytes.Length];
            contentBytes.CopyTo(buffer, 0);
            var result = R1_RSADec(Handle, (byte)1, (byte)0, buffer, contentBytes.Length);
            if (0 == result)
            {
                byte[] bufferBytes = ByteHelper.ConvertBytes(buffer);
                content = Encoding.UTF8.GetString(bufferBytes, 0, bufferBytes.Length);
            }
            return content;
        }

        public string RSADecrypt(byte[] encryptedBytes)
        {
            if (!VerifyUserPin())
            {
                return "Pin 校验失败！";
            }
            string content = string.Empty;
            string encryptedString = ByteHelper.ByteArrayToString(encryptedBytes);
            var parsedBytes = ByteHelper.StringToByteArray(encryptedString);
            var result = R1_RSADec(Handle, (byte)1, (byte)0, parsedBytes, parsedBytes.Length);
            if (0 == result)
            {
                string decryptedString = ByteHelper.ByteArrayToString(parsedBytes);
                byte[] decryptedBytes = ByteHelper.StringToByteArray(decryptedString.Split(new string[] { "0000" }, StringSplitOptions.RemoveEmptyEntries)[0]);
                content = Encoding.UTF8.GetString(decryptedBytes);

                content = Encoding.UTF8.GetString(Convert.FromBase64String(content));
            }
            return content;
        }
        [DllImport("Rockey1S.dll")]
        private static extern int R1_SetTDesKey(IntPtr handle, byte id, byte[] buf);
        [DllImport("Rockey1S.dll")]
        public static extern int R1_TDesEnc(IntPtr handle, byte id, byte[] buf, int dwLen);
        [DllImport("Rockey1S.dll")]
        private static extern int R1_TDesDec(IntPtr handle, byte id, byte[] buf, int dwLen);
        [DllImport("Rockey1S.dll")]
        private static extern int R1_LEDControl(IntPtr handle, byte bFlag);
    }

    public class ByteHelper
    {

        /// <summary>
        /// 字节数组装换成十六进制字符串
        /// </summary>
        /// <param name="byteArray">要转换的字节数组</param>
        /// <returns>十六进制字符串</returns>
        public static string ByteArrayToString(byte[] byteArray)
        {
            StringBuilder hex = new StringBuilder(byteArray.Length*2);
            foreach (byte b in byteArray)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }

        /// <summary>
        /// 十六进制字符串转换成字节数组
        /// </summary>
        /// <param name="hexString">要转换的十六进制字符串</param>
        /// <returns>字节数组</returns>
        public static byte[] StringToByteArray(String hexString)
        {
            int charsLength = hexString.Length;
            byte[] bytes = new byte[charsLength/2];
            for (int i = 0; i < charsLength; i += 2)
            {
                bytes[i/2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }
            return bytes;
        }

        /// <summary>
        /// 字节数组转换
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] ConvertBytes(byte[] data)
        {
            sbyte[] signed = Array.ConvertAll(data, b => unchecked((sbyte) b));
            byte[] result = (byte[]) (signed as Array);
            return result;
        }
    }
}
