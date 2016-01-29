using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace 小工具.Common
{
    public class FtpTool
    {
        #region FTP获取文件列表

        /// <summary>
        /// FTP获取文件列表 create ramble 2011.2.23
        /// </summary>
        /// <param name="ftpServerIP"></param>
        /// <param name="ftpUserID"></param>
        /// <param name="ftpPassword"></param>
        /// <returns></returns>
        public string[] FTPGetFileList(string ftpServerIP, string ftpUserID, string ftpPassword)
        {
            //响应结果
            StringBuilder result = new StringBuilder();

            //FTP请求
            FtpWebRequest ftpRequest = null;

            //FTP响应
            WebResponse ftpResponse = null;

            //FTP响应流
            StreamReader ftpResponsStream = null;

            try
            {
                //生成FTP请求
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/"));

                //设置文件传输类型
                ftpRequest.UseBinary = true;

                //FTP登录
                ftpRequest.Credentials = new NetworkCredential(ftpUserID, ftpPassword);

                //设置FTP方法
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;

                //生成FTP响应
                ftpResponse = ftpRequest.GetResponse();

                //FTP响应流
                ftpResponsStream = new StreamReader(ftpResponse.GetResponseStream());

                string line = ftpResponsStream.ReadLine();

                while (line != null)
                {
                    result.Append(line);
                    result.Append("\n");
                    line = ftpResponsStream.ReadLine();
                }

                //去掉结果列表中最后一个换行
                result.Remove(result.ToString().LastIndexOf('\n'), 1);

                //返回结果
                return result.ToString().Split('\n');
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (null);
            }
            finally
            {
                if (ftpResponsStream != null)
                {
                    ftpResponsStream.Close();
                }

                if (ftpResponse != null)
                {
                    ftpResponse.Close();
                }
            }
        }



        /// <summary>
        /// FTP获取文件列表 create ramble 2011.2.23
        /// </summary>
        /// <param name="ftpServerIP"></param>
        /// <param name="ftpUserID"></param>
        /// <param name="ftpPassword"></param>
        /// <returns></returns>
        public static string FTPGetFileListStr(string ftpServerIP, string ftpUserID, string ftpPassword)
        {
            //响应结果
            StringBuilder result = new StringBuilder();

            //FTP请求
            FtpWebRequest ftpRequest = null;

            //FTP响应
            WebResponse ftpResponse = null;

            //FTP响应流
            StreamReader ftpResponsStream = null;

            try
            {
                //生成FTP请求
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP ));

                //设置文件传输类型
                ftpRequest.UseBinary = true;

                //FTP登录
                ftpRequest.Credentials = new NetworkCredential(ftpUserID, ftpPassword);

                //设置FTP方法
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;

                //生成FTP响应
                ftpResponse = ftpRequest.GetResponse();

                //FTP响应流
                ftpResponsStream = new StreamReader(ftpResponse.GetResponseStream());

                string line = ftpResponsStream.ReadLine();

                while (line != null)
                {
                    result.Append(line);
                    result.Append("\n");
                    line = ftpResponsStream.ReadLine();
                }

                //去掉结果列表中最后一个换行
                //result.Remove(result.ToString().LastIndexOf('\n'), 1);

                //返回结果
                return result.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (null);
            }
            finally
            {
                if (ftpResponsStream != null)
                {
                    ftpResponsStream.Close();
                }

                if (ftpResponse != null)
                {
                    ftpResponse.Close();
                }
            }
        }


        #endregion

       

    }
}
