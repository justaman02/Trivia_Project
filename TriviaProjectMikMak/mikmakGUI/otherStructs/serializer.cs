using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace mikmakGUI
{
    public static class serializer
    {
        public static byte[] buildMessage<Request>(ref Request requestStruct, int code)
        {
            byte[] jsonString = System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(requestStruct);     
            byte[] jsonSizeAndCode = new byte[5];
            int size = jsonString.Length;
            jsonSizeAndCode[0] = (byte)(code);
            jsonSizeAndCode[1] = (byte)(size >> 24);
            jsonSizeAndCode[2] = (byte)(size >> 16);
            jsonSizeAndCode[3] = (byte)(size >> 8);
            jsonSizeAndCode[4] = (byte)size;
            byte[] request = jsonSizeAndCode.Concat(jsonString).ToArray();
            return request;
        }

        //for empty requests
        public static byte[] buildMessage(int code)
        {
            byte[] jsonSizeAndCode = new byte[5];
            int size = 0;
            jsonSizeAndCode[0] = (byte)(code);
            jsonSizeAndCode[1] = (byte)(size >> 24);
            jsonSizeAndCode[2] = (byte)(size >> 16);
            jsonSizeAndCode[3] = (byte)(size >> 8);
            jsonSizeAndCode[4] = (byte)size;
            return jsonSizeAndCode;
        }
        public static Response DeAssembleMessage<Response>(byte [] response)
        {

            byte[] code = new byte[1];
            byte[] size = new byte[4];

            Client.client_socket.Receive(code, 1, 0);
            Client.client_socket.Receive(size, 4, 0);
            if(code[0] == 19)
            {
                Console.WriteLine("d");
            }
            int size_int =  Convert.ToInt32((byte)(size[0]) << 24 |
        (byte)(size[1]) << 16 |
        (byte)(size[2]) << 8 |
        (byte)(size[3]));
            byte[] status = new byte[size_int];
            Client.client_socket.Receive(status,size_int, 0);
            var readOnlySpan = new ReadOnlySpan<byte>(status);
            string result = System.Text.Encoding.UTF8.GetString(status);

            Response res = System.Text.Json.JsonSerializer.Deserialize<Response>(readOnlySpan);
  
            return res;
        }

        internal static byte[] buildMessage<T>()
        {
            throw new NotImplementedException();
        }

        public static Response DeDictionary <Response>(byte[] response)
        {

            byte[] code = new byte[1];
            byte[] size = new byte[4];

            Client.client_socket.Receive(code, 1, 0);
            Client.client_socket.Receive(size, 4, 0);
            int size_int = Convert.ToInt32((byte)(size[0]) << 24 |
        (byte)(size[1]) << 16 |
        (byte)(size[2]) << 8 |
        (byte)(size[3]));
            byte[] status = new byte[size_int];
            
            Client.client_socket.Receive(status, size_int, 0);
            string result = System.Text.Encoding.UTF8.GetString(status);
            var readOnlySpan = new ReadOnlySpan<byte>(status);

            var res = JsonConvert.DeserializeObject<Response>(result);

            return res;
        }
        
        public static Response DeAssembleMessageForThread<Response>(byte[] response)
        {
            byte[] size = new byte[4];

            Client.client_socket.Receive(size, 4, 0);
            int size_int = Convert.ToInt32((byte)(size[0]) << 24 |
        (byte)(size[1]) << 16 |
        (byte)(size[2]) << 8 |
        (byte)(size[3]));
            byte[] status = new byte[size_int];
            Client.client_socket.Receive(status, size_int, 0);
            var readOnlySpan = new ReadOnlySpan<byte>(status);
            Response res = System.Text.Json.JsonSerializer.Deserialize<Response>(readOnlySpan);
            return res;
        }

    }
}
