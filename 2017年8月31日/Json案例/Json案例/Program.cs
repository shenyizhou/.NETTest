using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Json案例
{
    /// <summary>
    /// 分段成绩POST请求参数
    /// </summary>
    public class NodeScorePostRequest
    {
        /// <summary>
        /// 比赛Id
        /// </summary>
        public int gameId { get; set; }
        /// <summary>
        /// 运动员Id
        /// </summary>
        public int athleteId { get; set; }
        /// <summary>
        /// 节点名称
        /// </summary>
        public string node { get; set; }
        /// <summary>
        /// 单位:秒
        /// </summary>
        public double time { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region 运动员GET请求

                // 根据基础URL创建客户端实例
                var client = new RestClient("http://192.168.0.115:8089/sport/0.1")
                {
                    Timeout = 3000
                };

                // 创建获取运动员请求
                RestRequest athleteGetRequest = new RestRequest("athlete", Method.GET);

                // 设置Token(登录成功时由后台返回)
                athleteGetRequest.AddHeader("TOKEN", "[B@11e85f2b");

                // 设置请求参数,只有itemId是必传参数,其他都是可传参数
                athleteGetRequest.AddQueryParameter("itemId", "1");                 // 运动会Id,必传参数
                //athleteGetRequest.AddQueryParameter("gameId", "1");                 // 比赛Id
                //athleteGetRequest.AddQueryParameter("groupId", "1");                // 分组Id
                //athleteGetRequest.AddQueryParameter("userName", "于");              // 运动员姓名,模糊查询
                athleteGetRequest.AddQueryParameter("idCard", "321540200510295123");// 运动员身份证,完全匹配
                //athleteGetRequest.AddQueryParameter("page", "0");                   // 查询第1页
                //athleteGetRequest.AddQueryParameter("pageSize", "10");              // 每页10条数据

                // 执行请求,获取结果
                var athleteGetResult = client.Execute(athleteGetRequest);

                // HTTP状态码是否为200
                if (athleteGetResult.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("查询运动员失败," + Convert.ToInt32(athleteGetResult.StatusCode) + " " +
                                        athleteGetResult.StatusDescription);
                }

                // 用Json解析
                var athleteGetJson = JObject.Parse(athleteGetResult.Content);

                // 判断是否有后台执行错误
                if (athleteGetJson["error"].HasValues)
                {
                    throw new Exception(athleteGetJson["error"]["message"].ToString());
                }

                // 获取结果里第一个运动员的Id
                var athlete = athleteGetJson["data"].FirstOrDefault();
                var athleteId = 0;
                if (athlete != null)
                {
                    athleteId = Convert.ToInt32(athlete["athleteId"]);
                }
                Console.WriteLine(athleteGetJson["successMsg"]);

                #endregion

                #region 分段成绩POST请求

                RestRequest scorePostRequest = new RestRequest("nodeScore", Method.POST);

                // 添加上传数据
                var dataList = new List<NodeScorePostRequest>();
                dataList.Add(new NodeScorePostRequest()
                {
                    gameId = 1,
                    athleteId = athleteId,
                    node = "firstNode",
                    time = 354.64
                });
                dataList.Add(new NodeScorePostRequest()
                {
                    gameId = 1,
                    athleteId = athleteId,
                    node = "secondNode",
                    time = 368.15
                });

                // POST PUT DELETE 类型请求 设置请求体写法
                var scorePostBody = JsonConvert.SerializeObject(new
                {
                    data = dataList.ToArray()
                });
                scorePostRequest.AddParameter("application/json", scorePostBody, ParameterType.RequestBody);

                var scorePostResult = client.Execute(scorePostRequest);
                if (scorePostResult.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("上传分段成绩失败," + Convert.ToInt32(scorePostResult.StatusCode) + " " +
                                        scorePostResult.StatusDescription);
                }
                var scorePostJson = JObject.Parse(scorePostResult.Content);
                if (scorePostJson["error"].HasValues)
                {
                    throw new Exception(scorePostJson["error"]["message"].ToString());
                }
                Console.WriteLine(scorePostJson["successMsg"]);

                #endregion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
