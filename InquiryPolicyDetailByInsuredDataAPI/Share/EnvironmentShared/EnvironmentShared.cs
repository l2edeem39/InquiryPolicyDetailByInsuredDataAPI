using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace InquiryPolicyDetailByInsuredDataAPI.Share.EnvironmentShared
{
    public class EnvironmentShared
    {
        public static IHttpContextAccessor _httpContextAccessor;
        public static IConfiguration _configuration;
        public static IWebHostEnvironment _webHostEnvironment;

        public static string GetConnectionString() => _configuration != null ? _configuration.GetConnectionString("r4ad01") : null;
        public static string GetConnectionString(string sectionName)
        {
            return _configuration.GetConnectionString(sectionName);
        }
        public static string GetProjectName()
        {
            return _configuration.GetSection("ProjectName").Value;
        }
        public static string GetProjectName(string sectionName)
        {
            return _configuration.GetSection(sectionName)?.Value;
        }
        public static string GetSection(string sectionName)
        {
            return _configuration.GetSection(sectionName)?.Value;
        }
        public static string GetWebRootPath()
        {
            return _webHostEnvironment.WebRootPath;
        }
        public static string GetContentRootPath()
        {
            return _webHostEnvironment.ContentRootPath;
        }
        public static IFileProvider GetWebRootFileProvider()
        {
            return _webHostEnvironment.WebRootFileProvider;
        }
        public static string GetEnvironmentName()
        {
            return _webHostEnvironment.EnvironmentName;
        }
        public static string GetApplicationName()
        {
            return _webHostEnvironment.ApplicationName;
        }
        public static string GetIpAddress()
        {
            IPHostEntry ip = Dns.GetHostEntry(Dns.GetHostName());
            var ipAddress = ip.AddressList[0].ToString().Length > 15 ? ip.AddressList[1].ToString() : ip.AddressList[0].ToString();
            return ipAddress.Length > 15 ? string.Empty : ipAddress; 
        }
    }
}
