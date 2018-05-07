using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;

namespace TestWebAPIFromService
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 通过服务端调用API的基本步骤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCallAPI_Click(object sender, EventArgs e)
        {
            //localhost:3334/api/Score/QueryStudent
            //1.定义要使用的URL
            var url = "http://localhost:3334/api/Score/QueryStudent";
            //2.封装要传递的数据，需要以JSON格式并要做编码规范（防止中文乱码）
            var student = new
            {
                Score=80,
                StudentId=10010,
                StudentName="Tiger",
                Csharp=100,
                DB=98
            };
            string jsonData = new JavaScriptSerializer().Serialize(student);
            byte[] byteArray = Encoding.UTF8.GetBytes(jsonData);

            //3.创建请求对象,并设置相关属性
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = "post";
            webRequest.ContentType = "application/json";
            webRequest.ContentLength = byteArray.Length;

            //4.获取字节流对象，并向流中写入数据
            Stream byteStream = webRequest.GetRequestStream();
            byteStream.Write(byteArray, 0, byteArray.Length);
            byteStream.Close();

            //5.创建响应对象
            WebResponse webResponse = webRequest.GetResponse();

            //6.转换成HTTP对象
            var httpWebResponse = (HttpWebResponse)webResponse;

            //7.如果请求成功则读取所有数据
            if(httpWebResponse.StatusCode==HttpStatusCode.OK)
            {
                //7.1获取返回的数据流
                byteStream = webResponse.GetResponseStream();
                //7.2根据返回的数据流创建读取器
                StreamReader streamReader = new StreamReader(byteStream, Encoding.UTF8);
                //7.3读取所有数据
                string readContentFromService = streamReader.ReadToEnd();
                //显示结果
                this.txtInfo.Text = readContentFromService;
            }
            else
            {
                //可以进一步处理
            }
        }
    }
}
