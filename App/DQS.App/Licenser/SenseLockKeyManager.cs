using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DQS.App.Licenser
{
    public class SenseLockKeyManager
    {
        //Sense4 API

        // ctlCode definition for S4Control
        public static uint S4_LED_UP = 0x00000004; // LED up
        public static uint S4_LED_DOWN = 0x00000008; // LED down
        public static uint S4_LED_WINK = 0x00000028; // LED wink
        public static uint S4_GET_DEVICE_TYPE = 0x00000025; //get device type
        public static uint S4_GET_SERIAL_NUMBER = 0x00000026; //get device serial
        public static uint S4_GET_VM_TYPE = 0x00000027; // get VM type
        public static uint S4_GET_DEVICE_USABLE_SPACE = 0x00000029; // get total space
        public static uint S4_SET_DEVICE_ID = 0x0000002a; // set device ID
        public static uint S4_GET_LICENSE = 0x00000020; // GET_LICENSE
        public static uint S4_FREE_LICENSE = 0x00000021; // free license
        public static uint S4_MODIFY_TIMOUT = 0x00000022; // change the timeout value

        // device type definition 
        public static uint S4_LOCAL_DEVICE = 0x00; // local device
        public static uint S4_MASTER_DEVICE = 0x80; // net master device
        public static uint S4_SLAVE_DEVICE = 0xc0; // net slave device

        // vm type definiton 
        public static uint S4_VM_51 = 0x00; // VM51
        public static uint S4_VM_251_BINARY = 0x01; // VM251 binary mode
        public static uint S4_VM_251_SOURCE = 0x02; // VM251 source mode


        // PIN type definition 
        public static uint S4_USER_PIN = 0x000000a1; // user PIN
        public static uint S4_DEV_PIN = 0x000000a2; // dev PIN
        public static uint S4_AUTHEN_PIN = 0x000000a3; // autheticate Key


        // file type definition 
        public static uint S4_RSA_PUBLIC_FILE = 0x00000006; // RSA public file
        public static uint S4_RSA_PRIVATE_FILE = 0x00000007; // RSA private file 
        public static uint S4_EXE_FILE = 0x00000008; // VM file
        public static uint S4_DATA_FILE = 0x00000009; // data file

        // dwFlag definition for S4WriteFile
        public static uint S4_CREATE_NEW = 0x000000a5; // create new file
        public static uint S4_UPDATE_FILE = 0x000000a6; // update file
        public static uint S4_KEY_GEN_RSA_FILE = 0x000000a7; // produce RSA key pair

        public static uint S4_SET_LICENCES = 0x000000a8;
            // set the license number for modle,available for net device only

        public static uint S4_CREATE_ROOT_DIR = 0x000000ab; // create root directory, available for empty device only
        public static uint S4_CREATE_SUB_DIR = 0x000000ac; // create child directory
        public static uint S4_CREATE_MODULE = 0x000000ad; // create modle, available for net device only

        // the three parameters below must be bitwise-inclusive-or with S4_CREATE_NEW, only for executive file
        public static uint S4_FILE_READ_WRITE = 0x00000000; // can be read and written in executive file,default
        public static uint S4_FILE_EXECUTE_ONLY = 0x00000100; // can NOT be read or written in executive file
        public static uint S4_CREATE_PEDDING_FILE = 0x00002000; // create padding file


        /* return value*/
        public static uint S4_SUCCESS = 0x00000000; // succeed
        public static uint S4_UNPOWERED = 0x00000001;
        public static uint S4_INVALID_PARAMETER = 0x00000002;
        public static uint S4_COMM_ERROR = 0x00000003;
        public static uint S4_PROTOCOL_ERROR = 0x00000004;
        public static uint S4_DEVICE_BUSY = 0x00000005;
        public static uint S4_KEY_REMOVED = 0x00000006;
        public static uint S4_INSUFFICIENT_BUFFER = 0x00000011;
        public static uint S4_NO_LIST = 0x00000012;
        public static uint S4_GENERAL_ERROR = 0x00000013;
        public static uint S4_UNSUPPORTED = 0x00000014;
        public static uint S4_DEVICE_TYPE_MISMATCH = 0x00000020;
        public static uint S4_FILE_SIZE_CROSS_7FFF = 0x00000021;
        public static uint S4_DEVICE_UNSUPPORTED = 0x00006a81;
        public static uint S4_FILE_NOT_FOUND = 0x00006a82;
        public static uint S4_INSUFFICIENT_SECU_STATE = 0x00006982;
        public static uint S4_DIRECTORY_EXIST = 0x00006901;
        public static uint S4_FILE_EXIST = 0x00006a80;
        public static uint S4_INSUFFICIENT_SPACE = 0x00006a84;
        public static uint S4_OFFSET_BEYOND = 0x00006B00;
        public static uint S4_PIN_BLOCK = 0x00006983;
        public static uint S4_FILE_TYPE_MISMATCH = 0x00006981;
        public static uint S4_CRYPTO_KEY_NOT_FOUND = 0x00009403;
        public static uint S4_APPLICATION_TEMP_BLOCK = 0x00006985;
        public static uint S4_APPLICATION_PERM_BLOCK = 0x00009303;
        public static int S4_DATA_BUFFER_LENGTH_ERROR = 0x00006700;
        public static uint S4_CODE_RANGE = 0x00010000;
        public static uint S4_CODE_RESERVED_INST = 0x00020000;
        public static uint S4_CODE_RAM_RANGE = 0x00040000;
        public static uint S4_CODE_BIT_RANGE = 0x00080000;
        public static uint S4_CODE_SFR_RANGE = 0x00100000;
        public static uint S4_CODE_XRAM_RANGE = 0x00200000;
        /// <summary>
        /// 未知的错误
        /// </summary>
        public static uint S4_ERROR_UNKNOWN = 0xffffffff;


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SENSE4_CONTEXT
        {
            public int dwIndex; //device index
            public int dwVersion; //version
            public int hLock; //device handle
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)] public byte[] reserve;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)] public byte[] bAtr;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public byte[] bID;
            public uint dwAtrLen;
        }

        public static Dictionary<uint, string> ErrorMessages = new Dictionary<uint, string>
        {
            {0x00000201, "当前目录不是根目录，网络版设备创建的模块必须在根目录下，仅对网络版适用。"},
            {0x00000202, "当前目录不是模块目录，仅对网络版适用。"},
            {0x00000301, "没有发现指定的模块。"},
            {0x00000302, "已经获取授权。"},
            {0x00000303, "网络版连接未发现用户。"},
            {0x00000304, "无效的授权。"},
            {0x00000305, "网络版操作超时。"},
            {0x00000306, "网络错误。"},
            {0x00000307, "没有可用授权，授权已经占满。"},
            {0x00000308, "执行文件错误。"},
            {0x00000309, "超过总授权数。"},
            {0x00000310, "超过模块授权数。"},
            {0x00000311, "无效设备。"},
            {0x00000313, "模块数为0。"},
            {0x00000314, "非法的设备类型。"},
            {0x00000315, "启动设备失败。"},
            {0x00000316, "停止设备失败。"},
            {0x00000321, "释放授权时出现错误。"},
            {0x00000324, "网络版通讯超时。"},
            {0xffffffff, "未知的错误。"},
        };

            //Assume that Sense4user.dll in c:\, if not, modify the lines below
        [DllImport(@"sense4user.dll")]
        private static extern uint S4Enum([MarshalAs(UnmanagedType.LPArray), Out] SENSE4_CONTEXT[] s4_context,
            ref uint size);

        [DllImport(@"sense4user.dll")]
        private static extern uint S4Open(ref SENSE4_CONTEXT s4_context);

        [DllImport(@"sense4user.dll")]
        private static extern uint S4Close(ref SENSE4_CONTEXT s4_context);

        [DllImport(@"sense4user.dll")]
        private static extern uint S4Control(ref SENSE4_CONTEXT s4Ctx, uint ctlCode, byte[] inBuff,
            uint inBuffLen, byte[] outBuff, uint outBuffLen, ref uint BytesReturned);

        [DllImport(@"sense4user.dll")]
        private static extern uint S4Execute(ref SENSE4_CONTEXT s4Ctx, string FileID, byte[] InBuffer,
            uint InbufferSize, byte[] OutBuffer, uint OutBufferSize, ref uint BytesReturned);

        public static SENSE4_CONTEXT Open()
        {
            uint size = 0;

            byte[] inBuffer = new byte[512];

            byte[] outBuffer = new byte[256];

            byte[] wModID = new byte[2];

            byte[] wNewtimeouts = new byte[2];

            uint BytesReturned = 0;

            // 查找网络锁，配置文件在同目录下：e4ncli.ini
            uint ret = S4Enum(null, ref size);
            SENSE4_CONTEXT[] si = new SENSE4_CONTEXT[size/Marshal.SizeOf(typeof (SENSE4_CONTEXT))];
            ret = S4Enum(si, ref size);
            if (ret != S4_SUCCESS)
            {
                //Console.WriteLine("S4Enum Error! Error Code: 0x{0:x8}", ret)
                throw new Exception(string.Format("授权服务器枚举失败，请联系管理员。\n错误代码: 0x{0:x8} ({1})", ret, GetErrorMessage(ret)));
            }

            // 打开网络锁
            ret = S4Open(ref si[0]);
            if (ret != S4_SUCCESS)
            {
                //Console.WriteLine("S4Open Error! Error Code: 0x{0:x8}", ret);
                throw new Exception(string.Format("客户端连接授权服务失败，请联系管理员。\n错误代码: 0x{0:x8} ({1})", ret, GetErrorMessage(ret)));
            }

            // 获取授权
            wModID[0] = 0x01;
            wModID[1] = 0x00;
            ret = S4Control(ref si[0], S4_GET_LICENSE, wModID, 2, null, 0, ref BytesReturned);
            if (ret != S4_SUCCESS)
            {
                //Console.WriteLine("S4_GET_LICENSE Error! Error Code: 0x{0:x8}", ret);
                S4Close(ref si[0]);
                throw new Exception(string.Format("客户端获取授权失败，请联系管理员。\n错误代码: 0x{0:x8} ({1})", ret, GetErrorMessage(ret)));
            }

            return si[0];
/*
                // 执行并返回结果
                inBuffer[0] = 0x01;
                inBuffer[1] = 0x03;
                inBuffer[2] = 0x02;
                inBuffer[3] = 0x06;
                inBuffer[4] = 0x05;
                inBuffer[5] = 0x04;
                inBuffer[6] = 0x09;
                inBuffer[7] = 0x08;
                inBuffer[8] = 0x07;
                ret = S4Execute(ref si[0], "0001", inBuffer, 9, outBuffer, 9, ref BytesReturned);
                if (ret != S4_SUCCESS)
                {
                    Console.WriteLine("S4Execute Error! Error Code: 0x{0:x8}", ret);
                    S4Close(ref si[0]);
                }
                if (outBuffer[0] == 0x09 &&
                    outBuffer[1] == 0x08 &&
                    outBuffer[2] == 0x07 &&
                    outBuffer[3] == 0x06 &&
                    outBuffer[4] == 0x05 &&
                    outBuffer[5] == 0x04 &&
                    outBuffer[6] == 0x03 &&
                    outBuffer[7] == 0x02 &&
                    outBuffer[8] == 0x01)
                    Console.WriteLine("S4Execute  Device Verify SUCCESS!");
                Console.WriteLine("S4Execute  SUCCESS!");
*/
        }

        private static string GetErrorMessage(uint ret)
        {
            return ErrorMessages.ContainsKey(ret) ? ErrorMessages[ret] : ErrorMessages[S4_ERROR_UNKNOWN];
        }

        public static void Close(SENSE4_CONTEXT si)
        {
            uint BytesReturned = 0;
            uint ret = S4Control(ref si, S4_FREE_LICENSE, null, 0, null, 0, ref BytesReturned);
            if (ret != S4_SUCCESS)
            {
                S4Close(ref si);
                //Console.WriteLine("S4_FREE_LICENSE Error! Error Code: 0x{0:x8}", ret);
                throw new Exception(string.Format("客户端释放授权失败，请联系管理员释放授权。\n错误代码: 0x{0:x8} ({1})", ret, GetErrorMessage(ret)));

            }

            // 关闭连接
            ret = S4Close(ref si);
            if (ret != S4_SUCCESS)
            {
                //Console.WriteLine("S4Close Error! Error Code: 0x{0:x8}", ret);
                throw new Exception(string.Format("客户端与授权服务器连接关闭失败，请联系管理员。\n错误代码: 0x{0:x8} ({1})", ret, GetErrorMessage(ret)));
            }
        }
    }
}